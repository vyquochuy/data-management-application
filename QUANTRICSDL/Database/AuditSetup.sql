-- 1. Kích hoạt audit
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER SYSTEM SET audit_trail = DB, EXTENDED SCOPE=SPFILE;

-- 2. Kết nối đúng PDB và user
ALTER SESSION SET CONTAINER = QLCSDL;
CONNECT school_user/123@localhost:1521/QLCSDL;

-- 3. Standard Audit: Audit SELECT và UPDATE trên NHANVIEN bởi GV001
AUDIT SELECT, UPDATE ON NHANVIEN BY GV001;

-- 4. FGA Audit: Truy cập LUONG, PHUCAP của NHANVIEN bởi người không phải NV TCHC
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'SCHOOL_USER',
    object_name     => 'NHANVIEN',
    policy_name     => 'AUDIT_LUONG_PHUCAP',
    audit_condition => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') NOT IN (''NV_TCHC'')',
    audit_column    => 'LUONG, PHUCAP',
    statement_types => 'SELECT, UPDATE',
    audit_trail     => DBMS_FGA.DB + DBMS_FGA.EXTENDED
  );
END;
/

-- 5. FGA Audit: Cập nhật điểm mà người đó không phải NV PKT
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'SCHOOL_USER',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_DIEM_BY_NON_PKT',
    audit_condition => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') NOT IN (''NV_PKT'')',
    audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',
    statement_types => 'UPDATE',
    audit_trail     => DBMS_FGA.DB + DBMS_FGA.EXTENDED
  );
END;
/

-- 6. FGA Audit: Sinh viên thao tác dữ liệu đăng ký học phần của người khác hoặc ngoài 14 ngày đầu học kỳ
-- (giả lập ngày học kỳ bắt đầu là 01/09/2023 cho học kỳ 1)
-- Cần tạo cột `NGDK` nếu muốn audit theo thời gian, hoặc dùng giả lập
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'SCHOOL_USER',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_SV_EDIT_OUT_OF_SCOPE',
    audit_condition => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') != MASV',
    audit_column    => NULL,
    statement_types => 'INSERT, UPDATE, DELETE',
    audit_trail     => DBMS_FGA.DB + DBMS_FGA.EXTENDED
  );
END;
/

-- Đọc audit log
SELECT * FROM DBA_AUDIT_TRAIL WHERE USERNAME = 'GV001';
SELECT * FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_NAME = 'NHANVIEN';
SELECT * FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_NAME = 'DANGKY';
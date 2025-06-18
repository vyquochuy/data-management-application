-- Kích hoạt audit
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER SYSTEM SET audit_trail = DB, EXTENDED SCOPE=SPFILE;
SHUTDOWN IMMEDIATE;
STARTUP;

-- Kết nối đúng PDB và user
ALTER SESSION SET CONTAINER = QLCSDL;
-- Để dùng các gói audit, security khác
GRANT EXECUTE ON DBMS_FGA TO school_user;
GRANT EXECUTE ON DBMS_SESSION TO school_user;
GRANT EXECUTE ON DBMS_RLS TO school_user; -- nếu có dùng VPD
GRANT SELECT ON DBA_FGA_AUDIT_TRAIL TO school_user; -- để đọc audit log

CONNECT school_user/123@localhost:1521/QLCSDL;

-- FGA Audit: Truy cập LUONG, PHUCAP của NHANVIEN bởi người không phải NV TCHC
CONNECT school_user/123@localhost:1521/QLCSDL;
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

-- FGA Audit: Cập nhật điểm mà người đó không phải NV PKT
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

-- FGA Audit: Sinh viên thao tác dữ liệu đăng ký học phần của người khác hoặc ngoài 14 ngày đầu học kỳ
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

--Tắt audit
ALTER SYSTEM SET audit_trail = NONE SCOPE=SPFILE;
-- Sau đó cũng cần SHUTDOWN và STARTUP lại
SHUTDOWN IMMEDIATE;
STARTUP;

-- Nếu cần xóa các policy đã tạo, có thể dùng đoạn sau:
--BEGIN
--  DBMS_FGA.DROP_POLICY(object_schema => 'SCHOOL_USER', object_name => 'NHANVIEN', policy_name => 'AUDIT_LUONG_PHUCAP');
--  DBMS_FGA.DROP_POLICY(object_schema => 'SCHOOL_USER', object_name => 'DANGKY', policy_name => 'AUDIT_DIEM_BY_NON_PKT');
--  DBMS_FGA.DROP_POLICY(object_schema => 'SCHOOL_USER', object_name => 'DANGKY', policy_name => 'AUDIT_SV_EDIT_OUT_OF_SCOPE');
--END;
--/

-- ========================
-- TẠO ROLE
-- ========================
CONNECT ADMIN/123@localhost:1521/QLCSDL;
CREATE ROLE ROLE_NVCB;
CREATE ROLE ROLE_GV;
CREATE ROLE ROLE_PDT;
CREATE ROLE ROLE_PKT;
CREATE ROLE ROLE_TCHC;
CREATE ROLE ROLE_TRGDV;
CREATE ROLE ROLE_SV;

-- ========================
-- CẤP QUYỀN CHO CÁC ROLE
-- ========================

-- ROLE_NVCB: Xem dòng của chính mình trong NHANVIEN, sửa DT
-- => VPD sẽ ép, chỉ cần SELECT, UPDATE
GRANT SELECT, UPDATE ON SCHOOL_USER.NHANVIEN TO ROLE_NVCB;

-- ROLE_GV:
GRANT SELECT ON SCHOOL_USER.MOMON TO ROLE_GV;
GRANT SELECT ON SCHOOL_USER.SINHVIEN TO ROLE_GV;
GRANT SELECT ON SCHOOL_USER.DANGKY TO ROLE_GV;

-- ROLE_PDT:
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.MOMON TO ROLE_PDT;
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.DANGKY TO ROLE_PDT;

-- ROLE_PKT:
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON SCHOOL_USER.DANGKY TO ROLE_PKT;

-- ROLE_TCHC:
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.NHANVIEN TO ROLE_TCHC;

-- ROLE_TRGDV:
GRANT SELECT ON SCHOOL_USER.NHANVIEN TO ROLE_TRGDV;
GRANT SELECT ON SCHOOL_USER.MOMON TO ROLE_TRGDV;

-- ROLE_SV:
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.DANGKY TO ROLE_SV;
GRANT SELECT, UPDATE(DCHI, DT) ON SCHOOL_USER.SINHVIEN TO ROLE_SV;
GRANT SELECT ON SCHOOL_USER.MOMON TO ROLE_SV;

-- ========================
-- TẠO USER TEST
-- ========================
-- Giảng viên
CREATE USER GV001 IDENTIFIED BY 123;
GRANT CONNECT TO GV001;
GRANT ROLE_GV TO GV001;

-- NV PKT
CREATE USER PKT01 IDENTIFIED BY 123;
GRANT CONNECT TO PKT01;
GRANT ROLE_PKT TO PKT01;

-- NV TCHC
CREATE USER TCHC01 IDENTIFIED BY 123;
GRANT CONNECT TO TCHC01;
GRANT ROLE_TCHC TO TCHC01;

-- Sinh viên SV001 (MASV giống user)
CREATE USER SV001 IDENTIFIED BY 123;
GRANT CONNECT TO SV001;
GRANT ROLE_SV TO SV001;

-- Trưởng đơn vị
CREATE USER TRGDV01 IDENTIFIED BY 123;
GRANT CONNECT TO TRGDV01;
GRANT ROLE_TRGDV TO TRGDV01;

-- Nhân viên cơ bản
CREATE USER NVCB01 IDENTIFIED BY 123;
GRANT CONNECT TO NVCB01;
GRANT ROLE_NVCB TO NVCB01;

-- NV PĐT
CREATE USER PDT01 IDENTIFIED BY 123;
GRANT CONNECT TO PDT01;
GRANT ROLE_PDT TO PDT01;



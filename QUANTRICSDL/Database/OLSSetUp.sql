-- Connect bằng SYS để cấu hình OLS

ALTER SESSION SET CONTAINER = CDB$ROOT;

BEGIN
    LBACSYS.CONFIGURE_OLS; -- This procedure registers Oracle Label Security. 
    LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; -- This procedure enables it
END;

SHUTDOWN IMMEDIATE; 
STARTUP; 

select * from v$services; 

ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;
ALTER PLUGGABLE DATABASE QLCSDL CLOSE IMMEDIATE; 
ALTER PLUGGABLE DATABASE QLCSDL OPEN READ WRITE;

ALTER SESSION SET CONTAINER= QLCSDL; 

CREATE USER ADMIN_OLS IDENTIFIED BY 123 CONTAINER = CURRENT;

GRANT SELECT, INSERT, UPDATE ON SCHOOL_USER.THONGBAO TO ADMIN_OLS;
GRANT CONNECT,RESOURCE TO ADMIN_OLS; --CẤP QUYỀN CONNECT VÀ RESOURCE 
GRANT UNLIMITED TABLESPACE TO ADMIN_OLS; --CẤP QUOTA CHO ADMIN_OLS 
GRANT SELECT ANY DICTIONARY TO ADMIN_OLS; --CẤP QUYỀN ĐỌC DICTIONARY ---> CẤP QUYỀN EXECUTE CHO ADMIN_OLS 
GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON LBACSYS.sa_user_admin TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON LBACSYS.sa_label_admin TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON sa_policy_admin TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON char_to_label TO ADMIN_OLS WITH GRANT OPTION; ---> ADD ADMIN_OLS VÀO LBAC_DBA 
GRANT LBAC_DBA TO ADMIN_OLS; 
GRANT EXECUTE ON sa_sysdba TO ADMIN_OLS;  
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO ADMIN_OLS; -- CẤP QUYỀN THỰC THI


CONNECT ADMIN_OLS/123@localhost:1521/QLCSDL

BEGIN
  SA_SYSDBA.CREATE_POLICY(
    policy_name     => 'THONGBAO_POLICY',
    column_name     => 'LABEL_COLUMN',
    default_options => 'READ_CONTROL'
  );
END;
/

EXEC SA_SYSDBA.ENABLE_POLICY ('THONGBAO_POLICY'); 
CONNECT ADMIN_OLS/123@localhost:1521/QLCSDL

-- 3. Tạo các LEVEL, COMPARTMENT, GROUP
BEGIN
  -- LEVEL
  SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY', 1, 'SINHVIEN', 'Sinh viên');
  SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY', 2, 'NHANVIEN', 'Nhân viên');
  SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY', 3, 'TRGDV', 'Trưởng đơn vị');

  -- COMPARTMENT
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 10, 'TOAN', 'Khoa Toán');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 20, 'LY', 'Khoa Lý');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 30, 'HOA', 'Khoa Hóa');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 40, 'HANHCHINH', 'Hành chính');

  -- GROUP
  SA_COMPONENTS.CREATE_GROUP('THONGBAO_POLICY', 1, 'COSO1', 'Cơ sở 1');
  SA_COMPONENTS.CREATE_GROUP('THONGBAO_POLICY', 2, 'COSO2', 'Cơ sở 2');
END;
/

-- 4. Tạo label
BEGIN
  -- NHÓM TRƯỞNG ĐƠN VỊ (TRGDV)                    (tag: 100–105)
  -- u1 / t1: Trưởng đơn vị có thể đọc được toàn bộ thông báo
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 100,
    label_value => 'TRGDV',
    data_label  => TRUE
  );  
  -- u2: Trưởng đơn vị phụ trách khoa Hóa tại cơ sở 2
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 101,
    label_value => 'TRGDV:HOA:COSO2',
    data_label  => TRUE
  );  
  -- u3: Trưởng đơn vị phụ trách khoa Lý tại cơ sở 2
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 102,
    label_value => 'TRGDV:LY:COSO2',
    data_label  => TRUE
  );  
  -- u6: Trưởng đơn vị có thể đọc được các thông báo về Hành chính
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 103,
    label_value => 'TRGDV:HANHCHINH',
    data_label  => TRUE
  );  
  -- t8: Trưởng khoa Hóa ở cơ sở 1
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 104,
    label_value => 'TRGDV:HOA:COSO1',
    data_label  => TRUE
  );  
  -- t9: Trưởng khoa Hóa ở cơ sở 1 và cơ sở 2
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 105,
    label_value => 'TRGDV:HOA:COSO1,COSO2',
    data_label  => TRUE
  );

  -- NHÓM NHÂN VIÊN (NHANVIEN)                   (tag: 110–112)
  -- u7 / t2: Nhân viên có thể đọc toàn bộ thông báo dành cho tất cả nhân viên
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 110,
    label_value => 'NHANVIEN',
    data_label  => TRUE
  );
  -- u4: Nhân viên thuộc khoa Hóa tại cơ sở 2
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 111,
    label_value => 'NHANVIEN:HOA:COSO2',
    data_label  => TRUE
  );  
  -- u8: Nhân viên có thể đọc thông báo về Hành chính tại cơ sở 1
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 112,
    label_value => 'NHANVIEN:HANHCHINH:COSO1',
    data_label  => TRUE
  );

  -- NHÓM SINH VIÊN (SINHVIEN)                  (tag: 120–124)
  -- t3: Cần phát tán đến tất cả sinh viên
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 120,
    label_value => 'SINHVIEN',
    data_label  => TRUE
  );
  -- u5: Sinh viên khoa Hóa tại cơ sở 2
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 121,
    label_value => 'SINHVIEN:HOA:COSO2',
    data_label  => TRUE
  );
  -- t4: Cần phát tán đến sinh viên thuộc khoa Hóa ở cơ sở 1
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 122,
    label_value => 'SINHVIEN:HOA:COSO1',
    data_label  => TRUE
  );
  -- t6: Cần phát tán đến sinh viên thuộc khoa Hóa ở cả hai cơ sở
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 123,
    label_value => 'SINHVIEN:HOA:COSO1,COSO2',
    data_label  => TRUE
  );
  -- t7: Cần phát tán đến tất cả sinh viên thuộc cả hai cơ sở
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 124,
    label_value => 'SINHVIEN::COSO1,COSO2',
    data_label  => TRUE
  );
END;
/

-- 5. Gán chính sách OLS vào bảng THONGBAO (chạy bằng admin)
BEGIN 
  SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    policy_name   => 'THONGBAO_POLICY',
    schema_name   => 'SCHOOL_USER',
    table_name    => 'THONGBAO',
    table_options => 'READ_CONTROL', 
    predicate     => NULL
  );
END;
/

CONNECT SCHOOL_USER/123@localhost:1521/QLCSDL;

CREATE SEQUENCE THONGBAO_SEQ
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;

CONNECT admin/123@localhost:1521/QLCSDL;

-- 1.1.3. Tạo user NHANVIEN_USER (mật khẩu đặt tạm là 'nv123')
CREATE USER NHANVIEN_USER IDENTIFIED BY nv123;

-- 1.1.4. Cấp quyền cơ bản để có thể đăng nhập và SELECT từ bảng THONGBAO
GRANT CONNECT TO NHANVIEN_USER;
GRANT CREATE SESSION TO NHANVIEN_USER;

-- 1.1.5. Cấp quyền SELECT trên bảng SCHOOL_USER.THONGBAO
GRANT SELECT ON SCHOOL_USER.THONGBAO TO NHANVIEN_USER;

CONNECT ADMIN_OLS/123@localhost:1521/QLCSDL
-- 1.2.2. Gán nhãn “NHANVIEN” cho user NHANVIEN_USER
BEGIN
  SA_USER_ADMIN.SET_USER_LABELS(
    policy_name => 'THONGBAO_POLICY',
    user_name => 'NHANVIEN_USER',
    max_read_label => 'NHANVIEN:HOA:COSO2',
    min_write_label => 'NHANVIEN',
    def_label => 'NHANVIEN:HOA:COSO2',
    row_label => 'NHANVIEN:HOA:COSO2'
  );
END;
/

-- BƯỚC 1: Connect với SYSTEM để cấp quyền
CONNECT SYS/123@localhost:1521/QLCSDL AS SYSDBA;

-- Cấp các quyền cần thiết cho school_user
GRANT EXECUTE ON DBMS_RLS TO school_user;
GRANT CREATE ANY CONTEXT TO school_user;
GRANT CREATE TRIGGER TO school_user;
GRANT ADMINISTER DATABASE TRIGGER TO school_user;

-- BƯỚC 2: Connect với school_user để thiết lập VPD
CONNECT school_user/123@localhost:1521/QLCSDL;

-- Function cho sinh viên chỉ xem được thông tin của chính mình
CREATE OR REPLACE FUNCTION policy_sinhvien_own_data(
    schema_var IN VARCHAR2,
    table_var IN VARCHAR2
) RETURN VARCHAR2
AS
    predicate VARCHAR2(400);
BEGIN
    predicate := 'MASV = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')';
    RETURN predicate;
END;
/

-- Function cho giảng viên xem sinh viên thuộc khoa mình (ĐÃ SỬA LỖI)
CREATE OR REPLACE FUNCTION policy_gv_view_students(
    schema_var IN VARCHAR2,
    table_var IN VARCHAR2
) RETURN VARCHAR2
AS
    predicate VARCHAR2(400);
    user_dept VARCHAR2(10);
BEGIN
    -- Sử dụng MAĐV thay vì MDĐV
    SELECT MADV INTO user_dept
    FROM NHANVIEN 
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    AND VAITRO = 'GV';
    
    predicate := 'KHOA = ''' || user_dept || '''';
    RETURN predicate;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN '1=0';
END;
/

-- Tạo context
CREATE OR REPLACE CONTEXT user_info_ctx USING set_user_context;

-- Package để set context
CREATE OR REPLACE PACKAGE set_user_context AS
    PROCEDURE set_role;
END;
/

CREATE OR REPLACE PACKAGE BODY set_user_context AS
    PROCEDURE set_role IS
        v_role VARCHAR2(20);
    BEGIN
        SELECT VAITRO INTO v_role
        FROM NHANVIEN 
        WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
        
        DBMS_SESSION.SET_CONTEXT('user_info_ctx', 'ROLE', v_role);
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            -- Kiểm tra nếu là sinh viên
            BEGIN
                SELECT 'SINHVIEN' INTO v_role
                FROM SINHVIEN 
                WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER');
                
                DBMS_SESSION.SET_CONTEXT('user_info_ctx', 'ROLE', 'SINHVIEN');
            EXCEPTION
                WHEN NO_DATA_FOUND THEN
                    DBMS_SESSION.SET_CONTEXT('user_info_ctx', 'ROLE', 'UNKNOWN');
            END;
    END set_role;
END;
/

-- Trigger tự động set context khi user login
CREATE OR REPLACE TRIGGER set_user_role_trigger
AFTER LOGON ON DATABASE
BEGIN
    set_user_context.set_role;
END;
/

-- Áp dụng VPD policies (ĐÃ SỬA SCHEMA NAME)
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'SCHOOL_USER',
        object_name => 'SINHVIEN',
        policy_name => 'policy_sinhvien_select',
        function_schema => 'SCHOOL_USER',
        policy_function => 'policy_sinhvien_own_data',
        statement_types => 'SELECT',
        policy_type => DBMS_RLS.CONTEXT_SENSITIVE
    );
END;
/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'SCHOOL_USER',
        object_name => 'SINHVIEN',
        policy_name => 'policy_sinhvien_update',
        function_schema => 'SCHOOL_USER', 
        policy_function => 'policy_sinhvien_own_data',
        statement_types => 'UPDATE',
        policy_type => DBMS_RLS.CONTEXT_SENSITIVE
    );
END;
/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'SCHOOL_USER',
        object_name => 'SINHVIEN',
        policy_name => 'policy_gv_view_students',
        function_schema => 'SCHOOL_USER',
        policy_function => 'policy_gv_view_students', 
        statement_types => 'SELECT',
        policy_type => DBMS_RLS.CONTEXT_SENSITIVE
    );
END;
/

-- Triggers kiểm soát
CREATE OR REPLACE TRIGGER trg_sinhvien_insert
BEFORE INSERT ON SINHVIEN
FOR EACH ROW
DECLARE
    v_role VARCHAR2(20);
BEGIN
    v_role := SYS_CONTEXT('user_info_ctx', 'ROLE');
    
    IF v_role = 'NV CTSV' THEN
        :NEW.TINHTRANG := NULL;
    END IF;
END;
/

CREATE OR REPLACE TRIGGER trg_sinhvien_update
BEFORE UPDATE ON SINHVIEN  
FOR EACH ROW
DECLARE
    v_role VARCHAR2(20);
BEGIN
    v_role := SYS_CONTEXT('user_info_ctx', 'ROLE');
    
    -- Chỉ NV PĐT mới được cập nhật TINHTRANG
    IF UPDATING('TINHTRANG') AND v_role != 'NV PĐT' THEN
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ nhân viên Phòng Đào tạo mới được cập nhật tình trạng học vụ');
    END IF;
    
    -- Sinh viên chỉ được cập nhật ĐCHI và ĐT
    IF v_role = 'SINHVIEN' THEN
        IF UPDATING('MASV') OR UPDATING('HOTEN') OR UPDATING('PHAI') OR 
           UPDATING('NGSINH') OR UPDATING('KHOA') OR UPDATING('TINHTRANG') THEN
            RAISE_APPLICATION_ERROR(-20002, 'Sinh viên chỉ được cập nhật địa chỉ và số điện thoại');
        END IF;
    END IF;
END;
/

-- Test script (chạy từng cái một để kiểm tra)
-- Test 1: Connect với user sinh viên (thay đổi thành username thực tế của sinh viên)
CONNECT SV001/123@localhost:1521/QLCSDL;
SELECT * FROM SCHOOL_USER.SINHVIEN;

-- Test 2: Connect với user giảng viên  
CONNECT gv001/123@localhost:1521/QLCSDL;
SELECT * FROM SCHOOL_USER.SINHVIEN;

COMMIT;
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER SYSTEM SET audit_trail = DB, EXTENDED SCOPE=SPFILE;
SHUTDOWN IMMEDIATE;
STARTUP;

-- Restart Oracle instance
SHUTDOWN IMMEDIATE;
STARTUP;

-- Kiểm tra bật audit thành công
SHOW PARAMETER audit_trail;

---------------------------------------------------------------
-- PHẦN AUDIT CHI TIẾT (Làm tại PDB QLCSDL)
---------------------------------------------------------------
ALTER SESSION SET CONTAINER = QLCSDL;

-- Xóa các audit cũ nếu có
NOAUDIT ALL;

---------------------------------------------------------------
-- Standard Audit (Audit toàn bộ các bảng cần thiết)
---------------------------------------------------------------

AUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.NHANVIEN BY ACCESS;
AUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.DANGKY BY ACCESS;
AUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.SINHVIEN BY ACCESS;

---------------------------------------------------------------
-- Unified Audit Rule (Audit logic phức tạp hơn)
---------------------------------------------------------------

-- Audit khi có UPDATE trên bảng DANGKY (chung cho mọi user)
AUDIT UPDATE ON SCHOOL_USER.DANGKY;

-- Audit khi có SELECT trên các cột lương/phụ cấp
AUDIT SELECT ON SCHOOL_USER.NHANVIEN;

---------------------------------------------------------------
-- PHẦN TEST AUDIT
---------------------------------------------------------------

-- Login bằng GV001
CONNECT GV001/123@localhost:1521/QLCSDL;

-- Thực hiện thao tác để sinh audit log
UPDATE SCHOOL_USER.DANGKY SET DIEMQT = 8 WHERE MASV = 'SV001';
COMMIT;

SELECT LUONG, PHUCAP FROM SCHOOL_USER.NHANVIEN;

UPDATE SCHOOL_USER.DANGKY SET DIEMTH = 10 WHERE MASV = 'SV002';
COMMIT;

---------------------------------------------------------------
-- PHẦN XEM LOG AUDIT SAU KHI TEST
---------------------------------------------------------------

CONNECT SYS/123@localhost:1521/QLCSDL AS SYSDBA;

GRANT SELECT ANY DICTIONARY TO SCHOOL_USER;


-- Login lại bằng SCHOOL_USER hoặc SYS
CONNECT SCHOOL_USER/123@localhost:1521/QLCSDL;

SELECT * FROM DBA_AUDIT_TRAIL ORDER BY EXTENDED_TIMESTAMP DESC;
-- Quyền hệ thống
SELECT * FROM dba_sys_privs WHERE grantee = ':username';

-- Quyền trên đối tượng
SELECT * FROM dba_tab_privs WHERE grantee = ':username';

-- Role được cấp
SELECT * FROM dba_role_privs WHERE grantee = ':username';

-- Quyền hệ thống của role
SELECT * FROM dba_sys_privs WHERE grantee = ':rolename';

-- Quyền trên đối tượng
SELECT * FROM dba_tab_privs WHERE grantee = ':rolename';

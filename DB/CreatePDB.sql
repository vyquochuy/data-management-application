DECLARE
  v_pdb_exists NUMBER;
BEGIN
  -- Kiểm tra xem PDB đã tồn tại chưa
  SELECT COUNT(*) INTO v_pdb_exists 
  FROM v$pdbs 
  WHERE name = 'QLCSDL';
  
  IF v_pdb_exists = 0 THEN
    -- Thực hiện tạo PDB nếu chưa tồn tại
    EXECUTE IMMEDIATE 
    'CREATE PLUGGABLE DATABASE QLCSDL
     ADMIN USER admin IDENTIFIED BY 123
     ROLES = (DBA)
     --sửa đường dẫn theo máy
     FILE_NAME_CONVERT = (''C:\APP\HUNGV\PRODUCT\21C\ORADATA\XE\PDBSEED'', 
                          ''C:\APP\HUNGV\PRODUCT\21C\ORADATA\XE\QLCSDL'')';
    
    -- Mở PDB sau khi tạo
    EXECUTE IMMEDIATE 'ALTER PLUGGABLE DATABASE QLCSDL OPEN';
    
    DBMS_OUTPUT.PUT_LINE('Đã tạo thành công PDB QLCSDL');
  ELSE
    -- Mở PDB nếu đã tồn tại nhưng đang ở trạng thái MOUNTED
    EXECUTE IMMEDIATE 'ALTER PLUGGABLE DATABASE QLCSDL OPEN';
    DBMS_OUTPUT.PUT_LINE('PDB QLCSDL đã tồn tại và đã được mở');
  END IF;
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Lỗi: ' || SQLERRM);
    -- Thử mở PDB nếu có lỗi nhưng PDB đã tồn tại
    BEGIN
      EXECUTE IMMEDIATE 'ALTER PLUGGABLE DATABASE QLCSDL OPEN';
      DBMS_OUTPUT.PUT_LINE('Đã mở PDB QLCSDL thành công sau khi phát hiện lỗi');
    EXCEPTION
      WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Không thể mở PDB: ' || SQLERRM);
    END;
END;
/     
CREATE ROLE GV;
CREATE ROLE SV;
CREATE ROLE TRGDV;
CREATE ROLE NVPDT;
CREATE ROLE NVPKT;
CREATE ROLE NVTCHC;
CREATE ROLE NVCTSV;

-- Tạo bảng HOCKY 
CONNECT school_user/123@localhost:1521/QLCSDL;
CREATE TABLE HOCKY (
  NAM NUMBER(4),
  HK NUMBER(1) CHECK (HK IN (1, 2, 3)),
  NGAYBD DATE,
  CONSTRAINT pk_hocky PRIMARY KEY (NAM, HK)
);

INSERT INTO HOCKY VALUES (2023, 1, TO_DATE('2023-09-01', 'YYYY-MM-DD'));
INSERT INTO HOCKY VALUES (2023, 2, TO_DATE('2024-01-01', 'YYYY-MM-DD'));
INSERT INTO HOCKY VALUES (2023, 3, TO_DATE('2024-05-01', 'YYYY-MM-DD'));
COMMIT;

-- Tạo VDP cho bảng DANGKY
BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'SCHOOL_USER',
    object_name     => 'DANGKY',
    policy_name     => 'VPD_DANGKY',
    function_schema => 'SCHOOL_USER',
    policy_function => 'VPD_DANGKY_FUNCTION',
    statement_types => 'SELECT, INSERT, UPDATE, DELETE',
    update_check    => TRUE
  );
END;

-- Trigger chặn sinh viên thao tác ngoài 14 ngày đầu học kỳ
CONNECT school_user/123@localhost:1521/QLCSDL;
CREATE OR REPLACE TRIGGER CHK_14NGAY_DANGKY
BEFORE INSERT OR UPDATE OR DELETE ON DANGKY
FOR EACH ROW
DECLARE
  v_role NVARCHAR2(20);
  v_nam NUMBER(4);
  v_hk NUMBER(1);
  v_ngaybd DATE;
BEGIN
  BEGIN
    SELECT VAITRO INTO v_role FROM NHANVIEN WHERE MANV = USER;
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      v_role := 'SV'; -- Nếu không thấy MANV → là sinh viên
  END;

  -- Chỉ áp dụng kiểm tra thời gian với SV và NV PĐT
  IF v_role IN ('SV', 'NV PĐT') THEN
    -- Xác định MAMM đang thao tác
    DECLARE v_mamm VARCHAR2(10);
    BEGIN
      IF INSERTING THEN
        v_mamm := :NEW.MAMM;
      ELSE
        v_mamm := :OLD.MAMM;
      END IF;

      -- Lấy học kỳ + năm từ MOMON
      SELECT NAM, HK INTO v_nam, v_hk FROM MOMON WHERE MAMM = v_mamm;

      -- Tìm ngày bắt đầu học kỳ từ bảng HOCKY
      SELECT NGAYBD INTO v_ngaybd FROM HOCKY WHERE NAM = v_nam AND HK = v_hk;

      -- Kiểm tra nếu đã quá 14 ngày
      IF SYSDATE > v_ngaybd + 14 THEN
        RAISE_APPLICATION_ERROR(-20004, 'Chỉ được thao tác trong 14 ngày đầu học kỳ');
      END IF;
    END;
  END IF;
END;
/

-- Trigger chặn cập nhật điểm nếu không phải NV PKT
CONNECT school_user/123@localhost:1521/QLCSDL;
CREATE OR REPLACE TRIGGER CHK_UPDATE_DIEM
BEFORE UPDATE OF DIEMTH, DIEMQT, DIEMCK, DIEMTK ON DANGKY
FOR EACH ROW
DECLARE
  v_role NVARCHAR2(20);
BEGIN
  BEGIN
    SELECT VAITRO INTO v_role FROM NHANVIEN WHERE MANV = USER;
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      v_role := 'SV'; -- Sinh viên không được phép sửa điểm
  END;

  IF v_role <> 'NV PKT' THEN
    RAISE_APPLICATION_ERROR(-20005, 'Chỉ nhân viên PKT được cập nhật điểm số');
  END IF;
END;
/

-- View ẩn điểm với sinh viên và NV PDT
-- View chỉ có MASV và MAMM

CONNECT school_user/123@localhost:1521/QLCSDL;
CREATE OR REPLACE VIEW V_DANGKY_PUBLIC AS
SELECT MASV, MAMM FROM DANGKY;

-- View đầy đủ có điểm
CREATE OR REPLACE VIEW V_DANGKY_FULL AS
SELECT * FROM DANGKY;

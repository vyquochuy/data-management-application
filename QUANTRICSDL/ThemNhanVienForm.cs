using System;
using System.Data;
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public partial class ThemNhanVienForm : Form
    {
        public ThemNhanVienForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string phai = txtPhai.Text.Trim();
            string ngsinh = txtNgaySinh.Text.Trim();
            string luong = txtLuong.Text.Trim();
            string phucap = txtPhuCap.Text.Trim();
            string dt = txtSDT.Text.Trim();
            string vaitro = txtVaiTro.Text.Trim();
            string madv = txtMaDV.Text.Trim();

            DataTable selectRoleSql = DatabaseHelper.ExecuteQuery("SELECT * FROM SESSION_ROLES WHERE ROLE = 'NVTCHC'");
            string  sql;
            if (string.IsNullOrWhiteSpace(manv) || string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.");
                return;
            }
            else if (selectRoleSql.Rows.Count > 0)
            {
                //role = "NVTCHC";
                sql = $"INSERT INTO SCHOOL_USER.NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) " +
                    $"VALUES ('{manv}', '{hoten}', '{phai}', TO_DATE('{ngsinh}', 'YYYY-MM-DD'), {luong}, {phucap}, {dt}, '{vaitro}', '{madv}')";
                DatabaseHelper.ExecuteNonQuery(sql);
                
                MessageBox.Show("Đã nhập thông tin nhân viên:\n" +
                    $"Mã NV: {manv}\nHọ Tên: {hoten}\nGiới tính: {phai}\nNgày sinh: {ngsinh}\nLương: {luong}\nPhụ cấp: {phucap}\nSĐT: {dt}\nVai trò: {vaitro}\nMã đơn vị: {madv}");
            }
         
        }
    }
}

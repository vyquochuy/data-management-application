using System;
using System.Data;
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public partial class EditNhanVienForm : Form
    {
        public EditNhanVienForm()
        {
            InitializeComponent();
            LoadMaNhanVien(); // Load danh sách MANV khi form mở
        }

        private void LoadMaNhanVien()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT MANV FROM SCHOOL_USER.NHANVIEN");
            comboBoxMaNV.DataSource = dt;
            comboBoxMaNV.DisplayMember = "MANV";
            comboBoxMaNV.ValueMember = "MANV";
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaNV.SelectedValue == null)
                return;

            string manv = comboBoxMaNV.SelectedValue.ToString();
            string sql = $"SELECT * FROM SCHOOL_USER.NHANVIEN WHERE MANV = '{manv}'";
            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtHoTen.Text = row["HOTEN"].ToString();
                txtPhai.Text = row["PHAI"].ToString();
                txtNgaySinh.Text = Convert.ToDateTime(row["NGSINH"]).ToString("yyyy-MM-dd");
                txtLuong.Text = row["LUONG"].ToString();
                txtPhuCap.Text = row["PHUCAP"].ToString();
                txtSDT.Text = row["DT"].ToString();
                txtVaiTro.Text = row["VAITRO"].ToString();
                txtMaDV.Text = row["MADV"].ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string manv = comboBoxMaNV.SelectedValue.ToString();
            string hoten = txtHoTen.Text.Trim();
            string phai = txtPhai.Text.Trim();
            string ngsinh = txtNgaySinh.Text.Trim();
            string luong = txtLuong.Text.Trim();
            string phucap = txtPhuCap.Text.Trim();
            string dt = txtSDT.Text.Trim();
            string vaitro = txtVaiTro.Text.Trim();
            string madv = txtMaDV.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.");
                return;
            }

            string sql = $"UPDATE SCHOOL_USER.NHANVIEN SET " +
                $"HOTEN = '{hoten}', " +
                $"PHAI = '{phai}', " +
                $"NGSINH = TO_DATE('{ngsinh}', 'YYYY-MM-DD'), " +
                $"LUONG = {luong}, " +
                $"PHUCAP = {phucap}, " +
                $"DT = {dt}, " +
                $"VAITRO = '{vaitro}', " +
                $"MADV = '{madv}' " +
                $"WHERE MANV = '{manv}'";

            DatabaseHelper.ExecuteNonQuery(sql);
            MessageBox.Show("Đã cập nhật thông tin nhân viên.");
        }
    }
}

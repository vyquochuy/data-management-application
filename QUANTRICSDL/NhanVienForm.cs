using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;

namespace QUANTRICSDL
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
            Load += NhanVien_Load;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            string sql;
            DataTable result = DatabaseHelper.ExecuteQuery("SELECT * FROM SESSION_ROLES WHERE ROLE = 'NVTCHC'");
            DataTable result2 = DatabaseHelper.ExecuteQuery("SELECT * FROM SESSION_ROLES WHERE ROLE = 'TRGDV'");
            if (result.Rows.Count > 0)
            {
                sql = "SELECT* FROM SCHOOL_USER.NHANVIEN";
            }

            else if (result2.Rows.Count > 0)
            {
                sql = $"SELECT * FROM SCHOOL_USER.NHANVIEN_TRGDV_VIEW";
            }
            else
            {
                sql = $"SELECT * FROM SCHOOL_USER.NHANVIEN_VIEW";
            }

            MessageBox.Show(sql);
            DataTable finalRes = DatabaseHelper.ExecuteQuery(sql);
            listViewNhanVien.Items.Clear();

            // Duyệt từng dòng trong DataTable finalRes
            foreach (DataRow row in finalRes.Rows)
            {
                // Giả sử các cột theo thứ tự hoặc tên đúng như bảng
                string manv = row["MANV"].ToString();
                string hoten = row["HOTEN"].ToString();
                string gioitinh = row["PHAI"].ToString();
                string ngaysinh = Convert.ToDateTime(row["NGSINH"]).ToString("dd/MM/yyyy");
                string luongcoban = row["LUONG"].ToString();
                string phucap = row["PHUCAP"].ToString();
                string dt = row["DT"].ToString();
                string chucvu = row["VAITRO"].ToString();
                string phongban = row["MADV"].ToString();

                // Tạo ListViewItem với mảng string các giá trị cột
                ListViewItem item = new ListViewItem(new string[] {
                manv, hoten, gioitinh, ngaysinh, luongcoban, phucap, dt, chucvu, phongban});

                listViewNhanVien.Items.Add(item);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable result = DatabaseHelper.ExecuteQuery("SELECT * FROM SESSION_ROLES WHERE ROLE = 'NVTCHC'");
            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Bạn không có quyền thêm nhân viên mới.");
            }
            else
            {
                ThemNhanVienForm form = new ThemNhanVienForm();
                form.ShowDialog();
            }

            //
        }

        private void listViewNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewNhanVien.SelectedItems.Count > 0)
            {
                var selectedItem = listViewNhanVien.SelectedItems[0];
                string manv = selectedItem.SubItems[0].Text; // Giả sử MANV là cột đầu tiên

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xoá nhân viên: {manv}?",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Xoá trong DB
                        string sql = $"DELETE FROM SCHOOL_USER.NHANVIEN WHERE MANV = '{manv}'";
                        DatabaseHelper.ExecuteNonQuery(sql);

                        // Xoá trên ListView
                        listViewNhanVien.Items.Remove(selectedItem);

                        MessageBox.Show("Đã xoá nhân viên thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xoá: " + ex.Message);
                    }
                }
            }
        }

        private void bChangeMyPhoneClick(object sender, EventArgs e)
        {
            string sdt = Interaction.InputBox("Nhập số điện thoại:", "Nhập SDT", "");
            if (!string.IsNullOrWhiteSpace(sdt))
            {
                try
                {
                    using (OracleConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        using (OracleCommand cmd = new OracleCommand("SCHOOL_USER.UPDATE_MY_PHONE", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Truyền tham số cho thủ tục
                            cmd.Parameters.Add("NEW_DT", OracleDbType.Varchar2).Value = sdt;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cập nhật số điện thoại thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.");
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{

        //}

        private void editClick(object sender, EventArgs e)
        {
            EditNhanVienForm form = new EditNhanVienForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void deleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn đúp vào một nhân để xóa");
        }

        private void listViewNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

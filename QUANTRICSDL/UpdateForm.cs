using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            this.Hide();
            manageForm.ShowDialog();
            this.Show();
        }

        private void bBack2_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            this.Hide();
            manageForm.ShowDialog();
            this.Show();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: làm combo box chọn role, hiển thị dropdown có check box, cho phép chọn nhiều role
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string newPassword = tbPassword.Text.Trim(); // Giả sử có TextBox tbNewPassword

            try
            {
                string sql = $"ALTER USER {username} IDENTIFIED BY {newPassword}";
                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật user thành công!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi cập nhật user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUpdate2_Click(object sender, EventArgs e)
        {
            //TODO: thực hiện hàm sửa ở đây và kiểm tra xem đối tượng được sửa có phù hợp không
            MessageBox.Show("Sửa thành công!");
        }
    }
}
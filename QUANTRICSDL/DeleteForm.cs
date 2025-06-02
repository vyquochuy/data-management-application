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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim(); // Giả sử có TextBox tbUsername

            DialogResult result = MessageBox.Show(
                $"Bạn có thật sự muốn xóa user {username} không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"DROP USER {username}";
                    DatabaseHelper.ExecuteNonQuery(sql);
                    MessageBox.Show("Đã xóa user thành công!");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi xóa user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bDelete2_Click(object sender, EventArgs e)
        {
            string roleName = textBox4.Text.Trim(); // Giả sử có TextBox tbRoleName để nhập tên ROLE

            DialogResult result = MessageBox.Show(
                $"Bạn có thật sự muốn xóa role {roleName} không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"DROP ROLE {roleName}";
                    DatabaseHelper.ExecuteNonQuery(sql);
                    MessageBox.Show("Đã xóa role thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi xóa role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
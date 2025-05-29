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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void bBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCreate2_Click(object sender, EventArgs e)
        {
            string roleName = textBox4.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(roleName, @"^[A-Z0-9_]+$"))
            {
                MessageBox.Show("Tên vai trò không hợp lệ. Chỉ được dùng chữ cái, số và dấu gạch dưới.");
                return;
            }

            try
            {
                string sql = $"CREATE ROLE {roleName}";
                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show($"Tạo vai trò '{roleName}' thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo role: " + ex.Message);
            }
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                string sql = $"CREATE USER {username} IDENTIFIED BY {password}";

                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show("Tạo user thành công!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi tạo user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: làm combo box chọn role, hiển thị dropdown có check box, cho phép chọn nhiều role
        }
        
    }
}
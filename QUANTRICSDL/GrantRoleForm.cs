using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;

namespace QUANTRICSDL
{
    public partial class GrantRoleForm : Form
    {
        public GrantRoleForm()
        {
            InitializeComponent();
            LoadUsersAndRoles();
        }

        private void LoadUsersAndRoles()
        {
            // Load user
            string userSql = "SELECT username FROM all_users WHERE common = 'NO'";
            DataTable userDt = DatabaseHelper.ExecuteQuery(userSql);
            cbUser.Items.Clear();
            foreach (DataRow row in userDt.Rows)
            {
                cbUser.Items.Add(row["username"].ToString());
            }

            // Load role
            string roleSql = "SELECT role FROM dba_roles WHERE common = 'NO'";
            DataTable roleDt = DatabaseHelper.ExecuteQuery(roleSql);
            cbRole.Items.Clear();
            foreach (DataRow row in roleDt.Rows)
            {
                cbRole.Items.Add(row["role"].ToString());
            }
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            string selectedUser = cbUser.SelectedItem?.ToString();
            string selectedRole = cbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedUser) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vui lòng chọn cả User và Role.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"GRANT {selectedRole} TO {selectedUser}";

            try
            {
                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show($"Gán role [{selectedRole}] cho user [{selectedUser}] thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
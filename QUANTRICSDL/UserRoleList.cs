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
    public partial class UserRoleList : Form
    {
        public UserRoleList()
        {
            InitializeComponent();
            FormHelper.SetStandardSize(this);
            LoadUsers();
            LoadRoles();
        }

        private void LoadUsers()
        {
            userListView.Clear();
            userListView.View = View.Details;

            userListView.Columns.Add("Tên người dùng", 150);
            userListView.Columns.Add("Đối tượng", 80);
            userListView.Columns.Add("Quyền", 200);

            try
            {
                string sql = "SELECT username, 'OPEN' AS account_status FROM all_users Where common = 'NO'";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["username"].ToString());
                    item.SubItems.Add(row["account_status"].ToString());
                    //item.SubItems.Add(row["default_role"].ToString());
                    userListView.Items.Add(item);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi tải danh sách người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoles()
        {
            roleListView.Clear();
            roleListView.View = View.Details;
            roleListView.Columns.Add("Mã vai trò", 100);
            roleListView.Columns.Add("Tên vai trò", 150);
            roleListView.Columns.Add("Ghi chú", 200);

            try
            {
                string sql = "SELECT role, role_id, authentication_type FROM dba_roles Where common = 'NO'";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["role_id"].ToString());
                    item.SubItems.Add(row["role"].ToString());
                    item.SubItems.Add(row["authentication_type"].ToString());
                    roleListView.Items.Add(item);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi tải danh sách role", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count > 0) // Kiểm tra xem có item nào được chọn không
            {
                // Lấy item đầu tiên được chọn
                ListViewItem selectedItem = userListView.SelectedItems[0];

                // Lấy thông tin chi tiết từ item
                string userName = selectedItem.SubItems[0].Text;    // Cột Tên người dùng
                string objectType = selectedItem.SubItems[1].Text;  // Cột Đối tượng
                //string note = selectedItem.SubItems[2].Text;        // Cột Ghi chú

                // Mở form chi tiết và truyền dữ liệu
                //UserDetailForm detailForm = new UserDetailForm(objectType, userName, note);
                //detailForm.ShowDialog();  // Sử dụng ShowDialog để mở form như một cửa sổ modally (tạm thời ngừng tương tác với form chính)
                MessageBox.Show(userName);
            }
        }
        private void roleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form: Chi tiết role");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

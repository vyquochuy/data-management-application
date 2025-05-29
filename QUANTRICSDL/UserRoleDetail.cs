using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QUANTRICSDL
{
    public partial class UserRoleDetail : Form
    {
        public UserRoleDetail()
        {
            InitializeComponent();
            LoadUserAndRoles();
        }

        private void LoadUserAndRoles()
        {
            cbUserOrRole.Items.Clear();

            // Lấy danh sách users
            DataTable users = DatabaseHelper.ExecuteQuery("SELECT username FROM all_users WHERE common = 'NO'");
            foreach (DataRow row in users.Rows)
            {
                cbUserOrRole.Items.Add(row["username"].ToString());
            }

            // Lấy danh sách roles
            DataTable roles = DatabaseHelper.ExecuteQuery("SELECT role FROM dba_roles WHERE common = 'NO'");
            foreach (DataRow row in roles.Rows)
            {
                cbUserOrRole.Items.Add(row["role"].ToString());
            }
        }

        private void btnViewPrivileges_Click(object sender, EventArgs e)
        {
            string grantee = cbUserOrRole.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(grantee)) return;

            listViewPrivileges.Items.Clear();

            string sql = $@"
                SELECT TABLE_NAME, PRIVILEGE, GRANTABLE, TYPE 
                FROM DBA_TAB_PRIVS 
                WHERE GRANTEE = '{grantee}'";

            DataTable dt = DatabaseHelper.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                string privilege = row["PRIVILEGE"].ToString();
                string grantable = row["GRANTABLE"].ToString();
                string type = row["TYPE"].ToString(); // mặc định là 'OBJECT' như đã alias

                ListViewItem item = new ListViewItem(tableName);
                item.SubItems.Add(privilege);
                item.SubItems.Add(grantable);
                item.SubItems.Add(type);

                listViewPrivileges.Items.Add(item);
            }
        }
    }
}

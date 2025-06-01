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
    public partial class RevokePrivilegesForm : Form
    {
        public RevokePrivilegesForm()
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

            sql = $@"
                SELECT TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE
                FROM DBA_COL_PRIVS 
                WHERE GRANTEE = '{grantee}'";
            dt = DatabaseHelper.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString() + "_" + row["COLUMN_NAME"].ToString();
                string privilege = row["PRIVILEGE"].ToString();
                string grantable = row["GRANTABLE"].ToString();
                string type = "TABLE";

                ListViewItem item = new ListViewItem(tableName);
                item.SubItems.Add(privilege);
                item.SubItems.Add(grantable);
                item.SubItems.Add(type);

                listViewPrivileges.Items.Add(item);
            }

            this.listViewPrivileges.ItemActivate += new System.EventHandler(this.listViewPrivileges_ItemActivate);

        }

        private void listViewPrivileges_ItemActivate(object sender, EventArgs e)
        {
            if (listViewPrivileges.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = listViewPrivileges.SelectedItems[0];
            string tableName = selectedItem.SubItems[0].Text;
            string privilege = selectedItem.SubItems[1].Text;
            string type = selectedItem.SubItems[3].Text;
            string grantee = cbUserOrRole.Text.Trim().ToUpper();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn thu hồi quyền {privilege} trên {tableName} từ {grantee}?",
                "Xác nhận thu hồi quyền",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string revokeSql = "";
                    if (tableName.Contains("V_")) // view: quyền xem trên cột
                    {
                        revokeSql = $"REVOKE SELECT ON {tableName} FROM {grantee}";
                    }
                    else if (tableName.Contains("_") && type == "TABLE") // update cột
                    {
                        // giải pháp là xóa quyền trên cả bảng, sau đó cấp lại quyền trên các cột không cần xóa
                        string col = tableName.Split('_').Last();
                        string table = tableName.Split("_").First();

                        string selectColSql = $"SELECT COLUMN_NAME " +
                            $"FROM DBA_COL_PRIVS " +
                            $"WHERE GRANTEE = '{grantee}' " +
                            $"AND TABLE_NAME = '{table}' " +
                            $"AND COLUMN_NAME != '{col}'";

                        //MessageBox.Show(selectColSql);
                        DataTable dt = DatabaseHelper.ExecuteQuery(selectColSql);


                        string revokeLocalSql = $"REVOKE UPDATE ON SCHOOL_USER.{table} FROM {grantee}";
                        DatabaseHelper.ExecuteQuery(revokeLocalSql);

                        //MessageBox.Show("Số dòng trong dt: " + dt.Rows.Count);
                        foreach (DataRow row in dt.Rows)
                        {
                            string grantAgainSql = $" GRANT UPDATE ({row["COLUMN_NAME"].ToString()}) " +
                                $"ON SCHOOL_USER.{table} TO {grantee}";
                            //MessageBox.Show(grantAgainSql);
                            DatabaseHelper.ExecuteQuery(grantAgainSql);
                        }


                    }
                    else if (privilege == "UPDATE") // UPDATE TRÊN TOÀN BẢNG
                    {
                        revokeSql = $"REVOKE UPDATE ON SCHOOL_USER.{tableName} FROM {grantee}";

                    }
                    else
                    {
                        // Quyền trên bảng
                        revokeSql = $"REVOKE {privilege} ON SCHOOL_USER.{tableName} FROM {grantee}";
                    }

                    if (revokeSql != "")
                    {
                        MessageBox.Show(revokeSql);
                        DatabaseHelper.ExecuteNonQuery(revokeSql);

                    }
                    MessageBox.Show("Thu hồi quyền thành công.");
                    btnViewPrivileges_Click(null, null); // Reload lại list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thu hồi quyền: " + ex.Message);
                }
            }
        }
    }
}

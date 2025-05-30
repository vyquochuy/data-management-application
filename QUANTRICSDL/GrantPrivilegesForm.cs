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
using System.Xml.Linq;
namespace QUANTRICSDL
{
    public partial class GrantPrivilegesForm : Form
    {
        public GrantPrivilegesForm()
        {
            InitializeComponent();
            LoadUsersAndRoles();
            LoadObjectTypes();
        }

        private void LoadUsersAndRoles()
        {

            cbUserRole.Items.Clear();
            try
            {
                // Load user
                string userSql = "SELECT username FROM all_users WHERE common = 'NO'";
                DataTable userDt = DatabaseHelper.ExecuteQuery(userSql);
                foreach (DataRow row in userDt.Rows)
                {
                    cbUserRole.Items.Add(row["username"].ToString());
                }

                // Load role
                string roleSql = "SELECT role FROM dba_roles WHERE common = 'NO'";
                DataTable roleDt = DatabaseHelper.ExecuteQuery(roleSql);
                foreach (DataRow row in roleDt.Rows)
                {
                    cbUserRole.Items.Add(row["role"].ToString());
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void LoadObjectTypes()
        {
            cbObjectType.Items.AddRange(new[] { "TABLE", "VIEW", "PROCEDURE", "FUNCTION" });
        }

        private void cbObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbObject.Items.Clear();
            string objectType = cbObjectType.SelectedItem.ToString();
            //string sql = $"SELECT object_name FROM dba_objects WHERE object_type = '{objectType}'";
            string sql = $"SELECT object_name FROM dba_objects WHERE object_type = '{objectType}' AND owner = 'SCHOOL_USER'";

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);
                foreach (DataRow row in dt.Rows)
                {
                    cbObject.Items.Add(row["object_name"].ToString());
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void cbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbColumns.Items.Clear();
            if (cbObjectType.SelectedItem.ToString() == "TABLE" || cbObjectType.SelectedItem.ToString() == "VIEW")
            {
                string tableName = cbObject.SelectedItem.ToString();
                string sql = $"SELECT column_name FROM dba_tab_columns WHERE table_name = '{tableName}'";
                try
                {
                    DataTable dt = DatabaseHelper.ExecuteQuery(sql);
                    foreach (DataRow row in dt.Rows)
                    {
                        clbColumns.Items.Add(row["column_name"].ToString());
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
        private void bGrant_Click(object sender, EventArgs e)
        {
            string userOrRole = cbUserRole.SelectedItem?.ToString() ?? string.Empty;
            string objectName = cbObject.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(objectName) || string.IsNullOrEmpty(userOrRole))
            {
                MessageBox.Show("Please select a user/role and an object before granting privileges.");
                return;
            }
            bool withGrantOption = chkWithGrantOption.Checked;

            try
            {
                string privilege = clbPrivileges.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(privilege))
                {
                    MessageBox.Show("Vui lòng chọn một quyền.", "Thông báo");
                    return;
                }

                //string objectName = cbObject.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(objectName))
                {
                    MessageBox.Show("Vui lòng chọn đối tượng.", "Thông báo");
                    return;
                }

                string sql;

                // Nếu có chọn cột và quyền là SELECT hoặc
                if (clbColumns.CheckedItems.Count > 0 && (privilege == "SELECT"))
                {
                    foreach (string column in clbColumns.CheckedItems)
                    {
                        // Tạo tên view theo yêu cầu
                        string viewName = $"v_{objectName}_{column}";

                        // Tạo view chỉ chứa 1 cột
                        string createViewSql = $"CREATE OR REPLACE VIEW {viewName} AS SELECT {column} FROM SCHOOL_USER.{objectName}";
                        MessageBox.Show(createViewSql, "Câu lệnh SQL đang chạy");

                        DatabaseHelper.ExecuteNonQuery(createViewSql);

                        // Cấp quyền trên view
                        string grantSql = $"GRANT {privilege} ON {viewName} TO {userOrRole}";
                        if (withGrantOption) grantSql += " WITH GRANT OPTION";

                        MessageBox.Show(grantSql, "Câu lệnh SQL đang chạy");
                        DatabaseHelper.ExecuteNonQuery(grantSql);
                    }
                }
                else if (clbColumns.CheckedItems.Count > 0 && (privilege == "UPDATE"))
                {
                    foreach (string column in clbColumns.CheckedItems)
                    {
                        sql = $"GRANT UPDATE ({column}) ON SCHOOL_USER.{objectName} TO {userOrRole}";
                        if (withGrantOption) sql += " WITH GRANT OPTION";

                        MessageBox.Show(sql, "Câu lệnh SQL đang chạy");
                        DatabaseHelper.ExecuteNonQuery(sql);
                    }
                }
                else
                {
                    // Cấp quyền trực tiếp trên bảng
                    sql = $"GRANT {privilege} ON SCHOOL_USER.{objectName} TO {userOrRole}";
                    if (withGrantOption) sql += " WITH GRANT OPTION";

                    MessageBox.Show(sql, "Câu lệnh SQL đang chạy");
                    DatabaseHelper.ExecuteNonQuery(sql);
                }


                MessageBox.Show("Cấp quyền thành công!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
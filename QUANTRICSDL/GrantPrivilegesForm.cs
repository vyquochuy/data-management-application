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
                string sql = "SELECT username FROM dba_users UNION SELECT role FROM dba_roles Where common = 'NO'";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);
                foreach (DataRow row in dt.Rows)
                {
                    cbUserRole.Items.Add(row["username"].ToString());
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
            string sql = $"SELECT object_name FROM dba_objects WHERE object_type = '{objectType}'";
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
                foreach (string privilege in clbPrivileges.CheckedItems.Cast<string>())
                {
                    string sql = "";

                    if (clbColumns.CheckedItems.Count > 0 && (privilege == "SELECT" || privilege == "UPDATE"))
                    {
                        string columns = string.Join(",", clbColumns.CheckedItems.Cast<string>());
                        sql = $"GRANT {privilege} ({columns}) ON {objectName} TO {userOrRole}";
                    }
                    else
                    {
                        sql = $"GRANT {privilege} ON {objectName} TO {userOrRole}";
                    }

                    if (withGrantOption) sql += " WITH GRANT OPTION";

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
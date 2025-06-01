using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QUANTRICSDL
{
    public partial class AuditLogForm : Form
    {
        public AuditLogForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bSeen_Click(object sender, EventArgs e)
        {
            if (cbUser.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xem Audit!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedUser = cbUser.SelectedItem.ToString().ToUpper();
            listViewLogInform.Items.Clear();

            try
            {
                string sqlAudit = @"
            SELECT 
                OBJ_NAME AS OBJECT_NAME, 
                OBJ_NAME AS TABLE_NAME, 
                ACTION_NAME, 
                NULL AS COLUMN_NAME,
                TO_CHAR(EXTENDED_TIMESTAMP, 'YYYY-MM-DD HH24:MI:SS') AS ACTION_TIME, 
                COMMENT_TEXT AS DATA_CONTENT
            FROM DBA_AUDIT_TRAIL
            WHERE USERNAME = :username
            ORDER BY EXTENDED_TIMESTAMP DESC";

                var param1 = new OracleParameter("username", selectedUser);
                DataTable dtAudit = DatabaseHelper.ExecuteQuery(sqlAudit, param1);

                foreach (DataRow row in dtAudit.Rows)
                {
                    var item = new ListViewItem(new[] {
                row["OBJECT_NAME"]?.ToString(),
                row["TABLE_NAME"]?.ToString(),
                row["ACTION_NAME"]?.ToString(),
                "", // không có column cụ thể trong audit chuẩn
                row["ACTION_TIME"]?.ToString(),
                row["DATA_CONTENT"]?.ToString()
            });
                    listViewLogInform.Items.Add(item);
                }

                string sqlFga = @"
            SELECT 
                OBJECT_NAME, 
                OBJECT_NAME AS TABLE_NAME, 
                STATEMENT_TYPE AS ACTION_NAME,
                POLICY_NAME AS COLUMN_NAME, 
                TO_CHAR(TIMESTAMP, 'YYYY-MM-DD HH24:MI:SS') AS ACTION_TIME, 
                SQL_TEXT AS DATA_CONTENT
            FROM DBA_FGA_AUDIT_TRAIL
            WHERE UPPER(DB_USER) = :username
            ORDER BY TIMESTAMP DESC";

                var param2 = new OracleParameter("username", selectedUser);
                DataTable dtFga = DatabaseHelper.ExecuteQuery(sqlFga, param2);

                foreach (DataRow row in dtFga.Rows)
                {
                    var item = new ListViewItem(new[] {
                row["OBJECT_NAME"]?.ToString(),
                row["TABLE_NAME"]?.ToString(),
                row["ACTION_NAME"]?.ToString(),
                row["COLUMN_NAME"]?.ToString(),
                row["ACTION_TIME"]?.ToString(),
                row["DATA_CONTENT"]?.ToString()
            });
                    listViewLogInform.Items.Add(item);
                }

                if (listViewLogInform.Items.Count == 0)
                {
                    MessageBox.Show("Người dùng này chưa có log nào.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn log: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listViewLogInform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            cbUser.Items.Clear();

            try
            {
                string query = "SELECT username FROM all_users WHERE common = 'NO' ORDER BY username";
                DataTable users = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in users.Rows)
                {
                    cbUser.Items.Add(row["username"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuditLogForm_Load(object sender, EventArgs e)
        {
            listViewLogInform.View = View.Details;
            listViewLogInform.Columns.Clear();
            listViewLogInform.Columns.Add("Tên đối tượng", 120);
            listViewLogInform.Columns.Add("Tên bảng", 120);
            listViewLogInform.Columns.Add("Hành động", 100);
            listViewLogInform.Columns.Add("Cột bị tác động", 150);
            listViewLogInform.Columns.Add("Thời gian", 160);
            listViewLogInform.Columns.Add("Nội dung", 300);
        }
    }
}

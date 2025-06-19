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
                    DBUSERNAME, 
                    TO_CHAR(EVENT_TIMESTAMP, 'YYYY-MM-DD HH24:MI:SS') AS ACTION_TIME, 
                    ACTION_NAME, 
                    OBJECT_NAME, 
                    UNIFIED_AUDIT_POLICIES, 
                    SQL_TEXT
                FROM UNIFIED_AUDIT_TRAIL
                WHERE DBUSERNAME = :username
                ORDER BY EVENT_TIMESTAMP DESC";


                var param1 = new OracleParameter("username", selectedUser);
                DataTable dtAudit = DatabaseHelper.ExecuteQuery(sqlAudit, param1);

                foreach (DataRow row in dtAudit.Rows)
                {
                    var item = new ListViewItem(new[] {
                    row["OBJECT_NAME"]?.ToString(),                  // Tên đối tượng
                    row["ACTION_TIME"]?.ToString(),                  // Thời gian
                    row["ACTION_NAME"]?.ToString(),                  // Hành động
                    row["SQL_TEXT"]?.ToString()                      // Nội dung (SQL Text)
                });

                    listViewLogInform.Items.Add(item);
                }

                lbStatus.Text = $"Đã tải {listViewLogInform.Items.Count} log từ DBA_AUDIT_TRAIL cho user {selectedUser}.";


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
            listViewLogInform.FullRowSelect = true;
            listViewLogInform.GridLines = true;
            listViewLogInform.DoubleClick += listViewLogInform_DoubleClick;
        }

        private void btnEnableAudit_Click(object sender, EventArgs e)
        {
            // Bật audit cho các bảng NHANVIEN, DANGKY, SINHVIEN
            try
            {
                string[] auditSqls = new string[]
                {
            "AUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.NHANVIEN BY ACCESS",
            "AUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.DANGKY BY ACCESS",
            "AUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.SINHVIEN BY ACCESS"
                };

                foreach (string sql in auditSqls)
                {
                    DatabaseHelper.ExecuteNonQuery(sql);
                }

                lbStatus.Text = "Đã bật audit cho các bảng NHANVIEN, DANGKY, SINHVIEN.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi bật audit: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisableAudit_Click(object sender, EventArgs e)
        {
            //Chỉ tắt audit cho các bảng đã bật audit
            try
            {
                string[] auditSqls = new string[]
                {
            "NOAUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.NHANVIEN",
            "NOAUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.DANGKY",
            "NOAUDIT SELECT, INSERT, UPDATE, DELETE ON SCHOOL_USER.SINHVIEN"
                };

                foreach (string sql in auditSqls)
                {
                    DatabaseHelper.ExecuteNonQuery(sql);
                }

                lbStatus.Text = "Đã tắt audit cho các bảng NHANVIEN, DANGKY, SINHVIEN.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tắt audit: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewLogInform_DoubleClick(object sender, EventArgs e)
        {
            if (listViewLogInform.SelectedItems.Count > 0)
            {
                string sql = listViewLogInform.SelectedItems[0].SubItems[3].Text; // Cột "Nội dung"
                MessageBox.Show(sql, "Chi tiết câu lệnh SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

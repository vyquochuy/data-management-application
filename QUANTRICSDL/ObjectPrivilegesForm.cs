using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Security.AccessControl;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QUANTRICSDL
{
    public partial class ObjectPrivilegesForm : Form
    {
        private List<string> tableList = new List<string>();

        public ObjectPrivilegesForm()
        {
            InitializeComponent();
            //FormHelper.SetStandardSize(this);

            // Load danh sách bảng trước
            LoadTableList();

            // Sau khi có tableList thì load dữ liệu cho từng tab
            for (int i = 0; i < tableList.Count; i++)
            {
                if (i < tabControl1.TabPages.Count)
                {
                    LoadRoleDataForTab(tabControl1.TabPages[i], tableList[i], i);
                }
            }
        }

        private void LoadTableList()
        {
            try
            {
                string sql = "SELECT object_name FROM all_objects WHERE object_type = 'TABLE' AND owner = 'SCHOOL_USER'";

                // Giả sử DatabaseHelper có method ExecuteQuery trả về DataTable
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);

                tableList.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    tableList.Add(row["object_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load danh sách bảng: " + ex.Message);
            }
        }

        private void LoadRoleDataForTab(TabPage tabPage, string tableName, int i)
        {
            tabPage.Text = tableName;

            ListView listView = GetListViewByTabPage(tabPage);
            listView.Items.Clear();
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Dock = DockStyle.Fill;
            listView.Columns.Clear();

            listView.Columns.Add("Người dùng/vai trò", 150);
            listView.Columns.Add("Bảng (cột)", 120);
            listView.Columns.Add("Quyền", 120);
            listView.Columns.Add("Cấp quyền này cho người khác", 200);

            List<List<string>> data = new List<List<string>>();
            
            // LOAD QUYỀN THEO ĐỐI TƯỢNG BẢNG
            string sqlLoadTable = $"SELECT GRANTEE, TABLE_NAME, PRIVILEGE, GRANTABLE " +
                $"FROM DBA_TAB_PRIVS " +
                $"WHERE TABLE_NAME LIKE '%{tableName}%'" +
                $"AND GRANTEE != 'ADMIN'";

            DataTable dt = DatabaseHelper.ExecuteQuery(sqlLoadTable);

            foreach (DataRow row in dt.Rows)
            {
                string grantee = row[0].ToString();
                string tableNameInData = row[1].ToString();
                string privilege = row[2].ToString();
                string grantable = row[3].ToString();

                data.Add(new List<string> { grantee, tableNameInData, privilege, grantable });
            }

            // LOAD QUYỀN THEO CỘT
            string sqlLoadColumn = $"SELECT GRANTEE, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE " +
                $"FROM DBA_COL_PRIVS " +
                $"WHERE TABLE_NAME LIKE '%{tableName}%'" +
                $"AND GRANTEE != 'ADMIN'";
            dt = DatabaseHelper.ExecuteQuery(sqlLoadColumn);
            foreach (DataRow row in dt.Rows)
            {
                string grantee = row[0].ToString();
                string tableNameInData = row[1].ToString() + "_" + row[2].ToString();
                string privilege = row[3].ToString();
                string grantable = row[4].ToString();

                data.Add(new List<string> { grantee, tableNameInData, privilege, grantable });
            }


            // LOAD DỮ LIỆU TỪ BẢNG GHI LÊN LISTVIEW
            foreach (var row in data)
            {
                ListViewItem item = new ListViewItem(row[0]);
                item.SubItems.Add(row[1]);
                item.SubItems.Add(row[2]);
                item.SubItems.Add(row[3]);
                listView.Items.Add(item);
            }

            tabPage.Controls.Clear();
            tabPage.Controls.Add(listView);
        }

        private ListView GetListViewByTabPage(TabPage tabPage)
        {
            if (tabPage == tabPage1) return listView1;
            if (tabPage == tabPage2) return listView2;
            if (tabPage == tabPage3) return listView3;
            if (tabPage == tabPage4) return listView4;
            if (tabPage == tabPage5) return listView5;
            if (tabPage == tabPage6) return listView6;
            return new ListView();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            // Xử lý khi click tab chưa biết
        }
    }
}

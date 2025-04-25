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
    public partial class ObjectPrivilegesForm : Form
    {

        List<string> tableList = new List<string>()
        {
            "NHANVIEN",
            "SINHVIEN",
            "DONVI",
            "HOCPHAN",
            "MONHOC",
            "DANGKY",
        };

        public ObjectPrivilegesForm()
        {
            InitializeComponent();
            FormHelper.SetStandardSize(this);

            for (int i = 0; i < tableList.Count; i++)
            {
                if (i < tabControl1.TabPages.Count) // tránh lỗi nếu lệch số tab
                {
                    LoadRoleDataForTab(tabControl1.TabPages[i], tableList[i]);
                }
            }
        }

        private void LoadRoleDataForTab(TabPage tabPage, string tableName)
        {
            ListView listView = GetListViewByTabPage(tabPage);
            listView.Items.Clear(); // Xoá dữ liệu cũ
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Dock = DockStyle.Fill;
            listView.Columns.Clear();

            // Thêm cột và sữa cột cho phù hợp
            listView.Columns.Add("Tên người dùng", 150);
            listView.Columns.Add("Role", 120);
            listView.Columns.Add("Quyền", 120);
            listView.Columns.Add("Ghi chú", 200);

            // TODO: Viết SQL để lấy quyền từ DBA_TAB_PRIVS hoặc USER_TAB_PRIVS
            // Đây là ví dụ giả lập thôi
            List<List<string>> data = new List<List<string>>()
            {
                new List<string> { "user_a", "DBA", "SELECT", "Truy vấn bảng " + tableName },
                new List<string> { "user_b", "DEV", "UPDATE", "Cập nhật bảng " + tableName }
            };

            foreach (var row in data)
            {
                ListViewItem item = new ListViewItem(row[0]);
                item.SubItems.Add(row[1]);
                item.SubItems.Add(row[2]);
                item.SubItems.Add(row[3]);
                listView.Items.Add(item);
            }

            tabPage.Controls.Clear(); // Xóa sạch trước
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
            return new ListView(); // fallback
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            // xử lí khi nhấn vào các thông tin chưa biết xử lí gì hết
        }
    }
}

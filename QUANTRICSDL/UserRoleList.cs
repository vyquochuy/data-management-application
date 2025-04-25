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

            // Thêm cột (tuỳ ý đại ca)
            userListView.Columns.Add("Tên người dùng", 150);
            userListView.Columns.Add("Đối tượng", 80);
            userListView.Columns.Add("Quyền", 200);

            // Dữ liệu mẫu kiểu nhiều dòng
            List<List<string>> users = new List<List<string>>()
            {
                new List<string> { "Nguyễn Hùng Việt", "Sinh viên", "Xem bảng hehe" },
                new List<string> { "Mai Nhựt Huy", "Nhân viên", "Admin hệ thống" },
                new List<string> { "Vy Huy", "Nhân viên", "Chỉ đọc" }
            }; // TODO: gọi sql

            foreach (var row in users)
            {
                ListViewItem item = new ListViewItem(row[0]); // Mã
                item.SubItems.Add(row[1]);                    // Tên người dùng
                item.SubItems.Add(row[2]);                    // Ghi chú
                userListView.Items.Add(item);
            }

            // Tự động mở rộng cột theo txt
            //userListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LoadRoles()
        {
            roleListView.Clear();
            roleListView.View = View.Details;

            // Thêm cột (có thể thêm nữa nếu cần)
            roleListView.Columns.Add("Mã vai trò", 100);
            roleListView.Columns.Add("Tên vai trò", 150);
            roleListView.Columns.Add("Ghi chú", 200);

            // Dữ liệu mẫu nhiều dòng
            List<List<string>> roles = new List<List<string>>()
            {
                new List<string> { "R01", "DBA", "Quản trị toàn bộ hệ thống" },
                new List<string> { "R02", "Developer", "Phát triển ứng dụng" },
                new List<string> { "R03", "Analyst", "Phân tích dữ liệu" },
                new List<string> { "R04", "Guest", "Chỉ xem" }
            }; // TODO: gọi SQL

            foreach (var row in roles)
            {
                ListViewItem item = new ListViewItem(row[0]); // Mã vai trò
                item.SubItems.Add(row[1]);                    // Tên vai trò
                item.SubItems.Add(row[2]);                    // Ghi chú
                roleListView.Items.Add(item);
            }

            // Tự động mở rộng cột theo txt
            //userListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
                string note = selectedItem.SubItems[2].Text;        // Cột Ghi chú

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

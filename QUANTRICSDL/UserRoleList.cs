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
            LoadUserRoleList();
        }

        private void LoadUserRoleList()
        {
            // Giả lập dữ liệu
            var users = new List<(string, string)>
            {
                ("admin", "User"),
                ("manager", "User"),
                ("HR", "Role"),
                ("Finance", "Role")
            };

            foreach (var (name, type) in users)
            {
                var item = new ListViewItem(name);
                item.SubItems.Add(type);
                lvUsersRoles.Items.Add(item);
            }
        }
    }
}

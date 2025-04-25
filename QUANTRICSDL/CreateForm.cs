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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            this.Hide();
            manageForm.ShowDialog();
            this.Show();
        }

        private void bBack2_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            this.Hide();
            manageForm.ShowDialog();
            this.Show();
        }

        private void bCreate2_Click(object sender, EventArgs e)
        {
            //TODO: thực hiện hàm tạo mới ở đây và kiểm tra xem đối tượng được tạo có phù hợp không
            MessageBox.Show("Tạo thành công!");
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            //TODO: thực hiện hàm tạo mới ở đây và kiểm tra xem đối tượng được tạo có phù hợp không
            MessageBox.Show("Tạo thành công!");
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: làm combo box chọn role, hiển thị dropdown có check box, cho phép chọn nhiều role
        }
    }
}

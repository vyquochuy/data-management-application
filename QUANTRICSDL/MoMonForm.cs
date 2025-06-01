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
    public partial class MoMonForm : Form
    {
        public MoMonForm()
        {
            InitializeComponent();
            loadListView();
        }

        private void loadListView()
        {
            ListViewItem item = new ListViewItem(new[] { "MM001", "HP001", "GV001", "1", "2025" });
            lvMoMon.Items.Add(item);

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); // hoặc mở form trước đó nếu có
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thêm đang được phát triển...");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa đang được phát triển...");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa đang được phát triển...");
        }

        private void lvMoMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

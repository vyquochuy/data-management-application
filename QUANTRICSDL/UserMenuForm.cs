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
    public partial class UserMenuForm : Form
    {
        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienForm nhanVien = new NhanVienForm();
            //this.Hide();
            nhanVien.Show();
            //this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MoMonForm momonForm = new MoMonForm();
            //this.Hide();
            momonForm.Show();
            //this.Show();
        }

        private void btnGuiThongBao_Click(object sender, EventArgs e)
        {
            ThongBaoForm thongBaoForm = new ThongBaoForm();
            this.Hide();
            thongBaoForm.ShowDialog();
            this.Show();
        }

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            ThongBaoListForm listForm = new ThongBaoListForm();
            this.Hide();
            listForm.ShowDialog();
            this.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVienForm = new SinhVienForm();
            sinhVienForm.ShowDialog();

        }

        private void UserMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            DangKyForm d = new DangKyForm();
            d.ShowDialog();
        }
    }
}

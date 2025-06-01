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
            NhanVien nhanVien = new NhanVien();
            this.Hide();
            nhanVien.Show();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MoMonForm momonForm = new MoMonForm();
            this.Hide();
            momonForm.Show();
            this.Hide();
            this.Show();
        }
    }
}

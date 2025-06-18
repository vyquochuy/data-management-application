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
    public partial class DangKyForm : Form
    {
        public DangKyForm()
        {
            InitializeComponent();
            Load += DangKyForm_Load;
        }

        private void DangKyForm_Load(object sender, EventArgs e)
        {

        }

        private void listViewDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn đúp vào dòng để xóa");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

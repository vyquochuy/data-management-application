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
    }
}

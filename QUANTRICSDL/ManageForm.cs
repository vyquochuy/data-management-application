using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            this.Hide();
            createForm.ShowDialog();
            this.Show();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            this.Hide();
            deleteForm.ShowDialog();
            this.Show();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            //MenuForm menuForm = new MenuForm();
            this.Close();
        }

        private void bGrantRole_Click(object sender, EventArgs e)
        {
            GrantRoleForm grantRoleForm = new GrantRoleForm();
            this.Hide();
            grantRoleForm.ShowDialog();
            this.Show();
        }
        private void bGrantPrivileges_Click(object sender, EventArgs e)
        {
            GrantPrivilegesForm grantForm = new GrantPrivilegesForm();
            this.Hide();
            grantForm.ShowDialog();
            this.Show();
        }

        private void bRevoke_Click(object sender, EventArgs e)
        {
            RevokePrivilegesForm re = new RevokePrivilegesForm();
            this.Hide();
            re.ShowDialog();
            this.Show();
        }
    }
}
namespace QUANTRICSDL
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnQuanLyUserRole_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            this.Hide();
            manageForm.ShowDialog();
            this.Show();
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            UserRoleList userRoleList = new UserRoleList();
            this.Hide();
            userRoleList.ShowDialog();
            this.Show();
        }

        private void btnXemThongTinQuyen_Click(object sender, EventArgs e)
        {
            ObjectPrivilegesForm objectPrivilegesForm = new ObjectPrivilegesForm();
            this.Hide();
            objectPrivilegesForm.ShowDialog();
            this.Show();
        }

        private void btnUserRoleDetail(object sender, EventArgs e)
        {
            UserRoleDetail userRoleDetail = new UserRoleDetail();
            this.Hide();
            userRoleDetail.ShowDialog();
            this.Show();
        }
    }
}
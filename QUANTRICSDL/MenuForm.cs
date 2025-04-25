namespace QUANTRICSDL
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            FormHelper.SetStandardSize(this);
            // TODO: kết nối đb
            //this.Load += new System.EventHandler(this.MenuForm_Load);

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                var conn = DatabaseHelper.GetConnection();
                MessageBox.Show("Kết nối thành công!", "Thông báo");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối");
            }
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

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
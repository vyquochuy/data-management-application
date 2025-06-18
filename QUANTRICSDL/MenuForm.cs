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

        private void bAuditLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền xem audit log
                string test = "SELECT COUNT(*) FROM DBA_AUDIT_TRAIL WHERE ROWNUM = 1";
                DatabaseHelper.ExecuteScalar(test); // nếu lỗi → vào catch

                AuditLogForm auditLogForm = new AuditLogForm();
                this.Hide();
                auditLogForm.ShowDialog();
                this.Show();
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
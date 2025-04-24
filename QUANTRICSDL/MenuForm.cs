namespace QUANTRICSDL
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            // TODO: kết nối đb
            //this.Load += new System.EventHandler(this.MenuForm_Load);

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                var conn = DatabaseHelper.GetConnection();
                MessageBox.Show("✅ Kết nối thành công!", "Thông báo");
                conn.Close(); // Đừng quên đóng nha đại ca
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối");
            }
        }

        private void btnQuanLyUserRole_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form: Quản lý User/Role");
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form: Xem danh sách User/Role");
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form: Cấp quyền");
        }

        private void btnThuHoiQuyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form: Thu hồi quyền");
        }

        private void btnXemThongTinQuyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form: Xem thông tin quyền");
        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

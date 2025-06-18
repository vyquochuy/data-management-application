using System;
using System.Windows.Forms;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace QUANTRICSDL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = bLogin;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
                return;
            }

            DatabaseHelper.SetConnectionString(username, password);

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    if (username == "ADMIN" || username == "admin" || username == "school_user")
                    {
                        AutoGrant.updateNhanVien();
                        MenuForm menuForm = new MenuForm();
                        this.Hide();
                        menuForm.ShowDialog();
                        this.Show();
                    }
                    else 
                    {
                        UserMenuForm menuForm = new UserMenuForm();
                        this.Hide();
                        menuForm.ShowDialog();
                        this.Show();
                    }
}
            }
            catch (OracleException ex)
            {
                string message = $"Đăng nhập thất bại!\n\n" +
                                 $"Lỗi Oracle: {ex.Number}\n" +
                                 $"Thông điệp: {ex.Message}\n";

                // Gợi ý theo mã lỗi phổ biến
                switch (ex.Number)
                {
                    case 1017:
                        message += "Gợi ý: Sai tên người dùng hoặc mật khẩu.\n";
                        break;
                    case 12170:
                        message += "Gợi ý: Kết nối đến máy chủ Oracle bị timeout. Kiểm tra lại TNS, firewall, hoặc listener.\n";
                        break;
                    case 12514:
                        message += "Gợi ý: SERVICE_NAME trong chuỗi kết nối không đúng hoặc Oracle chưa start.\n";
                        break;
                    case 12541:
                        message += "Gợi ý: Listener không hoạt động. Thử chạy lệnh 'lsnrctl start' trên máy chủ Oracle.\n";
                        break;
                    case 28000:
                        message += "Gợi ý: Tài khoản bị khóa. Dùng tài khoản quản trị để mở khóa bằng ALTER USER.\n";
                        break;
                    case 28001:
                        message += "Gợi ý: Mật khẩu hết hạn. Cần đổi mật khẩu.\n";
                        break;
                    case 65096:
                        message += "Gợi ý: Bạn đang tạo user ở container DB thay vì pluggable DB.\n";
                        break;
                    default:
                        message += "Gợi ý: Kiểm tra lại chuỗi kết nối, listener và quyền truy cập.\n";
                        break;
                }

                MessageBox.Show(message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

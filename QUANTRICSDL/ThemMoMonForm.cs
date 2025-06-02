using System;
using System.Data;
using System.Data.SqlClient; // Hoặc OracleClient tùy hệ cơ sở dữ liệu
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public partial class ThemMoMonForm : Form
    {
        public ThemMoMonForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mamon = txtMAMM.Text.Trim();
            string mahp = txtMAHP.Text.Trim();
            string magv = txtMAGV.Text.Trim();
            string hk = txtHK.Text.Trim();
            string nam = txtNAM.Text.Trim();

            if (string.IsNullOrEmpty(mamon) || string.IsNullOrEmpty(mahp) ||
                string.IsNullOrEmpty(magv) || string.IsNullOrEmpty(hk) || string.IsNullOrEmpty(nam))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {
                using (var conn = new Oracle.ManagedDataAccess.Client.OracleConnection("your_connection_string_here"))
                {
                    conn.Open();
                    string query = "INSERT INTO MOMON (MAMM, MAHP, MAGV, HK, NAM) VALUES (:mamm, :mahp, :magv, :hk, :nam)";
                    using (var cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(":mamm", mamon);
                        cmd.Parameters.Add(":mahp", mahp);
                        cmd.Parameters.Add(":magv", magv);
                        cmd.Parameters.Add(":hk", int.Parse(hk));
                        cmd.Parameters.Add(":nam", int.Parse(nam));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mở môn thành công.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); // hoặc chuyển về form chính nếu có
        }
    }
}

using Oracle.ManagedDataAccess.Client;
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
    public partial class ThongBaoListForm : Form
    {
        private DataGridView dgvThongBao;
        private Button btnQuayLai;

        public ThongBaoListForm()
        {
            InitializeComponent();
            LoadThongBao();
        }

        private void LoadThongBao()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT ID, NOIDUNG FROM SCHOOL_USER.THONGBAO ORDER BY ID DESC";
                    using (var cmd = new OracleCommand(sql, conn))
                    {
                        using (var adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvThongBao.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông báo: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


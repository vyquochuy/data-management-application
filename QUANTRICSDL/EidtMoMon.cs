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
    public partial class EditMoMonForm : Form
    {
        public EditMoMonForm()
        {
            InitializeComponent();
            LoadMAMMList();
        }

        private void LoadMAMMList()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT MAMM FROM SCHOOL_USER.MOMON_NVPDT_VIEW");
                cbMAMM.DataSource = dt;
                cbMAMM.DisplayMember = "MAMM";
                cbMAMM.ValueMember = "MAMM";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách MAMM: " + ex.Message);
            }
        }

        private void cbMAMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMAMM = cbMAMM.SelectedValue.ToString();
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery($"SELECT * FROM SCHOOL_USER.MOMON_NVPDT_VIEW WHERE MAMM = '{selectedMAMM}'");
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtMAHP.Text = row["MAHP"].ToString();
                    txtMAGV.Text = row["MAGV"].ToString();
                    txtHK.Text = row["HK"].ToString();
                    txtNAM.Text = row["NAM"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string mamm = cbMAMM.SelectedValue.ToString();
            string mahp = txtMAHP.Text.Trim();
            string magv = txtMAGV.Text.Trim();
            string hk = txtHK.Text.Trim();
            string nam = txtNAM.Text.Trim();

            if (string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(magv) || string.IsNullOrEmpty(hk) || string.IsNullOrEmpty(nam))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {
                string sql = $"UPDATE SCHOOL_USER.MOMON_NVPDT_VIEW " +
                    $"SET MAHP = '{mahp}', MAGV = '{magv}'" +
                    $" WHERE MAMM = '{mamm}'";
                MessageBox.Show(sql);
                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

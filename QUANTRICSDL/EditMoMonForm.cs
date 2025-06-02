// EditMoMonForm.cs
using System;
using System.Data;
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public partial class EditMoMonForm : Form
    {
        public EditMoMonForm()
        {
            InitializeComponent();
            LoadMAMM();
        }

        private void LoadMAMM()
        {
            string sql = "SELECT MAMM FROM MOMON";
            DataTable dt = DatabaseHelper.ExecuteQuery(sql);
            cbMAMM.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cbMAMM.Items.Add(row["MAMM"].ToString());
            }
        }

        private void cbMAMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMAMM = cbMAMM.SelectedItem.ToString();
            string sql = "SELECT * FROM SCHOOL_USER.MOMON WHERE MAMM = '" + selectedMAMM + "'";
            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtMAHP.Text = row["MAHP"].ToString();
                txtMAGV.Text = row["MAGV"].ToString();
                txtHK.Text = row["HK"].ToString();
                txtNAM.Text = row["NAM"].ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string mamm = cbMAMM.SelectedItem.ToString();
            string mahp = txtMAHP.Text.Trim();
            string magv = txtMAGV.Text.Trim();
            string hk = txtHK.Text.Trim();
            string nam = txtNAM.Text.Trim();

            string sql = $"UPDATE MOMON SET MAHP = '{mahp}', MAGV = '{magv}', HK = {hk}, NAM = {nam} WHERE MAMM = '{mamm}'";
            try
            {
                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

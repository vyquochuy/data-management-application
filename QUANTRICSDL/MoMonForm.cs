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
    public partial class MoMonForm : Form
    {
        public MoMonForm()
        {
            InitializeComponent();
            loadListView();
        }

        private string loadRole()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS");

            foreach (DataRow row in dt.Rows)
            {
                string role = row["GRANTED_ROLE"].ToString();

                if (role == "SV")
                    return "SV";
                if (role == "GV")
                    return "GV";
                if (role == "NVPDT")
                    return "NVPDT";
                if (role == "TRGDV")
                    return "TRGDV";
            }

            return "";
        }


        private void loadListView()
        {
            string role = loadRole();
            string view;
            if (role == "SV")
                view = "MOMON_SINHVIEN_VIEW";
            else if (role == "TRGDV")
                view = "MOMON_TRGDV_VIEW";
            else if (role == "NVPDT")
                view = "MOMON_NVPDT_VIEW";
            else if (role == "GV")
                view = "MOMON_GV_VIEW";
            else
                return;

            string sql = $"SELECT * FROM SCHOOl_USER.{view}"; ;
            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

            lvMoMon.Items.Clear();

            // Duyệt từng dòng và thêm vào ListView
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    row["MAMM"].ToString(),
                    row["MAHP"].ToString(),
                    row["MAGV"].ToString(),
                    row["HK"].ToString(),
                    row["NAM"].ToString()
                });

                lvMoMon.Items.Add(item);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (loadRole() == "NVPDT")
            {
                ThemMoMonForm momonForm = new ThemMoMonForm();
                this.Hide();
                momonForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không quyền thêm");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn đúp vào hàng để xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditMoMonForm form = new EditMoMonForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void lvMoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadRole() != "NVPDT")
            {
                MessageBox.Show("Bạn không có quyền xóa");
                return;
            }

            if (lvMoMon.SelectedItems.Count == 0)
                return;

            var result = MessageBox.Show("Bạn có chắc muốn xóa dòng đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            ListViewItem item = lvMoMon.SelectedItems[0];
            string mamon = item.SubItems[0].Text;
            string mahp = item.SubItems[1].Text;
            string magv = item.SubItems[2].Text;
            string hk = item.SubItems[3].Text;
            string nam = item.SubItems[4].Text;

            try
            {
                string sql = $@"
                DELETE FROM SCHOOL_USER.MOMON_NVPDT_VIEW
                WHERE MAMM = '{mamon}'";

                MessageBox.Show(sql);
                DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show("Đã xóa thành công.");
                loadListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANTRICSDL
{
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();
            Load += loadStudents;
        }

        private string getRole()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS");

            foreach (DataRow row in dt.Rows)
            {
                string role = row["GRANTED_ROLE"].ToString();

                if (role == "GV")
                    return role;
                if (role == "NVPDT")
                    return role;
                if (role == "TRGDV")
                    return role;
                if (role == "SV")
                    return role;
            }

            return "";
        }

        private void loadStudents(object sender, EventArgs e)
        {
            string roleCur = getRole();
            if (roleCur == "")
            {
                MessageBox.Show("Bạn không có quyền truy cập");
                return;
            }

            try
            {
                string sql = "SELECT MASV, HOTEN, PHAI, NGSINH, DCHI, DT, KHOA, TINHTRANG FROM SCHOOL_USER.SINHVIEN";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);


                listViewSinhVien.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MASV"].ToString());
                    item.SubItems.Add(row["HOTEN"].ToString());
                    item.SubItems.Add(row["PHAI"].ToString());

                    // Format ngày sinh
                    string ngsinh = Convert.ToDateTime(row["NGSINH"]).ToString("dd/MM/yyyy");
                    item.SubItems.Add(ngsinh);

                    item.SubItems.Add(row["ĐCHI"].ToString());
                    item.SubItems.Add(row["ĐT"].ToString());
                    item.SubItems.Add(row["KHOA"].ToString());
                    item.SubItems.Add(row["TINHTRANG"]?.ToString() ?? "");

                    listViewSinhVien.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sinh viên: " + ex.Message);
            }
        }


        private void listViewSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listViewSinhVien_MouseClick(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấp đúp vào dòng cần xóa");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 
        }
    }
}

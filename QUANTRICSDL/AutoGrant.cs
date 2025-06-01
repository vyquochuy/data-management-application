using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QUANTRICSDL
{
    internal class AutoGrant
    {
        public static void updateNhanVien()
        {
            try
            {
                // Lấy danh sách USERNAME từ hệ thống
                DataTable dtUsers = DatabaseHelper.ExecuteQuery("SELECT USERNAME FROM ALL_USERS");
                List<string> usernames = dtUsers.AsEnumerable()
                                                .Select(row => row["USERNAME"].ToString().ToUpper())
                                                .ToList();

                // Lấy danh sách MANV từ bảng NHANVIEN
                DataTable dtManv = DatabaseHelper.ExecuteQuery("SELECT MANV FROM SCHOOL_USER.NHANVIEN");
                List<string> manvs = dtManv.AsEnumerable()
                                           .Select(row => row["MANV"].ToString().ToUpper())
                                           .ToList();

                // So khớp USERNAME với MANV
                var matchedUsers = usernames.Intersect(manvs);
                foreach (string user in matchedUsers)
                {
                    try
                    {
                        DatabaseHelper.ExecuteNonQuery($"GRANT NVCB TO \"{user}\"");
                        //MessageBox.Show($"Đã cấp role NVCB cho user: {user}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cấp quyền cho {user}: {ex.Message}");
                    }
                }

                //MessageBox.Show("Đã cập nhật quyền xong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện updateNhanVien: " + ex.Message);
            }
        }
    }
}

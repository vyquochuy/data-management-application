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
    public partial class ThongBaoForm : Form
    {
        public ThongBaoForm()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            // 1. Lấy nội dung
            string noiDung = txtNoiDung.Text.Trim();
            if (string.IsNullOrEmpty(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung thông báo.");
                return;
            }

            // 2. Lấy level (1,2,3) từ comboBox
            string capBac = cbCapBac.SelectedItem.ToString();
            int level = GetLevelValue(capBac);

            // 3. Lấy danh sách donVi (các string như "Toán","Lý","Hóa","Hành chính")
            var donViSelected = clbDonVi.CheckedItems.Cast<string>().ToList();
            // 4. Lấy danh sách coSo (các string như "Cơ sở 1","Cơ sở 2")
            var coSoSelected = clbCoSo.CheckedItems.Cast<string>().ToList();

            // 5. Tính ra "tag" nhãn (số) ngay trong C#
            int label = ComputeLabelTag(level, donViSelected, coSoSelected);

            if (label > 0)
            {
                try
                {
                    // 6. Chèn trực tiếp với giá trị label vừa tính
                    string sql = "INSERT INTO THONGBAO (ID, NOIDUNG, LABEL_COLUMN) " +
                                 "VALUES (THONGBAO_SEQ.NEXTVAL, :nd, :lbl)";

                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(":nd", OracleDbType.Varchar2).Value = noiDung;
                            cmd.Parameters.Add(":lbl", OracleDbType.Int32).Value = label;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Gửi thông báo thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi thông báo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không tính được giá trị nhãn (label).");
            }
        }

        /// <summary>
        /// Chuyển tên cấp bậc ("Trưởng đơn vị"/"Nhân viên"/"Sinh viên") thành số 3/2/1.
        /// </summary>
        private int GetLevelValue(string levelName)
        {
            return levelName switch
            {
                "Trưởng đơn vị" => 3,
                "Nhân viên" => 2,
                "Sinh viên" => 1,
                _ => 1
            };
        }

        /// <summary>
        /// Ánh xạ tên đơn vị ("Toán"/"Lý"/"Hóa"/"Hành chính") thành code (chuỗi) tương ứng:
        ///     "Toán" -> "10"
        ///     "Lý"  -> "20"
        ///     "Hóa" -> "30"
        ///     "Hành chính" -> "40"
        /// </summary>
        private string GetDonViCode(string donVi)
        {
            return donVi switch
            {
                "Toán" => "10",
                "Lý" => "20",
                "Hóa" => "30",
                "Hành chính" => "40",
                _ => null
            };
        }

        /// <summary>
        /// Ánh xạ tên cơ sở ("Cơ sở 1"/"Cơ sở 2") thành code (chuỗi):
        ///     "Cơ sở 1" -> "1"
        ///     "Cơ sở 2" -> "2"
        /// </summary>
        private string GetCoSoCode(string coSo)
        {
            return coSo switch
            {
                "Cơ sở 1" => "1",
                "Cơ sở 2" => "2",
                _ => null
            };
        }

        /// <summary>
        /// Tính "label_tag" (số nguyên) dựa trên:
        ///   - level: 1/2/3
        ///   - danh sách donViSelected (các tên "Toán","Lý","Hóa","Hành chính")
        ///   - danh sách coSoSelected (các tên "Cơ sở 1"/"Cơ sở 2")
        /// 
        /// Cơ chế:
        ///   1. Từ level => lấy levelName = "SINHVIEN"/"NHANVIEN"/"TRGDV"
        ///   2. Từ donViSelected => build danh sách mã compartments như ["10","30",...] 
        ///      rồi chuyển qua tên "TOAN"/"HOA"/... 
        ///   3. Từ coSoSelected => build danh sách mã groups như ["1","2",...] 
        ///      rồi chuyển qua tên "COSO1"/"COSO2"
        ///   4. Ghép thành chuỗi labelStr theo cú pháp trong olsSetUp (vd: "TRGDV:HOA:COSO2")
        ///   5. Tra cứu trong dictionary để lấy số tag tương ứng (vd: 101)
        ///   6. Nếu không tìm thấy, trả về -1
        /// 
        /// Các nhãn bạn đã tạo trong olsSetUp.sql là:
        ///   - Level 3 (TRGDV):
        ///       tag=100 => "TRGDV"
        ///       tag=101 => "TRGDV:HOA:COSO2"
        ///       tag=102 => "TRGDV:LY:COSO2"
        ///       tag=103 => "TRGDV:HANHCHINH"
        ///       tag=104 => "TRGDV:HOA:COSO1"
        ///       tag=105 => "TRGDV:HOA:COSO1,COSO2"
        ///   - Level 2 (NHANVIEN):
        ///       tag=110 => "NHANVIEN"
        ///       tag=111 => "NHANVIEN:HOA:COSO2"
        ///       tag=112 => "NHANVIEN:HANHCHINH:COSO1"
        ///   - Level 1 (SINHVIEN):
        ///       tag=120 => "SINHVIEN"
        ///       tag=121 => "SINHVIEN:HOA:COSO2"
        ///       tag=122 => "SINHVIEN:HOA:COSO1"
        ///       tag=123 => "SINHVIEN:HOA:COSO1,COSO2"
        ///       tag=124 => "SINHVIEN::COSO1,COSO2"
        /// </summary>
        private int ComputeLabelTag(int level, List<string> donViSelected, List<string> coSoSelected)
        {
            // 1. Chuyển level thành tên levelName
            string levelName = level switch
            {
                1 => "SINHVIEN",
                2 => "NHANVIEN",
                3 => "TRGDV",
                _ => "SINHVIEN"
            };

            // 2. Từ danh sách donViSelected (vd: ["Toán","Hóa"]), lấy ra code ["10","30"] rồi thành ["TOAN","HOA"]
            var compNames = new List<string>();
            foreach (var dv in donViSelected)
            {
                string dvCode = GetDonViCode(dv); // "10","20","30","40"
                if (dvCode == "10") compNames.Add("TOAN");
                else if (dvCode == "20") compNames.Add("LY");
                else if (dvCode == "30") compNames.Add("HOA");
                else if (dvCode == "40") compNames.Add("HANHCHINH");
            }

            // 3. Từ danh sách coSoSelected (vd: ["Cơ sở 1","Cơ sở 2"]) => ["1","2"] rồi thành ["COSO1","COSO2"]
            var groupNames = new List<string>();
            foreach (var cs in coSoSelected)
            {
                string csCode = GetCoSoCode(cs); // "1" hoặc "2"
                if (csCode == "1") groupNames.Add("COSO1");
                else if (csCode == "2") groupNames.Add("COSO2");
            }

            // 4. Ghép thành chuỗi v_labelStr theo quy ước OLS 
            //    ( levelName [ + ":" + compList ] [ + ":" + groupList ] ).
            //    Lưu ý: nếu không có compNames và không có groupNames => chỉ để levelName
            string compPart = compNames.Count > 0 ? string.Join(",", compNames) : null;
            string groupPart = groupNames.Count > 0 ? string.Join(",", groupNames) : null;

            string labelStr = levelName;
            if (compPart != null && groupPart != null)
            {
                // Cả hai đều có => "TRGDV:HOA,COSO| … :COSO…"
                // Nhưng theo olsSetUp.sql, format compartments chỉ là "HOA" (không join bởi dấu phẩy nếu chỉ 1),
                // nếu có nhiều compartments (vd có 2 đv), format là "DV1,DV2", tuỳ bạn.
                // Ở đây chúng ta làm tương tự: "TRGDV:HOA: COSO2" hoặc "TRGDV:HOA,LY:COSO1,COSO2"
                labelStr = $"{levelName}:{compPart}:{groupPart}";
            }
            else if (compPart != null)
            {
                // Chỉ có compartments, không có group => "TRGDV:HOA" hoặc "NHANVIEN:HANHCHINH"
                labelStr = $"{levelName}:{compPart}";
            }
            else if (groupPart != null)
            {
                // Chỉ có group, không có compartments => trong ví dụ OLS,
                // chỉ có trường hợp "SINHVIEN::COSO1,COSO2" (có dấu 2 dấu ":" liền nhau).
                // Vậy ta cần để chính xác 2 dấu ":". 
                // format: "<levelName>::<groupPart>"
                labelStr = $"{levelName}::{groupPart}";
            }
            else
            {
                // Không có cả comp và group => chỉ levelName (vd "TRGDV", "NHANVIEN", "SINHVIEN")
                labelStr = levelName;
            }

            // 5. Tạo dictionary (map) từ labelStr -> số tag tương ứng, dựa vào olsSetUp.sql
            var labelMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                // === Level 3 (TRGDV) ===
                { "TRGDV",                         100 },
                { "TRGDV:HOA:COSO2",               101 },
                { "TRGDV:LY:COSO2",                102 },
                { "TRGDV:HANHCHINH",               103 },
                { "TRGDV:HOA:COSO1",               104 },
                { "TRGDV:HOA:COSO1,COSO2",         105 },

                // === Level 2 (NHANVIEN) ===
                { "NHANVIEN",                      110 },
                { "NHANVIEN:HOA:COSO2",            111 },
                { "NHANVIEN:HANHCHINH:COSO1",      112 },

                // === Level 1 (SINHVIEN) ===
                { "SINHVIEN",                      120 },
                { "SINHVIEN:HOA:COSO2",            121 },
                { "SINHVIEN:HOA:COSO1",            122 },
                { "SINHVIEN:HOA:COSO1,COSO2",      123 },
                { "SINHVIEN::COSO1,COSO2",         124 }
            };

            // 6. Tra cứu trong labelMap
            if (labelMap.TryGetValue(labelStr, out int tagValue))
            {
                return tagValue;
            }

            // Nếu không tìm thấy trong dictionary, có thể:
            //   - Thông báo lỗi (tạm return -1)
            //   - Hoặc mặc định gán 0/120 (tất cả sinh viên)
            // Tại đây, ta return -1 để báo không tìm thấy nhãn phù hợp.
            return -1;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
            this.Close();
        }

        private void clbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần code gì ở đây nếu không có yêu cầu đặc biệt
        }
    }
}
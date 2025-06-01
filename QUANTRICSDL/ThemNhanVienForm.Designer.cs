namespace QUANTRICSDL
{
    partial class ThemNhanVienForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Button btnThem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();

            string[] labels = { "Mã NV", "Họ Tên", "Giới Tính", "Ngày Sinh", "Lương", "Phụ Cấp", "SĐT", "Vai Trò", "Mã Đơn Vị" };
            System.Windows.Forms.TextBox[] textboxes = { txtMaNV, txtHoTen, txtPhai, txtNgaySinh, txtLuong, txtPhuCap, txtSDT, txtVaiTro, txtMaDV };

            for (int i = 0; i < labels.Length; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.Text = labels[i];
                lbl.Location = new System.Drawing.Point(30, 20 + i * 35);
                lbl.Size = new System.Drawing.Size(100, 23);
                this.Controls.Add(lbl);

                textboxes[i] = new System.Windows.Forms.TextBox();
                textboxes[i].Location = new System.Drawing.Point(140, 20 + i * 35);
                textboxes[i].Size = new System.Drawing.Size(200, 23);
                this.Controls.Add(textboxes[i]);
            }

            this.txtMaNV = textboxes[0];
            this.txtHoTen = textboxes[1];
            this.txtPhai = textboxes[2];
            this.txtNgaySinh = textboxes[3];
            this.txtLuong = textboxes[4];
            this.txtPhuCap = textboxes[5];
            this.txtSDT = textboxes[6];
            this.txtVaiTro = textboxes[7];
            this.txtMaDV = textboxes[8];

            this.btnThem.Location = new System.Drawing.Point(140, 350);
            this.btnThem.Size = new System.Drawing.Size(200, 30);
            this.btnThem.Text = "Thêm Nhân Viên";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.Controls.Add(this.btnThem);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Name = "ThemNhanVienForm";
            this.Text = "Thêm Nhân Viên";
            this.ResumeLayout(false);
        }
    }
}

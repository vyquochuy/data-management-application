namespace QUANTRICSDL
{
    partial class EditNhanVienForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Button btnCapNhat;

        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblMaDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.comboBoxMaNV = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();

            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblMaDV = new System.Windows.Forms.Label();

            // Form Settings
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Name = "EditNhanVienForm";
            this.Text = "Chỉnh sửa Nhân Viên";
            //this.Load += new System.EventHandler(this.EditNhanVienForm_Load);

            // Labels
            string[] labelTexts = { "Mã NV:", "Họ Tên:", "Phái:", "Ngày Sinh:", "Lương:", "Phụ Cấp:", "SĐT:", "Vai Trò:", "Mã Đơn Vị:" };
            System.Windows.Forms.Label[] labels = { lblMaNV, lblHoTen, lblPhai, lblNgaySinh, lblLuong, lblPhuCap, lblSDT, lblVaiTro, lblMaDV };
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].AutoSize = true;
                labels[i].Location = new System.Drawing.Point(30, 30 + i * 35);
                labels[i].Size = new System.Drawing.Size(100, 20);
                labels[i].Text = labelTexts[i];
                this.Controls.Add(labels[i]);
            }

            // Controls
            comboBoxMaNV.Location = new System.Drawing.Point(150, 27);
            comboBoxMaNV.Size = new System.Drawing.Size(200, 24);
            comboBoxMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMaNV.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaNV_SelectedIndexChanged);

            txtHoTen.Location = new System.Drawing.Point(150, 62);
            txtHoTen.Size = new System.Drawing.Size(200, 22);

            txtPhai.Location = new System.Drawing.Point(150, 97);
            txtPhai.Size = new System.Drawing.Size(200, 22);

            txtNgaySinh.Location = new System.Drawing.Point(150, 132);
            txtNgaySinh.Size = new System.Drawing.Size(200, 22);

            txtLuong.Location = new System.Drawing.Point(150, 167);
            txtLuong.Size = new System.Drawing.Size(200, 22);

            txtPhuCap.Location = new System.Drawing.Point(150, 202);
            txtPhuCap.Size = new System.Drawing.Size(200, 22);

            txtSDT.Location = new System.Drawing.Point(150, 237);
            txtSDT.Size = new System.Drawing.Size(200, 22);

            txtVaiTro.Location = new System.Drawing.Point(150, 272);
            txtVaiTro.Size = new System.Drawing.Size(200, 22);

            txtMaDV.Location = new System.Drawing.Point(150, 307);
            txtMaDV.Size = new System.Drawing.Size(200, 22);

            // Button
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Location = new System.Drawing.Point(150, 350);
            btnCapNhat.Size = new System.Drawing.Size(100, 30);
            btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // Add controls to Form
            this.Controls.Add(comboBoxMaNV);
            this.Controls.Add(txtHoTen);
            this.Controls.Add(txtPhai);
            this.Controls.Add(txtNgaySinh);
            this.Controls.Add(txtLuong);
            this.Controls.Add(txtPhuCap);
            this.Controls.Add(txtSDT);
            this.Controls.Add(txtVaiTro);
            this.Controls.Add(txtMaDV);
            this.Controls.Add(btnCapNhat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

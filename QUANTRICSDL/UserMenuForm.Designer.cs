namespace QUANTRICSDL
{
    partial class UserMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Button btnGuiThongBao;
        private Button btnXemThongBao;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenNhanVien = new Button();
            btnMoMon = new Button();
            btnGuiThongBao = new Button();
            btnXemThongBao = new Button();
            btnSinhVien = new Button();
            btnDangKy = new Button();
            SuspendLayout();
            // 
            // btnOpenNhanVien
            // 
            btnOpenNhanVien.Location = new Point(199, 34);
            btnOpenNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnOpenNhanVien.Name = "btnOpenNhanVien";
            btnOpenNhanVien.Size = new Size(280, 44);
            btnOpenNhanVien.TabIndex = 0;
            btnOpenNhanVien.Text = "Nhân viên";
            btnOpenNhanVien.UseVisualStyleBackColor = true;
            btnOpenNhanVien.Click += button1_Click;
            // 
            // btnMoMon
            // 
            btnMoMon.Location = new Point(199, 96);
            btnMoMon.Margin = new Padding(3, 2, 3, 2);
            btnMoMon.Name = "btnMoMon";
            btnMoMon.Size = new Size(280, 44);
            btnMoMon.TabIndex = 1;
            btnMoMon.Text = "Mở môn";
            btnMoMon.UseVisualStyleBackColor = true;
            btnMoMon.Click += button1_Click_1;
            // 
            // btnGuiThongBao
            // 
            btnGuiThongBao.Location = new Point(199, 289);
            btnGuiThongBao.Margin = new Padding(3, 2, 3, 2);
            btnGuiThongBao.Name = "btnGuiThongBao";
            btnGuiThongBao.Size = new Size(280, 44);
            btnGuiThongBao.TabIndex = 2;
            btnGuiThongBao.Text = "Gửi thông báo";
            btnGuiThongBao.UseWaitCursor = true;
            btnGuiThongBao.Click += btnGuiThongBao_Click;
            // 
            // btnXemThongBao
            // 
            btnXemThongBao.Location = new Point(199, 355);
            btnXemThongBao.Margin = new Padding(3, 2, 3, 2);
            btnXemThongBao.Name = "btnXemThongBao";
            btnXemThongBao.Size = new Size(280, 44);
            btnXemThongBao.TabIndex = 3;
            btnXemThongBao.Text = "Xem thông báo";
            btnXemThongBao.UseWaitCursor = true;
            btnXemThongBao.Click += btnXemThongBao_Click;
            // 
            // btnSinhVien
            // 
            btnSinhVien.Location = new Point(199, 160);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(280, 45);
            btnSinhVien.TabIndex = 4;
            btnSinhVien.Text = "Sinh Viên";
            btnSinhVien.UseVisualStyleBackColor = true;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(199, 223);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(280, 44);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click_1;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 431);
            Controls.Add(btnDangKy);
            Controls.Add(btnSinhVien);
            Controls.Add(btnGuiThongBao);
            Controls.Add(btnXemThongBao);
            Controls.Add(btnMoMon);
            Controls.Add(btnOpenNhanVien);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserMenuForm";
            Text = "UserMenuForm";
            Load += UserMenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenNhanVien;
        private Button btnMoMon;
        private Button btnSinhVien;
        private Button btnDangKy;
    }
}
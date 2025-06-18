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
            SuspendLayout();
            // 
            // btnOpenNhanVien
            // 
            btnOpenNhanVien.Location = new Point(369, 72);
            btnOpenNhanVien.Margin = new Padding(5);
            btnOpenNhanVien.Name = "btnOpenNhanVien";
            btnOpenNhanVien.Size = new Size(520, 93);
            btnOpenNhanVien.TabIndex = 0;
            btnOpenNhanVien.Text = "Nhân viên";
            btnOpenNhanVien.UseVisualStyleBackColor = true;
            btnOpenNhanVien.Click += button1_Click;
            // 
            // btnMoMon
            // 
            btnMoMon.Location = new Point(369, 205);
            btnMoMon.Margin = new Padding(5);
            btnMoMon.Name = "btnMoMon";
            btnMoMon.Size = new Size(520, 94);
            btnMoMon.TabIndex = 1;
            btnMoMon.Text = "Mở môn";
            btnMoMon.UseVisualStyleBackColor = true;
            btnMoMon.Click += button1_Click_1;
            // 
            // btnGuiThongBao
            // 
            btnGuiThongBao.Location = new Point(369, 362);
            btnGuiThongBao.Margin = new Padding(5);
            btnGuiThongBao.Name = "btnGuiThongBao";
            btnGuiThongBao.Size = new Size(520, 94);
            btnGuiThongBao.TabIndex = 2;
            btnGuiThongBao.Text = "Gửi thông báo";
            btnGuiThongBao.UseWaitCursor = true;
            btnGuiThongBao.Click += btnGuiThongBao_Click;
            // 
            // btnXemThongBao
            // 
            btnXemThongBao.Location = new Point(369, 526);
            btnXemThongBao.Margin = new Padding(5);
            btnXemThongBao.Name = "btnXemThongBao";
            btnXemThongBao.Size = new Size(520, 94);
            btnXemThongBao.TabIndex = 3;
            btnXemThongBao.Text = "Xem thông báo";
            btnXemThongBao.UseWaitCursor = true;
            btnXemThongBao.Click += btnXemThongBao_Click;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 714);
            Controls.Add(btnMoMon);
            Controls.Add(btnOpenNhanVien);
            Controls.Add(btnGuiThongBao);
            Controls.Add(btnXemThongBao);
            Margin = new Padding(5);
            Name = "UserMenuForm";
            Text = "UserMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenNhanVien;
        private Button btnMoMon;
    }
}
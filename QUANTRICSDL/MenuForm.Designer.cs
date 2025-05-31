namespace QUANTRICSDL
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private Button btnQuanLyUserRole;
        private Button btnXemDanhSach;
        private Button btnXemThongTinQuyen;
        private Button btnGuiThongBao;
        private Button btnXemThongBao;

        private void InitializeComponent()
        {
            btnQuanLyUserRole = new Button();
            btnXemDanhSach = new Button();
            btnXemThongTinQuyen = new Button();
            button1 = new Button();
            btnGuiThongBao = new Button();
            btnXemThongBao = new Button();
            SuspendLayout();
            // 
            // btnQuanLyUserRole
            // 
            btnQuanLyUserRole.Location = new Point(401, 113);
            btnQuanLyUserRole.Margin = new Padding(6, 4, 6, 4);
            btnQuanLyUserRole.Name = "btnQuanLyUserRole";
            btnQuanLyUserRole.Size = new Size(487, 81);
            btnQuanLyUserRole.TabIndex = 0;
            btnQuanLyUserRole.Text = "1. Quản lý User / Role";
            btnQuanLyUserRole.UseWaitCursor = true;
            btnQuanLyUserRole.Click += btnQuanLyUserRole_Click;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Location = new Point(401, 231);
            btnXemDanhSach.Margin = new Padding(6, 4, 6, 4);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(487, 81);
            btnXemDanhSach.TabIndex = 1;
            btnXemDanhSach.Text = "2. Xem danh sách User / Role";
            btnXemDanhSach.UseWaitCursor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnXemThongTinQuyen
            // 
            btnXemThongTinQuyen.Location = new Point(401, 353);
            btnXemThongTinQuyen.Margin = new Padding(6, 4, 6, 4);
            btnXemThongTinQuyen.Name = "btnXemThongTinQuyen";
            btnXemThongTinQuyen.Size = new Size(487, 81);
            btnXemThongTinQuyen.TabIndex = 4;
            btnXemThongTinQuyen.Text = "3. Xem quyền theo bảng";
            btnXemThongTinQuyen.UseWaitCursor = true;
            btnXemThongTinQuyen.Click += btnXemThongTinQuyen_Click;
            // 
            // bRevoke
            // 
            button1.Location = new Point(401, 734);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(487, 81);
            button1.TabIndex = 5;
            button1.Text = "4. Xem chi tiết người dùng/vai trò";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += btnUserRoleDetail;
            // 
            // btnGuiThongBao
            // 
            btnGuiThongBao.Location = new Point(401, 478);
            btnGuiThongBao.Margin = new Padding(6);
            btnGuiThongBao.Name = "btnGuiThongBao";
            btnGuiThongBao.Size = new Size(487, 85);
            btnGuiThongBao.TabIndex = 0;
            btnGuiThongBao.Text = "Gửi thông báo";
            btnGuiThongBao.UseWaitCursor = true;
            btnGuiThongBao.Click += btnGuiThongBao_Click;
            // 
            // btnXemThongBao
            // 
            btnXemThongBao.Location = new Point(401, 608);
            btnXemThongBao.Margin = new Padding(6, 4, 6, 4);
            btnXemThongBao.Name = "btnXemThongBao";
            btnXemThongBao.Size = new Size(487, 81);
            btnXemThongBao.TabIndex = 0;
            btnXemThongBao.Text = "Xem thông báo";
            btnXemThongBao.UseWaitCursor = true;
            btnXemThongBao.Click += btnXemThongBao_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 845);
            Controls.Add(btnGuiThongBao);
            Controls.Add(btnXemThongBao);
            Controls.Add(button1);
            Controls.Add(btnQuanLyUserRole);
            Controls.Add(btnXemDanhSach);
            Controls.Add(btnXemThongTinQuyen);
            Margin = new Padding(6, 4, 6, 4);
            Name = "MenuForm";
            Text = "QUẢN TRỊ ORACLE";
            UseWaitCursor = true;
            ResumeLayout(false);
        }


        #endregion

        private Button button1;
    }
}

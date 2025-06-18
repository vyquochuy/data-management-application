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
        private Button button1;
        private Button bAuditLog;

        private void InitializeComponent()
        {
            btnQuanLyUserRole = new Button();
            btnXemDanhSach = new Button();
            btnXemThongTinQuyen = new Button();
            button1 = new Button();
            bAuditLog = new Button();
            btnGuiThongBao = new Button();
            btnXemThongBao = new Button();
            SuspendLayout();
            // 
            // btnQuanLyUserRole
            // 
            btnQuanLyUserRole.Location = new Point(395, 59);
            btnQuanLyUserRole.Margin = new Padding(5);
            btnQuanLyUserRole.Name = "btnQuanLyUserRole";
            btnQuanLyUserRole.Size = new Size(486, 82);
            btnQuanLyUserRole.TabIndex = 0;
            btnQuanLyUserRole.Text = "1. Quản lý User / Role";
            btnQuanLyUserRole.UseWaitCursor = true;
            btnQuanLyUserRole.Click += btnQuanLyUserRole_Click;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Location = new Point(395, 221);
            btnXemDanhSach.Margin = new Padding(5);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(486, 82);
            btnXemDanhSach.TabIndex = 1;
            btnXemDanhSach.Text = "2. Xem danh sách User / Role";
            btnXemDanhSach.UseWaitCursor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnXemThongTinQuyen
            // 
            btnXemThongTinQuyen.Location = new Point(395, 376);
            btnXemThongTinQuyen.Margin = new Padding(5);
            btnXemThongTinQuyen.Name = "btnXemThongTinQuyen";
            btnXemThongTinQuyen.Size = new Size(486, 82);
            btnXemThongTinQuyen.TabIndex = 4;
            btnXemThongTinQuyen.Text = "3. Xem quyền theo bảng";
            btnXemThongTinQuyen.UseWaitCursor = true;
            btnXemThongTinQuyen.Click += btnXemThongTinQuyen_Click;
            // 
            // btnSinhVien
            // 
            button1.Location = new Point(395, 533);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(486, 82);
            button1.TabIndex = 5;
            button1.Text = "4. Xem chi tiết người dùng/vai trò";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += btnUserRoleDetail;
            // 
            // bAuditLog
            // 
            bAuditLog.Location = new Point(395, 670);
            bAuditLog.Margin = new Padding(5, 6, 5, 6);
            bAuditLog.Name = "bAuditLog";
            bAuditLog.Size = new Size(486, 82);
            bAuditLog.TabIndex = 6;
            bAuditLog.Text = "5. Xem nhật ký hoạt động người dùng ";
            bAuditLog.UseVisualStyleBackColor = true;
            bAuditLog.UseWaitCursor = true;
            bAuditLog.Click += bAuditLog_Click;
            // 
            // btnGuiThongBao
            // 
            btnGuiThongBao.Location = new Point(395, 809);
            btnGuiThongBao.Name = "btnGuiThongBao";
            btnGuiThongBao.Size = new Size(486, 82);
            btnGuiThongBao.TabIndex = 7;
            btnGuiThongBao.Text = "6. Gửi thông báo";
            btnGuiThongBao.UseWaitCursor = true;
            btnGuiThongBao.Click += btnGuiThongBao_Click;
            // 
            // btnXemThongBao
            // 
            btnXemThongBao.Location = new Point(395, 941);
            btnXemThongBao.Name = "btnXemThongBao";
            btnXemThongBao.Size = new Size(486, 82);
            btnXemThongBao.TabIndex = 8;
            btnXemThongBao.Text = "7. Xem thông báo";
            btnXemThongBao.UseWaitCursor = true;
            btnXemThongBao.Click += btnXemThongBao_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 1058);
            Controls.Add(bAuditLog);
            Controls.Add(button1);
            Controls.Add(btnQuanLyUserRole);
            Controls.Add(btnXemDanhSach);
            Controls.Add(btnXemThongTinQuyen);
            Controls.Add(btnGuiThongBao);
            Controls.Add(btnXemThongBao);
            Margin = new Padding(5);
            Name = "MenuForm";
            Text = "QUẢN TRỊ ORACLE";
            UseWaitCursor = true;
            ResumeLayout(false);
        }


        #endregion

    }
}

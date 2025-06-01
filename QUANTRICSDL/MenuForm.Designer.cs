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

        private void InitializeComponent()
        {
            btnQuanLyUserRole = new Button();
            btnXemDanhSach = new Button();
            btnXemThongTinQuyen = new Button();
            button1 = new Button();
            bAuditLog = new Button();
            SuspendLayout();
            // 
            // btnQuanLyUserRole
            // 
            btnQuanLyUserRole.Location = new Point(243, 37);
            btnQuanLyUserRole.Name = "btnQuanLyUserRole";
            btnQuanLyUserRole.Size = new Size(299, 51);
            btnQuanLyUserRole.TabIndex = 0;
            btnQuanLyUserRole.Text = "1. Quản lý User / Role";
            btnQuanLyUserRole.UseWaitCursor = true;
            btnQuanLyUserRole.Click += btnQuanLyUserRole_Click;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Location = new Point(243, 138);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(299, 51);
            btnXemDanhSach.TabIndex = 1;
            btnXemDanhSach.Text = "2. Xem danh sách User / Role";
            btnXemDanhSach.UseWaitCursor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnXemThongTinQuyen
            // 
            btnXemThongTinQuyen.Location = new Point(243, 235);
            btnXemThongTinQuyen.Name = "btnXemThongTinQuyen";
            btnXemThongTinQuyen.Size = new Size(299, 51);
            btnXemThongTinQuyen.TabIndex = 4;
            btnXemThongTinQuyen.Text = "3. Xem quyền theo đối tượng";
            btnXemThongTinQuyen.UseWaitCursor = true;
            btnXemThongTinQuyen.Click += btnXemThongTinQuyen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(243, 333);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(299, 51);
            button1.TabIndex = 5;
            button1.Text = "4. Xem chi tiết người dùng/vai trò";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += btnUserRoleDetail;
            // 
            // bAuditLog
            // 
            bAuditLog.Location = new Point(243, 419);
            bAuditLog.Margin = new Padding(3, 4, 3, 4);
            bAuditLog.Name = "bAuditLog";
            bAuditLog.Size = new Size(299, 51);
            bAuditLog.TabIndex = 6;
            bAuditLog.Text = "5. Xem nhật ký hoạt động người dùng ";
            bAuditLog.UseVisualStyleBackColor = true;
            bAuditLog.UseWaitCursor = true;
            bAuditLog.Click += bAuditLog_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 517);
            Controls.Add(bAuditLog);
            Controls.Add(button1);
            Controls.Add(btnQuanLyUserRole);
            Controls.Add(btnXemDanhSach);
            Controls.Add(btnXemThongTinQuyen);
            Name = "MenuForm";
            Text = "QUẢN TRỊ ORACLE";
            UseWaitCursor = true;
            ResumeLayout(false);
        }


        #endregion

        private Button button1;
        private Button bAuditLog;
    }
}

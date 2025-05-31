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
            SuspendLayout();
            // 
            // btnQuanLyUserRole
            // 
            btnQuanLyUserRole.Location = new Point(216, 53);
            btnQuanLyUserRole.Margin = new Padding(3, 2, 3, 2);
            btnQuanLyUserRole.Name = "btnQuanLyUserRole";
            btnQuanLyUserRole.Size = new Size(262, 38);
            btnQuanLyUserRole.TabIndex = 0;
            btnQuanLyUserRole.Text = "1. Quản lý User / Role";
            btnQuanLyUserRole.UseWaitCursor = true;
            btnQuanLyUserRole.Click += btnQuanLyUserRole_Click;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Location = new Point(216, 129);
            btnXemDanhSach.Margin = new Padding(3, 2, 3, 2);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(262, 38);
            btnXemDanhSach.TabIndex = 1;
            btnXemDanhSach.Text = "2. Xem danh sách User / Role";
            btnXemDanhSach.UseWaitCursor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnXemThongTinQuyen
            // 
            btnXemThongTinQuyen.Location = new Point(216, 202);
            btnXemThongTinQuyen.Margin = new Padding(3, 2, 3, 2);
            btnXemThongTinQuyen.Name = "btnXemThongTinQuyen";
            btnXemThongTinQuyen.Size = new Size(262, 38);
            btnXemThongTinQuyen.TabIndex = 4;
            btnXemThongTinQuyen.Text = "3. Xem quyền theo bảng";
            btnXemThongTinQuyen.UseWaitCursor = true;
            btnXemThongTinQuyen.Click += btnXemThongTinQuyen_Click;
            // 
            // bRevoke
            // 
            button1.Location = new Point(216, 275);
            button1.Name = "btnUserRoleDetail";
            button1.Size = new Size(262, 38);
            button1.TabIndex = 5;
            button1.Text = "4. Xem chi tiết người dùng/vai trò";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUserRoleDetail;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 388);
            Controls.Add(button1);
            Controls.Add(btnQuanLyUserRole);
            Controls.Add(btnXemDanhSach);
            Controls.Add(btnXemThongTinQuyen);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "QUẢN TRỊ ORACLE";
            UseWaitCursor = true;
            ResumeLayout(false);
        }


        #endregion

        private Button button1;
    }
}

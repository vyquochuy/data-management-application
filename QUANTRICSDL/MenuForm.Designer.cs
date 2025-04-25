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
            SuspendLayout();
            // 
            // btnQuanLyUserRole
            // 
            btnQuanLyUserRole.Location = new Point(254, 102);
            btnQuanLyUserRole.Name = "btnQuanLyUserRole";
            btnQuanLyUserRole.Size = new Size(300, 50);
            btnQuanLyUserRole.TabIndex = 0;
            btnQuanLyUserRole.Text = "1. Quản lý User / Role";
            btnQuanLyUserRole.UseWaitCursor = true;
            btnQuanLyUserRole.Click += btnQuanLyUserRole_Click;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Location = new Point(254, 203);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(300, 50);
            btnXemDanhSach.TabIndex = 1;
            btnXemDanhSach.Text = "2. Xem danh sách User / Role";
            btnXemDanhSach.UseWaitCursor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnXemThongTinQuyen
            // 
            btnXemThongTinQuyen.Location = new Point(254, 300);
            btnXemThongTinQuyen.Name = "btnXemThongTinQuyen";
            btnXemThongTinQuyen.Size = new Size(300, 50);
            btnXemThongTinQuyen.TabIndex = 4;
            btnXemThongTinQuyen.Text = "3. Xem quyền theo đối tượng";
            btnXemThongTinQuyen.UseWaitCursor = true;
            btnXemThongTinQuyen.Click += btnXemThongTinQuyen_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 420);
            Controls.Add(btnQuanLyUserRole);
            Controls.Add(btnXemDanhSach);
            Controls.Add(btnXemThongTinQuyen);
            Name = "MenuForm";
            Text = "QUẢN TRỊ ORACLE";
            UseWaitCursor = true;
            ResumeLayout(false);
        }


        #endregion
    }
}

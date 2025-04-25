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
        private Button btnCapQuyen;
        private Button btnThuHoiQuyen;
        private Button btnXemThongTinQuyen;

        private void InitializeComponent()
        {
            btnQuanLyUserRole = new Button();
            btnXemDanhSach = new Button();
            btnCapQuyen = new Button();
            btnThuHoiQuyen = new Button();
            btnXemThongTinQuyen = new Button();
            SuspendLayout();
            // 
            // btnQuanLyUserRole
            // 
            btnQuanLyUserRole.Location = new Point(254, 41);
            btnQuanLyUserRole.Name = "btnQuanLyUserRole";
            btnQuanLyUserRole.Size = new Size(300, 50);
            btnQuanLyUserRole.TabIndex = 0;
            btnQuanLyUserRole.Text = "1. Quản lý User / Role";
            btnQuanLyUserRole.UseWaitCursor = true;
            btnQuanLyUserRole.Click += btnQuanLyUserRole_Click;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Location = new Point(254, 109);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(300, 50);
            btnXemDanhSach.TabIndex = 1;
            btnXemDanhSach.Text = "2. Xem danh sách User / Role";
            btnXemDanhSach.UseWaitCursor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnCapQuyen
            // 
            btnCapQuyen.Location = new Point(254, 179);
            btnCapQuyen.Name = "btnCapQuyen";
            btnCapQuyen.Size = new Size(300, 50);
            btnCapQuyen.TabIndex = 2;
            btnCapQuyen.Text = "3. Cấp quyền";
            btnCapQuyen.UseWaitCursor = true;
            btnCapQuyen.Click += btnCapQuyen_Click;
            // 
            // btnThuHoiQuyen
            // 
            btnThuHoiQuyen.Location = new Point(254, 249);
            btnThuHoiQuyen.Name = "btnThuHoiQuyen";
            btnThuHoiQuyen.Size = new Size(300, 50);
            btnThuHoiQuyen.TabIndex = 3;
            btnThuHoiQuyen.Text = "4. Thu hồi quyền";
            btnThuHoiQuyen.UseWaitCursor = true;
            btnThuHoiQuyen.Click += btnThuHoiQuyen_Click;
            // 
            // btnXemThongTinQuyen
            // 
            btnXemThongTinQuyen.Location = new Point(254, 322);
            btnXemThongTinQuyen.Name = "btnXemThongTinQuyen";
            btnXemThongTinQuyen.Size = new Size(300, 50);
            btnXemThongTinQuyen.TabIndex = 4;
            btnXemThongTinQuyen.Text = "5. Xem quyền theo đối tượng";
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
            Controls.Add(btnCapQuyen);
            Controls.Add(btnThuHoiQuyen);
            Controls.Add(btnXemThongTinQuyen);
            Name = "MenuForm";
            Text = "QUẢN TRỊ ORACLE";
            UseWaitCursor = true;
            ResumeLayout(false);
        }


        #endregion
    }
}

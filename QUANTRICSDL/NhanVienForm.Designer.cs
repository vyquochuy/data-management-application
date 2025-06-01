namespace QUANTRICSDL
{
    partial class NhanVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listViewNhanVien;
        private System.Windows.Forms.ColumnHeader columnMaNV;
        private System.Windows.Forms.ColumnHeader columnHoTen;
        private System.Windows.Forms.ColumnHeader columnPhai;
        private System.Windows.Forms.ColumnHeader columnNgaySinh;
        private System.Windows.Forms.ColumnHeader columnLuong;
        private System.Windows.Forms.ColumnHeader columnPhuCap;
        private System.Windows.Forms.ColumnHeader columnDT;
        private System.Windows.Forms.ColumnHeader columnVaiTro;
        private System.Windows.Forms.ColumnHeader columnMaDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnBack = new Button();
            btnAdd = new Button();
            listViewNhanVien = new ListView();
            columnMaNV = new ColumnHeader();
            columnHoTen = new ColumnHeader();
            columnPhai = new ColumnHeader();
            columnNgaySinh = new ColumnHeader();
            columnLuong = new ColumnHeader();
            columnPhuCap = new ColumnHeader();
            columnDT = new ColumnHeader();
            columnVaiTro = new ColumnHeader();
            columnMaDV = new ColumnHeader();
            bChangeMyPhone = new Button();
            bEdit = new Button();
            bDelete = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 15);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(765, 15);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listViewNhanVien
            // 
            listViewNhanVien.Columns.AddRange(new ColumnHeader[] { columnMaNV, columnHoTen, columnPhai, columnNgaySinh, columnLuong, columnPhuCap, columnDT, columnVaiTro, columnMaDV });
            listViewNhanVien.FullRowSelect = true;
            listViewNhanVien.GridLines = true;
            listViewNhanVien.Location = new Point(12, 62);
            listViewNhanVien.Margin = new Padding(3, 4, 3, 4);
            listViewNhanVien.MultiSelect = false;
            listViewNhanVien.Name = "listViewNhanVien";
            listViewNhanVien.Size = new Size(828, 484);
            listViewNhanVien.TabIndex = 2;
            listViewNhanVien.UseCompatibleStateImageBehavior = false;
            listViewNhanVien.View = View.Details;
            listViewNhanVien.MouseClick += listViewNhanVien_MouseClick;
            // 
            // columnMaNV
            // 
            columnMaNV.Text = "Mã NV";
            columnMaNV.Width = 80;
            // 
            // columnHoTen
            // 
            columnHoTen.Text = "Họ tên";
            columnHoTen.Width = 150;
            // 
            // columnPhai
            // 
            columnPhai.Text = "Phái";
            columnPhai.Width = 50;
            // 
            // columnNgaySinh
            // 
            columnNgaySinh.Text = "Ngày sinh";
            columnNgaySinh.Width = 100;
            // 
            // columnLuong
            // 
            columnLuong.Text = "Lương";
            columnLuong.Width = 80;
            // 
            // columnPhuCap
            // 
            columnPhuCap.Text = "Phụ cấp";
            columnPhuCap.Width = 80;
            // 
            // columnDT
            // 
            columnDT.Text = "Điện thoại";
            columnDT.Width = 100;
            // 
            // columnVaiTro
            // 
            columnVaiTro.Text = "Vai trò";
            columnVaiTro.Width = 100;
            // 
            // columnMaDV
            // 
            columnMaDV.Text = "Mã ĐV";
            columnMaDV.Width = 80;
            // 
            // bChangeMyPhone
            // 
            bChangeMyPhone.Location = new Point(665, 15);
            bChangeMyPhone.Name = "bChangeMyPhone";
            bChangeMyPhone.Size = new Size(94, 29);
            bChangeMyPhone.TabIndex = 3;
            bChangeMyPhone.Text = "Đổi SDT";
            bChangeMyPhone.UseVisualStyleBackColor = true;
            bChangeMyPhone.Click += bChangeMyPhoneClick;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(565, 15);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(94, 29);
            bEdit.TabIndex = 4;
            bEdit.Text = "Chỉnh sửa";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += editClick;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(465, 15);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(94, 29);
            bDelete.TabIndex = 5;
            bDelete.Text = "Xóa";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += deleteClick;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 562);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bChangeMyPhone);
            Controls.Add(listViewNhanVien);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhanVien";
            Text = "Quản lý nhân viên";
            ResumeLayout(false);
        }
        private Button bChangeMyPhone;
        private Button bEdit;
        private Button bDelete;
    }
}

namespace QUANTRICSDL
{
    partial class NhanVienForm
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
            btnBack.Location = new Point(10, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(66, 22);
            btnBack.TabIndex = 0;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(669, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 22);
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
            listViewNhanVien.Location = new Point(10, 46);
            listViewNhanVien.MultiSelect = false;
            listViewNhanVien.Name = "listViewNhanVien";
            listViewNhanVien.Size = new Size(725, 364);
            listViewNhanVien.TabIndex = 2;
            listViewNhanVien.UseCompatibleStateImageBehavior = false;
            listViewNhanVien.View = View.Details;
            listViewNhanVien.SelectedIndexChanged += listViewNhanVien_SelectedIndexChanged;
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
            bChangeMyPhone.Location = new Point(582, 11);
            bChangeMyPhone.Margin = new Padding(3, 2, 3, 2);
            bChangeMyPhone.Name = "bChangeMyPhone";
            bChangeMyPhone.Size = new Size(82, 22);
            bChangeMyPhone.TabIndex = 3;
            bChangeMyPhone.Text = "Đổi SDT";
            bChangeMyPhone.UseVisualStyleBackColor = true;
            bChangeMyPhone.Click += bChangeMyPhoneClick;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(494, 11);
            bEdit.Margin = new Padding(3, 2, 3, 2);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(82, 22);
            bEdit.TabIndex = 4;
            bEdit.Text = "Chỉnh sửa";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += editClick;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(407, 11);
            bDelete.Margin = new Padding(3, 2, 3, 2);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(82, 22);
            bDelete.TabIndex = 5;
            bDelete.Text = "Xóa";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += deleteClick;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 422);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bChangeMyPhone);
            Controls.Add(listViewNhanVien);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Name = "NhanVienForm";
            Text = "Quản lý nhân viên";
            ResumeLayout(false);
        }
        private Button bChangeMyPhone;
        private Button bEdit;
        private Button bDelete;
    }
}

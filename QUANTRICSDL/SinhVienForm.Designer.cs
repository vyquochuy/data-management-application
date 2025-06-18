namespace QUANTRICSDL
{
    partial class SinhVienForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewSinhVien = new ListView();
            columnMASV = new ColumnHeader();
            columnHoTen = new ColumnHeader();
            columnPhai = new ColumnHeader();
            columnNgaySinh = new ColumnHeader();
            columnDiaChi = new ColumnHeader();
            columnDT = new ColumnHeader();
            columnKhoa = new ColumnHeader();
            columnTinhTrang = new ColumnHeader();
            btnBack = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listViewSinhVien
            // 
            listViewSinhVien.Columns.AddRange(new ColumnHeader[] { columnMASV, columnHoTen, columnPhai, columnNgaySinh, columnDiaChi, columnDT, columnKhoa, columnTinhTrang });
            listViewSinhVien.FullRowSelect = true;
            listViewSinhVien.GridLines = true;
            listViewSinhVien.Location = new Point(10, 46);
            listViewSinhVien.MultiSelect = false;
            listViewSinhVien.Name = "listViewSinhVien";
            listViewSinhVien.Size = new Size(819, 364);
            listViewSinhVien.TabIndex = 2;
            listViewSinhVien.UseCompatibleStateImageBehavior = false;
            listViewSinhVien.View = View.Details;
            listViewSinhVien.SelectedIndexChanged += listViewSinhVien_SelectedIndexChanged;
            listViewSinhVien.MouseClick += listViewSinhVien_MouseClick;
            // 
            // columnMASV
            // 
            columnMASV.Text = "Mã SV";
            columnMASV.Width = 80;
            // 
            // columnHoTen
            // 
            columnHoTen.Text = "Họ Tên";
            columnHoTen.Width = 150;
            // 
            // columnPhai
            // 
            columnPhai.Text = "Phái";
            // 
            // columnNgaySinh
            // 
            columnNgaySinh.Text = "Ngày Sinh";
            columnNgaySinh.Width = 100;
            // 
            // columnDiaChi
            // 
            columnDiaChi.Text = "Địa Chỉ";
            columnDiaChi.Width = 150;
            // 
            // columnDT
            // 
            columnDT.Text = "Điện Thoại";
            columnDT.Width = 100;
            // 
            // columnKhoa
            // 
            columnKhoa.Text = "Khoa";
            columnKhoa.Width = 80;
            // 
            // columnTinhTrang
            // 
            columnTinhTrang.Text = "Tình Trạng";
            columnTinhTrang.Width = 100;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(754, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(673, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = " Cập nhật";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(592, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // SinhVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 420);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(listViewSinhVien);
            Name = "SinhVienForm";
            Text = "SinhVienForm";
            ResumeLayout(false);
        }


        #endregion

        private ListView listViewSinhVien;
        private ColumnHeader columnMASV;
        private ColumnHeader columnHoTen;
        private ColumnHeader columnPhai;
        private ColumnHeader columnNgaySinh;
        private ColumnHeader columnDiaChi;
        private ColumnHeader columnDT;
        private ColumnHeader columnKhoa;
        private ColumnHeader columnTinhTrang;
        private Button btnBack;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
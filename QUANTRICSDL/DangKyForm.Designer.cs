namespace QUANTRICSDL
{
    partial class DangKyForm
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
            listViewDangKy = new ListView();
            btnBack = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listViewDangKy
            // 
            listViewDangKy.FullRowSelect = true;
            listViewDangKy.GridLines = true;
            listViewDangKy.Location = new Point(14, 60);
            listViewDangKy.Margin = new Padding(3, 4, 3, 4);
            listViewDangKy.MultiSelect = false;
            listViewDangKy.Name = "listViewDangKy";
            listViewDangKy.Size = new Size(886, 364);
            listViewDangKy.TabIndex = 0;
            listViewDangKy.UseCompatibleStateImageBehavior = false;
            listViewDangKy.View = View.Details;
            listViewDangKy.SelectedIndexChanged += listViewDangKy_SelectedIndexChanged;

            columnMaSV.Text = "Mã SV";
            columnMaSV.Width = 100;

            columnMaMM.Text = "Mã môn mở";
            columnMaMM.Width = 120;

            columnDiemTH.Text = "Điểm thường";
            columnDiemTH.Width = 100;

            columnDiemQT.Text = "Điểm quá trình";
            columnDiemQT.Width = 120;

            columnDiemCK.Text = "Điểm cuối kỳ";
            columnDiemCK.Width = 100;

            columnDiemTK.Text = "Điểm tổng kết";
            columnDiemTK.Width = 120;

            // Gắn các cột vào ListView
            listViewDangKy.Columns.AddRange(new ColumnHeader[]
            {
    columnMaSV, columnMaMM, columnDiemTH, columnDiemQT, columnDiemCK, columnDiemTK
            });
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(815, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(722, 16);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Cập nhật";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(630, 16);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DangKyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 440);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(listViewDangKy);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangKyForm";
            Text = "DangKyForm";
            Load += DangKyForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDangKy;
        private ColumnHeader columnMaSV = new ColumnHeader();
        private ColumnHeader columnMaMM = new ColumnHeader();
        private ColumnHeader columnDiemTH = new ColumnHeader();
        private ColumnHeader columnDiemQT = new ColumnHeader();
        private ColumnHeader columnDiemCK = new ColumnHeader();
        private ColumnHeader columnDiemTK = new ColumnHeader();

        private Button btnBack;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
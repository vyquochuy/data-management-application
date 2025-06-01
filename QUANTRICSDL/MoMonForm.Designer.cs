namespace QUANTRICSDL
{
    partial class MoMonForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListView lvMoMon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnQuayLai = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lvMoMon = new ListView();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(20, 12);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(80, 30);
            btnQuayLai.TabIndex = 1;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(490, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(318, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(404, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // lvMoMon
            // 
            lvMoMon.FullRowSelect = true;
            lvMoMon.GridLines = true;
            lvMoMon.Location = new Point(20, 74);
            lvMoMon.Name = "lvMoMon";
            lvMoMon.Size = new Size(550, 250);
            lvMoMon.TabIndex = 0;
            lvMoMon.UseCompatibleStateImageBehavior = false;
            lvMoMon.View = View.Details;
            lvMoMon.SelectedIndexChanged += lvMoMon_SelectedIndexChanged;

            // Thêm cột
            lvMoMon.Columns.Add("MAMM", 100);
            lvMoMon.Columns.Add("MAHP", 100);
            lvMoMon.Columns.Add("MAGV", 100);
            lvMoMon.Columns.Add("HK", 50);
            lvMoMon.Columns.Add("NAM", 80);

            // 
            // MoMonForm
            // 
            ClientSize = new Size(600, 350);
            Controls.Add(lvMoMon);
            Controls.Add(btnQuayLai);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "MoMonForm";
            Text = "Quản lý Mở Môn";
            ResumeLayout(false);
        }
    }
}
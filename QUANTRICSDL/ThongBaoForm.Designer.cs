namespace QUANTRICSDL
{
    partial class ThongBaoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblCapBac;
        private System.Windows.Forms.ComboBox cbCapBac;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.CheckedListBox clbDonVi;
        private System.Windows.Forms.Label lblCoSo;
        private System.Windows.Forms.CheckedListBox clbCoSo;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnQuayLai;

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
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            lblCapBac = new Label();
            cbCapBac = new ComboBox();
            lblDonVi = new Label();
            clbDonVi = new CheckedListBox();
            lblCoSo = new Label();
            clbCoSo = new CheckedListBox();
            btnGui = new Button();
            btnQuayLai = new Button();
            SuspendLayout();
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(30, 30);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(120, 32);
            lblNoiDung.TabIndex = 0;
            lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(156, 30);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(556, 135);
            txtNoiDung.TabIndex = 1;
            // 
            // lblCapBac
            // 
            lblCapBac.AutoSize = true;
            lblCapBac.Location = new Point(30, 187);
            lblCapBac.Name = "lblCapBac";
            lblCapBac.Size = new Size(104, 32);
            lblCapBac.TabIndex = 2;
            lblCapBac.Text = "Cấp bậc:";
            // 
            // cbCapBac
            // 
            cbCapBac.Items.AddRange(new object[] { "Trưởng đơn vị", "Nhân viên", "Sinh viên" });
            cbCapBac.Location = new Point(156, 187);
            cbCapBac.Name = "cbCapBac";
            cbCapBac.Size = new Size(200, 40);
            cbCapBac.TabIndex = 3;
            // 
            // lblDonVi
            // 
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(405, 190);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(89, 32);
            lblDonVi.TabIndex = 4;
            lblDonVi.Text = "Đơn vị:";
            // 
            // clbDonVi
            // 
            clbDonVi.Items.AddRange(new object[] { "Toán", "Lý", "Hóa", "Hành chính" });
            clbDonVi.Location = new Point(512, 187);
            clbDonVi.Name = "clbDonVi";
            clbDonVi.Size = new Size(200, 148);
            clbDonVi.TabIndex = 5;
            // 
            // lblCoSo
            // 
            lblCoSo.AutoSize = true;
            lblCoSo.Location = new Point(30, 259);
            lblCoSo.Name = "lblCoSo";
            lblCoSo.Size = new Size(79, 32);
            lblCoSo.TabIndex = 6;
            lblCoSo.Text = "Cơ sở:";
            // 
            // clbCoSo
            // 
            clbCoSo.Items.AddRange(new object[] { "Cơ sở 1", "Cơ sở 2" });
            clbCoSo.Location = new Point(156, 259);
            clbCoSo.Name = "clbCoSo";
            clbCoSo.Size = new Size(200, 76);
            clbCoSo.TabIndex = 7;
            clbCoSo.SelectedIndexChanged += clbCoSo_SelectedIndexChanged;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(275, 381);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(199, 57);
            btnGui.TabIndex = 8;
            btnGui.Text = "Gửi thông báo";
            btnGui.Click += btnGui_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(293, 465);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(150, 44);
            btnQuayLai.TabIndex = 9;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // ThongBaoForm
            // 
            ClientSize = new Size(744, 565);
            Controls.Add(lblNoiDung);
            Controls.Add(txtNoiDung);
            Controls.Add(lblCapBac);
            Controls.Add(cbCapBac);
            Controls.Add(lblDonVi);
            Controls.Add(clbDonVi);
            Controls.Add(lblCoSo);
            Controls.Add(clbCoSo);
            Controls.Add(btnGui);
            Controls.Add(btnQuayLai);
            Name = "ThongBaoForm";
            Text = "Soạn Thông Báo";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

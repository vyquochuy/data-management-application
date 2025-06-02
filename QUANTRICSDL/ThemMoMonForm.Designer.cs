// ThemMoMonForm.Designer.cs
namespace QUANTRICSDL
{
    partial class ThemMoMonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMAMM;
        private System.Windows.Forms.Label labelMAHP;
        private System.Windows.Forms.Label labelMAGV;
        private System.Windows.Forms.Label labelHK;
        private System.Windows.Forms.Label labelNAM;

        private System.Windows.Forms.TextBox txtMAMM;
        private System.Windows.Forms.TextBox txtMAHP;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.TextBox txtNAM;

        private System.Windows.Forms.Button btnThem;
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
            this.labelMAMM = new System.Windows.Forms.Label();
            this.labelMAHP = new System.Windows.Forms.Label();
            this.labelMAGV = new System.Windows.Forms.Label();
            this.labelHK = new System.Windows.Forms.Label();
            this.labelNAM = new System.Windows.Forms.Label();

            this.txtMAMM = new System.Windows.Forms.TextBox();
            this.txtMAHP = new System.Windows.Forms.TextBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.txtHK = new System.Windows.Forms.TextBox();
            this.txtNAM = new System.Windows.Forms.TextBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Labels and TextBoxes
            this.labelMAMM.Text = "Mã mở môn";
            this.labelMAHP.Text = "Mã học phần";
            this.labelMAGV.Text = "Mã giảng viên";
            this.labelHK.Text = "Học kỳ";
            this.labelNAM.Text = "Năm";

            this.labelMAMM.Location = new System.Drawing.Point(30, 30);
            this.labelMAHP.Location = new System.Drawing.Point(30, 70);
            this.labelMAGV.Location = new System.Drawing.Point(30, 110);
            this.labelHK.Location = new System.Drawing.Point(30, 150);
            this.labelNAM.Location = new System.Drawing.Point(30, 190);

            this.txtMAMM.Location = new System.Drawing.Point(150, 30);
            this.txtMAHP.Location = new System.Drawing.Point(150, 70);
            this.txtMAGV.Location = new System.Drawing.Point(150, 110);
            this.txtHK.Location = new System.Drawing.Point(150, 150);
            this.txtNAM.Location = new System.Drawing.Point(150, 190);

            this.txtMAMM.Width = this.txtMAHP.Width = this.txtMAGV.Width = this.txtHK.Width = this.txtNAM.Width = 200;

            // Buttons
            this.btnThem.Text = "Thêm";
            this.btnQuayLai.Text = "Quay lại";

            this.btnThem.Location = new System.Drawing.Point(70, 240);
            this.btnQuayLai.Location = new System.Drawing.Point(200, 240);

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelMAMM);
            this.Controls.Add(this.labelMAHP);
            this.Controls.Add(this.labelMAGV);
            this.Controls.Add(this.labelHK);
            this.Controls.Add(this.labelNAM);

            this.Controls.Add(this.txtMAMM);
            this.Controls.Add(this.txtMAHP);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.txtHK);
            this.Controls.Add(this.txtNAM);

            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnQuayLai);

            this.Text = "Thêm Mở Môn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

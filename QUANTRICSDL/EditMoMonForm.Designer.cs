// EditMoMonForm.Designer.cs
namespace QUANTRICSDL
{
    partial class EditMoMonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cbMAMM;
        private System.Windows.Forms.TextBox txtMAHP;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.TextBox txtNAM;
        private System.Windows.Forms.Label lblMAMM;
        private System.Windows.Forms.Label lblMAHP;
        private System.Windows.Forms.Label lblMAGV;
        private System.Windows.Forms.Label lblHK;
        private System.Windows.Forms.Label lblNAM;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnQuayLai = new Button();
            btnCapNhat = new Button();
            cbMAMM = new ComboBox();
            txtMAHP = new TextBox();
            txtMAGV = new TextBox();
            txtHK = new TextBox();
            txtNAM = new TextBox();
            lblMAMM = new Label();
            lblMAHP = new Label();
            lblMAGV = new Label();
            lblHK = new Label();
            lblNAM = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(30, 248);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(98, 34);
            btnQuayLai.TabIndex = 11;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(174, 248);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(107, 34);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // cbMAMM
            // 
            cbMAMM.Location = new Point(100, 27);
            cbMAMM.Name = "cbMAMM";
            cbMAMM.Size = new Size(121, 28);
            cbMAMM.TabIndex = 1;
            cbMAMM.SelectedIndexChanged += cbMAMM_SelectedIndexChanged;
            // 
            // txtMAHP
            // 
            txtMAHP.Location = new Point(100, 67);
            txtMAHP.Name = "txtMAHP";
            txtMAHP.Size = new Size(100, 27);
            txtMAHP.TabIndex = 3;
            // 
            // txtMAGV
            // 
            txtMAGV.Location = new Point(100, 107);
            txtMAGV.Name = "txtMAGV";
            txtMAGV.Size = new Size(100, 27);
            txtMAGV.TabIndex = 5;
            // 
            // txtHK
            // 
            txtHK.Location = new Point(100, 147);
            txtHK.Name = "txtHK";
            txtHK.Size = new Size(100, 27);
            txtHK.TabIndex = 7;
            // 
            // txtNAM
            // 
            txtNAM.Location = new Point(100, 187);
            txtNAM.Name = "txtNAM";
            txtNAM.Size = new Size(100, 27);
            txtNAM.TabIndex = 9;
            // 
            // lblMAMM
            // 
            lblMAMM.Location = new Point(30, 30);
            lblMAMM.Name = "lblMAMM";
            lblMAMM.Size = new Size(100, 23);
            lblMAMM.TabIndex = 0;
            lblMAMM.Text = "Mã MM:";
            // 
            // lblMAHP
            // 
            lblMAHP.Location = new Point(30, 70);
            lblMAHP.Name = "lblMAHP";
            lblMAHP.Size = new Size(100, 23);
            lblMAHP.TabIndex = 2;
            lblMAHP.Text = "Mã HP:";
            // 
            // lblMAGV
            // 
            lblMAGV.Location = new Point(30, 110);
            lblMAGV.Name = "lblMAGV";
            lblMAGV.Size = new Size(100, 23);
            lblMAGV.TabIndex = 4;
            lblMAGV.Text = "Mã GV:";
            // 
            // lblHK
            // 
            lblHK.Location = new Point(30, 150);
            lblHK.Name = "lblHK";
            lblHK.Size = new Size(100, 23);
            lblHK.TabIndex = 6;
            lblHK.Text = "Học kỳ:";
            // 
            // lblNAM
            // 
            lblNAM.Location = new Point(30, 190);
            lblNAM.Name = "lblNAM";
            lblNAM.Size = new Size(100, 23);
            lblNAM.TabIndex = 8;
            lblNAM.Text = "Năm:";
            // 
            // EditMoMonForm
            // 
            ClientSize = new Size(350, 304);
            Controls.Add(lblMAMM);
            Controls.Add(cbMAMM);
            Controls.Add(lblMAHP);
            Controls.Add(txtMAHP);
            Controls.Add(lblMAGV);
            Controls.Add(txtMAGV);
            Controls.Add(lblHK);
            Controls.Add(txtHK);
            Controls.Add(lblNAM);
            Controls.Add(txtNAM);
            Controls.Add(btnCapNhat);
            Controls.Add(btnQuayLai);
            Name = "EditMoMonForm";
            Text = "Sửa Mở Môn";
            ResumeLayout(false);
            PerformLayout();
        }
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}

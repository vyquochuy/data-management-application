// EditMoMonForm.Designer.cs
namespace QUANTRICSDL
{
    partial class EditMoMonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbMAMM;
        private System.Windows.Forms.TextBox txtMAHP;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.TextBox txtNAM;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnQuayLai;

        private void InitializeComponent()
        {
            this.cbMAMM = new System.Windows.Forms.ComboBox();
            this.txtMAHP = new System.Windows.Forms.TextBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.txtHK = new System.Windows.Forms.TextBox();
            this.txtNAM = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.cbMAMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMAMM.Location = new System.Drawing.Point(120, 20);
            this.cbMAMM.Name = "cbMAMM";
            this.cbMAMM.Size = new System.Drawing.Size(200, 22);
            this.cbMAMM.SelectedIndexChanged += new System.EventHandler(this.cbMAMM_SelectedIndexChanged);

            this.txtMAHP.Location = new System.Drawing.Point(120, 60);
            this.txtMAGV.Location = new System.Drawing.Point(120, 100);
            this.txtHK.Location = new System.Drawing.Point(120, 140);
            this.txtNAM.Location = new System.Drawing.Point(120, 180);

            this.txtMAHP.Size = this.txtMAGV.Size = this.txtHK.Size = this.txtNAM.Size = new System.Drawing.Size(200, 22);

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(120, 220);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Location = new System.Drawing.Point(240, 220);
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.cbMAMM);
            this.Controls.Add(this.txtMAHP);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.txtHK);
            this.Controls.Add(this.txtNAM);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnQuayLai);
            this.Text = "Chỉnh sửa Mở Môn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

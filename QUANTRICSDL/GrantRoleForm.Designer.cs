namespace QUANTRICSDL
{
    partial class GrantRoleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrantRole;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(130, 30);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(200, 24);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(130, 70);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(200, 24);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Chọn User:";
            this.label1.AutoSize = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Text = "Chọn Role:";
            this.label2.AutoSize = true;
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Location = new System.Drawing.Point(130, 110);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(200, 30);
            this.btnGrantRole.Text = "Gán Role cho User";
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // GrantRoleForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 170);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGrantRole);
            this.Name = "GrantRoleForm";
            this.Text = "Gán Role cho User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

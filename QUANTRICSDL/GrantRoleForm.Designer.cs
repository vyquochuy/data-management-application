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
            cbUser = new ComboBox();
            cbRole = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnGrantRole = new Button();
            SuspendLayout();
            // 
            // cbUser
            // 
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(130, 30);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(200, 28);
            cbUser.TabIndex = 0;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(130, 70);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 28);
            cbRole.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Chọn Role:";
            // 
            // btnGrantRole
            // 
            btnGrantRole.Location = new Point(130, 110);
            btnGrantRole.Name = "btnGrantRole";
            btnGrantRole.Size = new Size(200, 30);
            btnGrantRole.TabIndex = 4;
            btnGrantRole.Text = "Gán Role cho User";
            btnGrantRole.Click += btnGrantRole_Click;
            // 
            // GrantRoleForm
            // 
            ClientSize = new Size(380, 170);
            Controls.Add(cbUser);
            Controls.Add(cbRole);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnGrantRole);
            Name = "GrantRoleForm";
            Text = "Gán Role cho User";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

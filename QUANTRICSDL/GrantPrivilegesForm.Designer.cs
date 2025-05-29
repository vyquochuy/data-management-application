namespace QUANTRICSDL
{
    partial class GrantPrivilegesForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.cbObjectType = new System.Windows.Forms.ComboBox();
            this.cbObject = new System.Windows.Forms.ComboBox();
            this.clbColumns = new System.Windows.Forms.CheckedListBox();
            this.clbPrivileges = new System.Windows.Forms.ComboBox(); // đổi tử CheckedListBox -> ComboBox (cho phép chọn 1 quyền)
            this.chkWithGrantOption = new System.Windows.Forms.CheckBox();
            this.bGrant = new System.Windows.Forms.Button();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.labelObjectType = new System.Windows.Forms.Label();
            this.labelObject = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelPrivileges = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbUserRole
            // 
            this.cbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Location = new System.Drawing.Point(150, 20);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(250, 24);
            // 
            // cbObjectType
            // 
            this.cbObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjectType.FormattingEnabled = true;
            this.cbObjectType.Location = new System.Drawing.Point(150, 60);
            this.cbObjectType.Name = "cbObjectType";
            this.cbObjectType.Size = new System.Drawing.Size(250, 24);
            this.cbObjectType.SelectedIndexChanged += new System.EventHandler(this.cbObjectType_SelectedIndexChanged);
            // 
            // cbObject
            // 
            this.cbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObject.FormattingEnabled = true;
            this.cbObject.Location = new System.Drawing.Point(150, 100);
            this.cbObject.Name = "cbObject";
            this.cbObject.Size = new System.Drawing.Size(250, 24);
            this.cbObject.SelectedIndexChanged += new System.EventHandler(this.cbObject_SelectedIndexChanged);
            // 
            // clbColumns
            // 
            this.clbColumns.FormattingEnabled = true;
            this.clbColumns.Location = new System.Drawing.Point(150, 140);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(250, 89);
            // 
            // clbPrivileges
            // 
            // clbPrivileges (đã chuyển sang ComboBox)
            this.clbPrivileges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clbPrivileges.FormattingEnabled = true;
            this.clbPrivileges.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.clbPrivileges.Location = new System.Drawing.Point(150, 250);
            this.clbPrivileges.Name = "clbPrivileges";
            this.clbPrivileges.Size = new System.Drawing.Size(250, 89);
            // 
            // chkWithGrantOption
            // 
            this.chkWithGrantOption.AutoSize = true;
            this.chkWithGrantOption.Location = new System.Drawing.Point(150, 360);
            this.chkWithGrantOption.Name = "chkWithGrantOption";
            this.chkWithGrantOption.Size = new System.Drawing.Size(150, 21);
            this.chkWithGrantOption.Text = "WITH GRANT OPTION";
            // 
            // bGrant
            // 
            this.bGrant.Location = new System.Drawing.Point(150, 400);
            this.bGrant.Name = "bGrant";
            this.bGrant.Size = new System.Drawing.Size(100, 30);
            this.bGrant.Text = "Cấp quyền";
            this.bGrant.UseVisualStyleBackColor = true;
            this.bGrant.Click += new System.EventHandler(this.bGrant_Click);
            // 
            // Labels
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Location = new System.Drawing.Point(30, 23);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(114, 17);
            this.labelUserRole.Text = "Người dùng/Role:";
            //
            this.labelObjectType.AutoSize = true;
            this.labelObjectType.Location = new System.Drawing.Point(30, 63);
            this.labelObjectType.Name = "labelObjectType";
            this.labelObjectType.Size = new System.Drawing.Size(82, 17);
            this.labelObjectType.Text = "Loại đối tượng:";
            //
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(30, 103);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(72, 17);
            this.labelObject.Text = "Đối tượng:";
            //
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(30, 143);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(42, 17);
            this.labelColumns.Text = "Cột:";
            //
            this.labelPrivileges.AutoSize = true;
            this.labelPrivileges.Location = new System.Drawing.Point(30, 253);
            this.labelPrivileges.Name = "labelPrivileges";
            this.labelPrivileges.Size = new System.Drawing.Size(68, 17);
            this.labelPrivileges.Text = "Quyền:";
            //
            // GrantPrivilegesForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.cbUserRole);
            this.Controls.Add(this.cbObjectType);
            this.Controls.Add(this.cbObject);
            this.Controls.Add(this.clbColumns);
            this.Controls.Add(this.clbPrivileges);
            this.Controls.Add(this.chkWithGrantOption);
            this.Controls.Add(this.bGrant);
            this.Controls.Add(this.labelUserRole);
            this.Controls.Add(this.labelObjectType);
            this.Controls.Add(this.labelObject);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelPrivileges);
            this.Name = "GrantPrivilegesForm";
            this.Text = "Cấp quyền cho người dùng/role";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.ComboBox cbObjectType;
        private System.Windows.Forms.ComboBox cbObject;
        private System.Windows.Forms.CheckedListBox clbColumns;
        private System.Windows.Forms.ComboBox clbPrivileges;
        private System.Windows.Forms.CheckBox chkWithGrantOption;
        private System.Windows.Forms.Button bGrant;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.Label labelObjectType;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelPrivileges;
    }
}

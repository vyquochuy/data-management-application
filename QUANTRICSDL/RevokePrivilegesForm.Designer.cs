namespace QUANTRICSDL
{
    partial class RevokePrivilegesForm
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
            this.cbUserOrRole = new System.Windows.Forms.ComboBox();
            this.btnViewPrivileges = new System.Windows.Forms.Button();
            this.listViewPrivileges = new System.Windows.Forms.ListView();
            this.columnTableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrivilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrantable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbUserOrRole
            // 
            this.cbUserOrRole.FormattingEnabled = true;
            this.cbUserOrRole.Location = new System.Drawing.Point(20, 20);
            this.cbUserOrRole.Name = "cbUserOrRole";
            this.cbUserOrRole.Size = new System.Drawing.Size(300, 24);
            this.cbUserOrRole.TabIndex = 0;
            // 
            // btnViewPrivileges
            // 
            this.btnViewPrivileges.Location = new System.Drawing.Point(340, 20);
            this.btnViewPrivileges.Name = "btnViewPrivileges";
            this.btnViewPrivileges.Size = new System.Drawing.Size(100, 24);
            this.btnViewPrivileges.TabIndex = 1;
            this.btnViewPrivileges.Text = "Xem quyền";
            this.btnViewPrivileges.UseVisualStyleBackColor = true;
            this.btnViewPrivileges.Click += new System.EventHandler(this.btnViewPrivileges_Click);
            // 
            // listViewPrivileges
            // 
            this.listViewPrivileges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTableName,
            this.columnPrivilege,
            this.columnGrantable,
            this.columnType});
            this.listViewPrivileges.FullRowSelect = true;
            this.listViewPrivileges.GridLines = true;
            this.listViewPrivileges.HideSelection = false;
            this.listViewPrivileges.Location = new System.Drawing.Point(20, 60);
            this.listViewPrivileges.Name = "listViewPrivileges";
            this.listViewPrivileges.Size = new System.Drawing.Size(600, 300);
            this.listViewPrivileges.TabIndex = 2;
            this.listViewPrivileges.UseCompatibleStateImageBehavior = false;
            this.listViewPrivileges.View = System.Windows.Forms.View.Details;
            // 
            // columnTableName
            // 
            this.columnTableName.Text = "Tên bảng";
            this.columnTableName.Width = 150;
            // 
            // columnPrivilege
            // 
            this.columnPrivilege.Text = "Tên quyền";
            this.columnPrivilege.Width = 150;
            // 
            // columnGrantable
            // 
            this.columnGrantable.Text = "Được cấp tiếp?";
            this.columnGrantable.Width = 120;
            // 
            // columnType
            // 
            this.columnType.Text = "Loại quyền";
            this.columnType.Width = 150;
            // 
            // UserRoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.listViewPrivileges);
            this.Controls.Add(this.btnViewPrivileges);
            this.Controls.Add(this.cbUserOrRole);
            this.Name = "UserRoleDetail";
            this.Text = "Chi tiết quyền của User/Role";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cbUserOrRole;
        private System.Windows.Forms.Button btnViewPrivileges;
        private System.Windows.Forms.ListView listViewPrivileges;
        private System.Windows.Forms.ColumnHeader columnTableName;
        private System.Windows.Forms.ColumnHeader columnPrivilege;
        private System.Windows.Forms.ColumnHeader columnGrantable;
        private System.Windows.Forms.ColumnHeader columnType;
    }
}

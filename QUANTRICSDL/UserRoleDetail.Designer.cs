namespace QUANTRICSDL
{
    partial class UserRoleDetail
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
            cbUserOrRole = new ComboBox();
            btnViewPrivileges = new Button();
            listViewPrivileges = new ListView();
            columnTableName = new ColumnHeader();
            columnPrivilege = new ColumnHeader();
            columnGrantable = new ColumnHeader();
            columnType = new ColumnHeader();
            SuspendLayout();
            // 
            // cbUserOrRole
            // 
            cbUserOrRole.FormattingEnabled = true;
            cbUserOrRole.Location = new Point(20, 25);
            cbUserOrRole.Margin = new Padding(3, 4, 3, 4);
            cbUserOrRole.Name = "cbUserOrRole";
            cbUserOrRole.Size = new Size(300, 28);
            cbUserOrRole.TabIndex = 0;
            // 
            // btnViewPrivileges
            // 
            btnViewPrivileges.Location = new Point(340, 25);
            btnViewPrivileges.Margin = new Padding(3, 4, 3, 4);
            btnViewPrivileges.Name = "btnViewPrivileges";
            btnViewPrivileges.Size = new Size(100, 30);
            btnViewPrivileges.TabIndex = 1;
            btnViewPrivileges.Text = "Xem quyền";
            btnViewPrivileges.UseVisualStyleBackColor = true;
            btnViewPrivileges.Click += btnViewPrivileges_Click;
            // 
            // listViewPrivileges
            // 
            listViewPrivileges.Columns.AddRange(new ColumnHeader[] { columnTableName, columnPrivilege, columnGrantable, columnType });
            listViewPrivileges.FullRowSelect = true;
            listViewPrivileges.GridLines = true;
            listViewPrivileges.Location = new Point(20, 75);
            listViewPrivileges.Margin = new Padding(3, 4, 3, 4);
            listViewPrivileges.Name = "listViewPrivileges";
            listViewPrivileges.Size = new Size(600, 374);
            listViewPrivileges.TabIndex = 2;
            listViewPrivileges.UseCompatibleStateImageBehavior = false;
            listViewPrivileges.View = View.Details;
            listViewPrivileges.SelectedIndexChanged += listViewPrivileges_SelectedIndexChanged;
            // 
            // columnTableName
            // 
            columnTableName.Text = "Tên bảng";
            columnTableName.Width = 150;
            // 
            // columnPrivilege
            // 
            columnPrivilege.Text = "Tên quyền";
            columnPrivilege.Width = 150;
            // 
            // columnGrantable
            // 
            columnGrantable.Text = "Được cấp tiếp?";
            columnGrantable.Width = 120;
            // 
            // columnType
            // 
            columnType.Text = "Loại quyền";
            columnType.Width = 150;
            // 
            // UserRoleDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 500);
            Controls.Add(listViewPrivileges);
            Controls.Add(btnViewPrivileges);
            Controls.Add(cbUserOrRole);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserRoleDetail";
            Text = "Chi tiết quyền của User/Role";
            ResumeLayout(false);
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

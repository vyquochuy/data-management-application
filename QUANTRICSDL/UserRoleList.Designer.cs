namespace QUANTRICSDL
{
    partial class UserRoleList
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
        /// 

        ListView lvUsersRoles;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ListView";

            this.lvUsersRoles = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            // 
            // lvUsersRoles
            // 
            this.lvUsersRoles.Location = new System.Drawing.Point(12, 12);
            this.lvUsersRoles.Size = new System.Drawing.Size(760, 400);
            this.lvUsersRoles.View = View.Details;
            this.lvUsersRoles.FullRowSelect = true;
            this.lvUsersRoles.GridLines = true;

            // Thêm các cột
            this.lvUsersRoles.Columns.Add("Tên người dùng", 200);
            this.lvUsersRoles.Columns.Add("Loại", 150); // User hoặc Role

            // 
            // UserRoleListForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvUsersRoles);
            this.Text = "Danh sách User và Role";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
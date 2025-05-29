namespace QUANTRICSDL
{
    partial class ManageForm
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
            pBackground = new Panel();
            bUpdate = new Button();
            bBack = new Button();
            bDelete = new Button();
            bCreate = new Button();
            lAnnouncement = new Label();
            bGrant = new Button();
            pBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pBackground
            // 
            pBackground.Controls.Add(bGrant);
            pBackground.Controls.Add(bUpdate);
            pBackground.Controls.Add(bBack);
            pBackground.Controls.Add(bDelete);
            pBackground.Controls.Add(bCreate);
            pBackground.Controls.Add(lAnnouncement);
            pBackground.Location = new Point(10, 9);
            pBackground.Margin = new Padding(3, 2, 3, 2);
            pBackground.Name = "pBackground";
            pBackground.Size = new Size(366, 280);
            pBackground.TabIndex = 0;
            // 
            // bUpdate
            // 
            bUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bUpdate.Location = new Point(116, 129);
            bUpdate.Margin = new Padding(3, 2, 3, 2);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(133, 46);
            bUpdate.TabIndex = 5;
            bUpdate.Text = "Gán vai trò cho người dùng";
            bUpdate.UseVisualStyleBackColor = true;
            bUpdate.Click += bGrantRole_Click;
            // 
            // bBack
            // 
            bBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bBack.Location = new Point(116, 232);
            bBack.Margin = new Padding(3, 2, 3, 2);
            bBack.Name = "bBack";
            bBack.Size = new Size(133, 46);
            bBack.TabIndex = 4;
            bBack.Text = "Quay lại";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // bDelete
            // 
            bDelete.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDelete.Location = new Point(116, 78);
            bDelete.Margin = new Padding(3, 2, 3, 2);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(133, 46);
            bDelete.TabIndex = 2;
            bDelete.Text = "Xóa";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bCreate
            // 
            bCreate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCreate.Location = new Point(116, 27);
            bCreate.Margin = new Padding(3, 2, 3, 2);
            bCreate.Name = "bCreate";
            bCreate.Size = new Size(133, 46);
            bCreate.TabIndex = 1;
            bCreate.Text = "Tạo mới";
            bCreate.UseVisualStyleBackColor = true;
            bCreate.Click += bCreate_Click;
            // 
            // lAnnouncement
            // 
            lAnnouncement.AutoSize = true;
            lAnnouncement.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lAnnouncement.Location = new Point(69, 0);
            lAnnouncement.Name = "lAnnouncement";
            lAnnouncement.Size = new Size(197, 26);
            lAnnouncement.TabIndex = 0;
            lAnnouncement.Text = "Bạn muốn làm gì?";
            // 
            // bGrant
            // 
            bGrant.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bGrant.Location = new Point(116, 179);
            bGrant.Margin = new Padding(3, 2, 3, 2);
            bGrant.Name = "bGrant";
            bGrant  .Size = new Size(133, 46);
            bGrant.TabIndex = 6;
            bGrant.Text = "Cấp quyền";
            bGrant.UseVisualStyleBackColor = true;
            bGrant.Click += bGrantPrivileges_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 300);
            Controls.Add(pBackground);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý";
            pBackground.ResumeLayout(false);
            pBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pBackground;
        private Label lAnnouncement;
        private Button bCreate;
        private Button bDelete;
        private Button bBack;
        private Button bUpdate;
        private Button bGrant;
    }
}
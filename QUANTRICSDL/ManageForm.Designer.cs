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
            bGrant = new Button();
            bUpdate = new Button();
            bBack = new Button();
            bDelete = new Button();
            bCreate = new Button();
            lAnnouncement = new Label();
            bRevoke = new Button();
            pBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pBackground
            // 
            pBackground.Controls.Add(bRevoke);
            pBackground.Controls.Add(bGrant);
            pBackground.Controls.Add(bUpdate);
            pBackground.Controls.Add(bBack);
            pBackground.Controls.Add(bDelete);
            pBackground.Controls.Add(bCreate);
            pBackground.Controls.Add(lAnnouncement);
            pBackground.Location = new Point(11, 12);
            pBackground.Name = "pBackground";
            pBackground.Size = new Size(418, 449);
            pBackground.TabIndex = 0;
            // 
            // bGrant
            // 
            bGrant.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bGrant.Location = new Point(133, 239);
            bGrant.Name = "bGrant";
            bGrant.Size = new Size(152, 61);
            bGrant.TabIndex = 6;
            bGrant.Text = "Cấp quyền";
            bGrant.UseVisualStyleBackColor = true;
            bGrant.Click += bGrantPrivileges_Click;
            // 
            // bUpdate
            // 
            bUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bUpdate.Location = new Point(133, 172);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(152, 61);
            bUpdate.TabIndex = 5;
            bUpdate.Text = "Gán vai trò cho người dùng";
            bUpdate.UseVisualStyleBackColor = true;
            bUpdate.Click += bGrantRole_Click;
            // 
            // bBack
            // 
            bBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bBack.Location = new Point(133, 370);
            bBack.Name = "bBack";
            bBack.Size = new Size(152, 61);
            bBack.TabIndex = 4;
            bBack.Text = "Quay lại";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // bDelete
            // 
            bDelete.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDelete.Location = new Point(133, 104);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(152, 61);
            bDelete.TabIndex = 2;
            bDelete.Text = "Xóa";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bCreate
            // 
            bCreate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCreate.Location = new Point(133, 36);
            bCreate.Name = "bCreate";
            bCreate.Size = new Size(152, 61);
            bCreate.TabIndex = 1;
            bCreate.Text = "Tạo mới";
            bCreate.UseVisualStyleBackColor = true;
            bCreate.Click += bCreate_Click;
            // 
            // lAnnouncement
            // 
            lAnnouncement.AutoSize = true;
            lAnnouncement.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lAnnouncement.Location = new Point(79, 0);
            lAnnouncement.Name = "lAnnouncement";
            lAnnouncement.Size = new Size(260, 33);
            lAnnouncement.TabIndex = 0;
            lAnnouncement.Text = "Bạn muốn làm gì?";
            // 
            // bRevoke
            //
            bRevoke.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bRevoke.Location = new Point(133, 306);
            bRevoke.Name = "bRevoke";
            bRevoke.Size = new Size(152, 61);
            bRevoke.TabIndex = 7;
            bRevoke.Text = "Thu hồi quyền";
            bRevoke.UseVisualStyleBackColor = true;
            bRevoke.Click += bRevoke_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 481);
            Controls.Add(pBackground);
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
        private Button bRevoke;
    }
}
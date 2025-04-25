namespace QUANTRICSDL
{
    partial class DeleteForm
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
            tcCreate = new TabControl();
            tpUser = new TabPage();
            pUsername = new Panel();
            tbUsername = new TextBox();
            lUsername = new Label();
            bDelete = new Button();
            bBack = new Button();
            tpRole = new TabPage();
            bDelete2 = new Button();
            bBack2 = new Button();
            pRoleName = new Panel();
            textBox4 = new TextBox();
            lRoleName = new Label();
            pBackground.SuspendLayout();
            tcCreate.SuspendLayout();
            tpUser.SuspendLayout();
            pUsername.SuspendLayout();
            tpRole.SuspendLayout();
            pRoleName.SuspendLayout();
            SuspendLayout();
            // 
            // pBackground
            // 
            pBackground.Controls.Add(tcCreate);
            pBackground.Location = new Point(12, 12);
            pBackground.Name = "pBackground";
            pBackground.Size = new Size(417, 133);
            pBackground.TabIndex = 0;
            // 
            // tcCreate
            // 
            tcCreate.Controls.Add(tpUser);
            tcCreate.Controls.Add(tpRole);
            tcCreate.Location = new Point(3, 13);
            tcCreate.Name = "tcCreate";
            tcCreate.SelectedIndex = 0;
            tcCreate.Size = new Size(412, 119);
            tcCreate.TabIndex = 1;
            // 
            // tpUser
            // 
            tpUser.Controls.Add(pUsername);
            tpUser.Controls.Add(bDelete);
            tpUser.Controls.Add(bBack);
            tpUser.Location = new Point(4, 29);
            tpUser.Name = "tpUser";
            tpUser.Padding = new Padding(3);
            tpUser.Size = new Size(404, 86);
            tpUser.TabIndex = 0;
            tpUser.Text = "Người dùng";
            tpUser.UseVisualStyleBackColor = true;
            // 
            // pUsername
            // 
            pUsername.Controls.Add(tbUsername);
            pUsername.Controls.Add(lUsername);
            pUsername.Location = new Point(6, 6);
            pUsername.Name = "pUsername";
            pUsername.Size = new Size(393, 34);
            pUsername.TabIndex = 11;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(119, 3);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(271, 27);
            tbUsername.TabIndex = 1;
            // 
            // lUsername
            // 
            lUsername.AutoSize = true;
            lUsername.Location = new Point(3, 0);
            lUsername.Name = "lUsername";
            lUsername.Size = new Size(110, 20);
            lUsername.TabIndex = 0;
            lUsername.Text = "Tên đăng nhập:";
            // 
            // bDelete
            // 
            bDelete.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bDelete.Location = new Point(61, 46);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(126, 33);
            bDelete.TabIndex = 10;
            bDelete.Text = "Xóa";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bBack
            // 
            bBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bBack.Location = new Point(200, 46);
            bBack.Name = "bBack";
            bBack.Size = new Size(126, 33);
            bBack.TabIndex = 9;
            bBack.Text = "Quay lại";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // tpRole
            // 
            tpRole.Controls.Add(bDelete2);
            tpRole.Controls.Add(bBack2);
            tpRole.Controls.Add(pRoleName);
            tpRole.Location = new Point(4, 29);
            tpRole.Name = "tpRole";
            tpRole.Padding = new Padding(3);
            tpRole.Size = new Size(404, 86);
            tpRole.TabIndex = 1;
            tpRole.Text = "Vai trò";
            tpRole.UseVisualStyleBackColor = true;
            // 
            // bDelete2
            // 
            bDelete2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bDelete2.Location = new Point(61, 46);
            bDelete2.Name = "bDelete2";
            bDelete2.Size = new Size(126, 33);
            bDelete2.TabIndex = 15;
            bDelete2.Text = "Xóa";
            bDelete2.UseVisualStyleBackColor = true;
            bDelete2.Click += bDelete2_Click;
            // 
            // bBack2
            // 
            bBack2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bBack2.Location = new Point(200, 46);
            bBack2.Name = "bBack2";
            bBack2.Size = new Size(126, 33);
            bBack2.TabIndex = 14;
            bBack2.Text = "Quay lại";
            bBack2.UseVisualStyleBackColor = true;
            bBack2.Click += bBack2_Click;
            // 
            // pRoleName
            // 
            pRoleName.Controls.Add(textBox4);
            pRoleName.Controls.Add(lRoleName);
            pRoleName.Location = new Point(6, 6);
            pRoleName.Name = "pRoleName";
            pRoleName.Size = new Size(393, 34);
            pRoleName.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(271, 27);
            textBox4.TabIndex = 1;
            // 
            // lRoleName
            // 
            lRoleName.AutoSize = true;
            lRoleName.Location = new Point(3, 0);
            lRoleName.Name = "lRoleName";
            lRoleName.Size = new Size(81, 20);
            lRoleName.TabIndex = 0;
            lRoleName.Text = "Tên vai trò:";
            // 
            // DeleteForm
            // 
            AcceptButton = bDelete;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bBack;
            ClientSize = new Size(436, 154);
            Controls.Add(pBackground);
            Name = "DeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xóa";
            pBackground.ResumeLayout(false);
            tcCreate.ResumeLayout(false);
            tpUser.ResumeLayout(false);
            pUsername.ResumeLayout(false);
            pUsername.PerformLayout();
            tpRole.ResumeLayout(false);
            pRoleName.ResumeLayout(false);
            pRoleName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pBackground;
        private TabControl tcCreate;
        private TabPage tpUser;
        private Panel pUsername;
        private TextBox tbUsername;
        private Label lUsername;
        private Button bDelete;
        private Button bBack;
        private TabPage tpRole;
        private Button bDelete2;
        private Button bBack2;
        private Panel pRoleName;
        private TextBox textBox4;
        private Label lRoleName;
    }
}
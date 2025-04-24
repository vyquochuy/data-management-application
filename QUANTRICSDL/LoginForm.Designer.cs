namespace QUANTRICSDL
{
    partial class LoginForm
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
            bLogin = new Button();
            bExit = new Button();
            panel1 = new Panel();
            tbPassword = new TextBox();
            lPassword = new Label();
            pUserName = new Panel();
            tbUserName = new TextBox();
            lUserName = new Label();
            pBackground.SuspendLayout();
            panel1.SuspendLayout();
            pUserName.SuspendLayout();
            SuspendLayout();
            // 
            // pBackground
            // 
            pBackground.Controls.Add(bLogin);
            pBackground.Controls.Add(bExit);
            pBackground.Controls.Add(panel1);
            pBackground.Controls.Add(pUserName);
            pBackground.Location = new Point(12, 12);
            pBackground.Name = "pBackground";
            pBackground.Size = new Size(579, 210);
            pBackground.TabIndex = 0;
            // 
            // bLogin
            // 
            bLogin.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bLogin.Location = new Point(320, 166);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(125, 39);
            bLogin.TabIndex = 3;
            bLogin.Text = "Đăng nhập";
            bLogin.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            bExit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bExit.Location = new Point(451, 166);
            bExit.Name = "bExit";
            bExit.Size = new Size(125, 39);
            bExit.TabIndex = 4;
            bExit.Text = "Thoát";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(lPassword);
            panel1.Location = new Point(3, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 68);
            panel1.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(235, 23);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(335, 27);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lPassword.Location = new Point(3, 17);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(149, 33);
            lPassword.TabIndex = 0;
            lPassword.Text = "Mật khẩu:";
            // 
            // pUserName
            // 
            pUserName.Controls.Add(tbUserName);
            pUserName.Controls.Add(lUserName);
            pUserName.Location = new Point(3, 3);
            pUserName.Name = "pUserName";
            pUserName.Size = new Size(573, 68);
            pUserName.TabIndex = 0;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(235, 23);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(335, 27);
            tbUserName.TabIndex = 1;
            // 
            // lUserName
            // 
            lUserName.AutoSize = true;
            lUserName.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lUserName.Location = new Point(3, 17);
            lUserName.Name = "lUserName";
            lUserName.Size = new Size(226, 33);
            lUserName.TabIndex = 0;
            lUserName.Text = "Tên đăng nhập:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 234);
            Controls.Add(pBackground);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            pBackground.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pUserName.ResumeLayout(false);
            pUserName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pBackground;
        private Panel pUserName;
        private Label lUserName;
        private Panel panel1;
        private TextBox tbPassword;
        private Label lPassword;
        private TextBox tbUserName;
        private Button bLogin;
        private Button bExit;
    }
}
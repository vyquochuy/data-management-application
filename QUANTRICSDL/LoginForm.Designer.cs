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
            pBackground.Location = new Point(18, 18);
            pBackground.Margin = new Padding(4, 4, 4, 4);
            pBackground.Name = "pBackground";
            pBackground.Size = new Size(868, 315);
            pBackground.TabIndex = 0;
            // 
            // bLogin
            // 
            bLogin.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bLogin.Location = new Point(480, 249);
            bLogin.Margin = new Padding(4, 4, 4, 4);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(188, 58);
            bLogin.TabIndex = 3;
            bLogin.Text = "Đăng nhập";
            bLogin.UseVisualStyleBackColor = true;
            bLogin.Click += bLogin_Click;
            // 
            // bExit
            // 
            bExit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bExit.Location = new Point(669, 249);
            bExit.Margin = new Padding(4, 4, 4, 4);
            bExit.Name = "bExit";
            bExit.Size = new Size(188, 58);
            bExit.TabIndex = 4;
            bExit.Text = "Thoát";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(lPassword);
            panel1.Location = new Point(4, 138);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 102);
            panel1.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(352, 34);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(500, 35);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lPassword.Location = new Point(4, 26);
            lPassword.Margin = new Padding(4, 0, 4, 0);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(199, 45);
            lPassword.TabIndex = 0;
            lPassword.Text = "Mật khẩu:";
            // 
            // pUserName
            // 
            pUserName.Controls.Add(tbUserName);
            pUserName.Controls.Add(lUserName);
            pUserName.Location = new Point(4, 4);
            pUserName.Margin = new Padding(4, 4, 4, 4);
            pUserName.Name = "pUserName";
            pUserName.Size = new Size(860, 102);
            pUserName.TabIndex = 0;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(352, 34);
            tbUserName.Margin = new Padding(4, 4, 4, 4);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(500, 35);
            tbUserName.TabIndex = 1;
            tbUserName.TextChanged += tbUserName_TextChanged;
            // 
            // lUserName
            // 
            lUserName.AutoSize = true;
            lUserName.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lUserName.Location = new Point(4, 26);
            lUserName.Margin = new Padding(4, 0, 4, 0);
            lUserName.Name = "lUserName";
            lUserName.Size = new Size(302, 45);
            lUserName.TabIndex = 0;
            lUserName.Text = "Tên đăng nhập:";
            // 
            // LoginForm
            // 
            AcceptButton = bLogin;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bExit;
            ClientSize = new Size(904, 351);
            Controls.Add(pBackground);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += LoginForm_FormClosing;
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
namespace QUANTRICSDL
{
    partial class UserMenuForm
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
            btnOpenNhanVien = new Button();
            btnMoMon = new Button();
            SuspendLayout();
            // 
            // btnOpenNhanVien
            // 
            btnOpenNhanVien.Location = new Point(227, 45);
            btnOpenNhanVien.Name = "btnOpenNhanVien";
            btnOpenNhanVien.Size = new Size(320, 58);
            btnOpenNhanVien.TabIndex = 0;
            btnOpenNhanVien.Text = "Nhân viên";
            btnOpenNhanVien.UseVisualStyleBackColor = true;
            btnOpenNhanVien.Click += button1_Click;
            // 
            // btnMoMon
            // 
            btnMoMon.Location = new Point(227, 128);
            btnMoMon.Name = "button1";
            btnMoMon.Size = new Size(320, 59);
            btnMoMon.TabIndex = 1;
            btnMoMon.Text = "Mở môn";
            btnMoMon.UseVisualStyleBackColor = true;
            btnMoMon.Click += button1_Click_1;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMoMon);
            Controls.Add(btnOpenNhanVien);
            Name = "UserMenuForm";
            Text = "UserMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenNhanVien;
        private Button btnMoMon;
    }
}
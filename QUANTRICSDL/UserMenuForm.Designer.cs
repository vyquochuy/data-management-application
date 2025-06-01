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
            SuspendLayout();
            // 
            // btnOpenNhanVien
            // 
            btnOpenNhanVien.Location = new Point(227, 34);
            btnOpenNhanVien.Name = "btnOpenNhanVien";
            btnOpenNhanVien.Size = new Size(320, 43);
            btnOpenNhanVien.TabIndex = 0;
            btnOpenNhanVien.Text = "Nhân viên";
            btnOpenNhanVien.UseVisualStyleBackColor = true;
            btnOpenNhanVien.Click += button1_Click;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenNhanVien);
            Name = "UserMenuForm";
            Text = "UserMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenNhanVien;
    }
}
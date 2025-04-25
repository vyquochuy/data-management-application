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
            panel1 = new Panel();
            pBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pBackground
            // 
            pBackground.Controls.Add(panel1);
            pBackground.Location = new Point(12, 12);
            pBackground.Name = "pBackground";
            pBackground.Size = new Size(776, 426);
            pBackground.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 82);
            panel1.TabIndex = 0;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pBackground);
            Name = "DeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xóa";
            pBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pBackground;
        private Panel panel1;
    }
}
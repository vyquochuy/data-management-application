namespace QUANTRICSDL
{
    partial class AuditLogForm
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
            cbUser = new ComboBox();
            bSeen = new Button();
            listViewLogInform = new ListView();
            bBack = new Button();
            SuspendLayout();
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(12, 12);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(237, 28);
            cbUser.TabIndex = 0;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // bSeen
            // 
            bSeen.Location = new Point(255, 12);
            bSeen.Name = "bSeen";
            bSeen.Size = new Size(94, 29);
            bSeen.TabIndex = 1;
            bSeen.Text = "Tra Log";
            bSeen.UseVisualStyleBackColor = true;
            bSeen.Click += bSeen_Click;
            // 
            // listViewLogInform
            // 
            listViewLogInform.Location = new Point(12, 46);
            listViewLogInform.Name = "listViewLogInform";
            listViewLogInform.Size = new Size(776, 392);
            listViewLogInform.TabIndex = 2;
            listViewLogInform.UseCompatibleStateImageBehavior = false;
            listViewLogInform.SelectedIndexChanged += listViewLogInform_SelectedIndexChanged;
            // 
            // bBack
            // 
            bBack.Location = new Point(355, 12);
            bBack.Name = "bBack";
            bBack.Size = new Size(94, 29);
            bBack.TabIndex = 3;
            bBack.Text = "Quay lại";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // AuditLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bBack);
            Controls.Add(listViewLogInform);
            Controls.Add(bSeen);
            Controls.Add(cbUser);
            Name = "AuditLogForm";
            Text = "AuditLogForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbUser;
        private Button bSeen;
        private ListView listViewLogInform;
        private Button bBack;
    }
}
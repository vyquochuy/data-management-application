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
            chOjectName = new ColumnHeader();
            chTableName = new ColumnHeader();
            chAct = new ColumnHeader();
            chContent = new ColumnHeader();
            bBack = new Button();
            lbStatus = new Label();
            btnEnableAudit = new Button();
            btnDisableAudit = new Button();
            SuspendLayout();
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(10, 9);
            cbUser.Margin = new Padding(3, 2, 3, 2);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(208, 23);
            cbUser.TabIndex = 0;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // bSeen
            // 
            bSeen.Location = new Point(223, 9);
            bSeen.Margin = new Padding(3, 2, 3, 2);
            bSeen.Name = "bSeen";
            bSeen.Size = new Size(82, 22);
            bSeen.TabIndex = 1;
            bSeen.Text = "Tra Log";
            bSeen.UseVisualStyleBackColor = true;
            bSeen.Click += bSeen_Click;
            // 
            // listViewLogInform
            // 
            listViewLogInform.Columns.AddRange(new ColumnHeader[] { chOjectName, chTableName, chAct, chContent });
            listViewLogInform.FullRowSelect = true;
            listViewLogInform.GridLines = true;
            listViewLogInform.Location = new Point(10, 34);
            listViewLogInform.Margin = new Padding(3, 2, 3, 2);
            listViewLogInform.Name = "listViewLogInform";
            listViewLogInform.Size = new Size(639, 287);
            listViewLogInform.TabIndex = 2;
            listViewLogInform.UseCompatibleStateImageBehavior = false;
            listViewLogInform.View = View.Details;
            listViewLogInform.SelectedIndexChanged += listViewLogInform_SelectedIndexChanged;
            // 
            // chOjectName
            // 
            chOjectName.Text = "Tên đối tượng";
            chOjectName.Width = 120;
            // 
            // chTableName
            // 
            chTableName.Text = "Thời gian";
            chTableName.Width = 120;
            // 
            // chAct
            // 
            chAct.Text = "Hành động";
            chAct.Width = 100;
            // 
            // chContent
            // 
            chContent.Text = "Nội dung";
            chContent.Width = 300;
            // 
            // bBack
            // 
            bBack.Location = new Point(311, 9);
            bBack.Margin = new Padding(3, 2, 3, 2);
            bBack.Name = "bBack";
            bBack.Size = new Size(82, 22);
            bBack.TabIndex = 3;
            bBack.Text = "Quay lại";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Dock = DockStyle.Bottom;
            lbStatus.Location = new Point(0, 323);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(45, 15);
            lbStatus.TabIndex = 4;
            lbStatus.Text = "Status: ";
            lbStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEnableAudit
            // 
            btnEnableAudit.Location = new Point(398, 9);
            btnEnableAudit.Margin = new Padding(3, 2, 3, 2);
            btnEnableAudit.Name = "btnEnableAudit";
            btnEnableAudit.Size = new Size(82, 22);
            btnEnableAudit.TabIndex = 5;
            btnEnableAudit.Text = "Bật Audit";
            btnEnableAudit.UseVisualStyleBackColor = true;
            btnEnableAudit.Click += btnEnableAudit_Click;
            // 
            // btnDisableAudit
            // 
            btnDisableAudit.Location = new Point(486, 9);
            btnDisableAudit.Margin = new Padding(3, 2, 3, 2);
            btnDisableAudit.Name = "btnDisableAudit";
            btnDisableAudit.Size = new Size(82, 22);
            btnDisableAudit.TabIndex = 6;
            btnDisableAudit.Text = "Tắt Audit";
            btnDisableAudit.UseVisualStyleBackColor = true;
            btnDisableAudit.Click += btnDisableAudit_Click;
            // 
            // AuditLogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 338);
            Controls.Add(btnDisableAudit);
            Controls.Add(btnEnableAudit);
            Controls.Add(lbStatus);
            Controls.Add(bBack);
            Controls.Add(listViewLogInform);
            Controls.Add(bSeen);
            Controls.Add(cbUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AuditLogForm";
            Text = "AuditLogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUser;
        private Button bSeen;
        private ListView listViewLogInform;
        private Button bBack;
        private Label lbStatus;
        private ColumnHeader chOjectName;
        private ColumnHeader chTableName;
        private ColumnHeader chAct;
        private ColumnHeader chContent;
        private Button btnEnableAudit;
        private Button btnDisableAudit;
    }
}
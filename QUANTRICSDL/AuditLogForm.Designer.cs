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
            chImpactedColumn = new ColumnHeader();
            chTime = new ColumnHeader();
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
            listViewLogInform.Columns.AddRange(new ColumnHeader[] { chOjectName, chTableName, chAct, chImpactedColumn, chTime, chContent });
            listViewLogInform.FullRowSelect = true;
            listViewLogInform.GridLines = true;
            listViewLogInform.Location = new Point(12, 46);
            listViewLogInform.Name = "listViewLogInform";
            listViewLogInform.Size = new Size(892, 381);
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
            chTableName.Text = "Tên bảng";
            chTableName.Width = 120;
            // 
            // chAct
            // 
            chAct.Text = "Hành động";
            chAct.Width = 100;
            // 
            // chImpactedColumn
            // 
            chImpactedColumn.Text = "Cột bị tác động";
            chImpactedColumn.Width = 150;
            // 
            // chTime
            // 
            chTime.Text = "Thời gian";
            chTime.Width = 160;
            // 
            // chContent
            // 
            chContent.Text = "Nội dung";
            chContent.Width = 300;
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
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Dock = DockStyle.Bottom;
            lbStatus.Location = new Point(0, 430);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(56, 20);
            lbStatus.TabIndex = 4;
            lbStatus.Text = "Status: ";
            lbStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEnableAudit
            // 
            btnEnableAudit.Location = new Point(455, 12);
            btnEnableAudit.Name = "btnEnableAudit";
            btnEnableAudit.Size = new Size(94, 29);
            btnEnableAudit.TabIndex = 5;
            btnEnableAudit.Text = "Bật Audit";
            btnEnableAudit.UseVisualStyleBackColor = true;
            btnEnableAudit.Click += btnEnableAudit_Click;
            // 
            // btnDisableAudit
            // 
            btnDisableAudit.Location = new Point(555, 12);
            btnDisableAudit.Name = "btnDisableAudit";
            btnDisableAudit.Size = new Size(94, 29);
            btnDisableAudit.TabIndex = 6;
            btnDisableAudit.Text = "Tắt Audit";
            btnDisableAudit.UseVisualStyleBackColor = true;
            btnDisableAudit.Click += btnDisableAudit_Click;
            // 
            // AuditLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(btnDisableAudit);
            Controls.Add(btnEnableAudit);
            Controls.Add(lbStatus);
            Controls.Add(bBack);
            Controls.Add(listViewLogInform);
            Controls.Add(bSeen);
            Controls.Add(cbUser);
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
        private ColumnHeader chImpactedColumn;
        private ColumnHeader chTime;
        private ColumnHeader chContent;
        private Button btnEnableAudit;
        private Button btnDisableAudit;
    }
}
namespace QUANTRICSDL
{
    partial class CreateForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            tcCreate = new TabControl();
            tpUser = new TabPage();
            bCreate = new Button();
            bBack = new Button();
            pPower = new Panel();
            cbPower = new CheckBox();
            lPower = new Label();
            pId = new Panel();
            textBox2 = new TextBox();
            lId = new Label();
            pPosition = new Panel();
            cbPosition = new ComboBox();
            lPosition = new Label();
            pFullName = new Panel();
            tbFullName = new TextBox();
            lFullName = new Label();
            pPhoneNumber = new Panel();
            tbPhoneNumber = new TextBox();
            lPhoneNumber = new Label();
            pRole = new Panel();
            cbRole = new ComboBox();
            lRole = new Label();
            pPassword = new Panel();
            textBox1 = new TextBox();
            lPassword = new Label();
            pUsername = new Panel();
            tbUsername = new TextBox();
            lUsername = new Label();
            tpRole = new TabPage();
            pPower2 = new Panel();
            cbPower2 = new CheckBox();
            lPower2 = new Label();
            bCreate2 = new Button();
            bBack2 = new Button();
            gb = new GroupBox();
            pDelete = new Panel();
            tbDelete = new TextBox();
            lDelete = new Label();
            pInsert = new Panel();
            tbInsert = new TextBox();
            lInsert = new Label();
            pSelect = new Panel();
            tbSelect = new TextBox();
            lSelect = new Label();
            pRoleName = new Panel();
            textBox4 = new TextBox();
            lRoleName = new Label();
            panel1.SuspendLayout();
            tcCreate.SuspendLayout();
            tpUser.SuspendLayout();
            pPower.SuspendLayout();
            pId.SuspendLayout();
            pPosition.SuspendLayout();
            pFullName.SuspendLayout();
            pPhoneNumber.SuspendLayout();
            pRole.SuspendLayout();
            pPassword.SuspendLayout();
            pUsername.SuspendLayout();
            tpRole.SuspendLayout();
            pPower2.SuspendLayout();
            gb.SuspendLayout();
            pDelete.SuspendLayout();
            pInsert.SuspendLayout();
            pSelect.SuspendLayout();
            pRoleName.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Controls.Add(tcCreate);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 408);
            panel1.TabIndex = 1;
            // 
            // tcCreate
            // 
            tcCreate.Controls.Add(tpUser);
            tcCreate.Controls.Add(tpRole);
            tcCreate.Location = new Point(3, 3);
            tcCreate.Name = "tcCreate";
            tcCreate.SelectedIndex = 0;
            tcCreate.Size = new Size(770, 401);
            tcCreate.TabIndex = 0;
            // 
            // tpUser
            // 
            tpUser.Controls.Add(bCreate);
            tpUser.Controls.Add(bBack);
            tpUser.Controls.Add(pPower);
            tpUser.Controls.Add(pId);
            tpUser.Controls.Add(pPosition);
            tpUser.Controls.Add(pFullName);
            tpUser.Controls.Add(pPhoneNumber);
            tpUser.Controls.Add(pRole);
            tpUser.Controls.Add(pPassword);
            tpUser.Controls.Add(pUsername);
            tpUser.Location = new Point(4, 29);
            tpUser.Name = "tpUser";
            tpUser.Padding = new Padding(3);
            tpUser.Size = new Size(762, 368);
            tpUser.TabIndex = 0;
            tpUser.Text = "Người dùng";
            tpUser.UseVisualStyleBackColor = true;
            // 
            // bCreate
            // 
            bCreate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bCreate.Location = new Point(266, 246);
            bCreate.Name = "bCreate";
            bCreate.Size = new Size(133, 58);
            bCreate.TabIndex = 10;
            bCreate.Text = "Tạo mới";
            bCreate.UseVisualStyleBackColor = true;
            bCreate.Click += bCreate_Click;
            // 
            // bBack
            // 
            bBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bBack.Location = new Point(405, 246);
            bBack.Name = "bBack";
            bBack.Size = new Size(133, 58);
            bBack.TabIndex = 9;
            bBack.Text = "Quay lại";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // pPower
            // 
            pPower.Controls.Add(cbPower);
            pPower.Controls.Add(lPower);
            pPower.Location = new Point(6, 206);
            pPower.Name = "pPower";
            pPower.Size = new Size(750, 34);
            pPower.TabIndex = 8;
            // 
            // cbPower
            // 
            cbPower.AutoSize = true;
            cbPower.Location = new Point(341, 0);
            cbPower.Name = "cbPower";
            cbPower.Size = new Size(49, 24);
            cbPower.TabIndex = 1;
            cbPower.Text = "Có";
            cbPower.UseVisualStyleBackColor = true;
            // 
            // lPower
            // 
            lPower.AutoSize = true;
            lPower.Location = new Point(0, 0);
            lPower.Name = "lPower";
            lPower.Size = new Size(313, 20);
            lPower.TabIndex = 0;
            lPower.Text = "Được phép cấp quyền tương tự cho user khác:";
            // 
            // pId
            // 
            pId.Controls.Add(textBox2);
            pId.Controls.Add(lId);
            pId.Location = new Point(405, 166);
            pId.Name = "pId";
            pId.Size = new Size(351, 34);
            pId.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 1;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Location = new Point(3, 3);
            lId.Name = "lId";
            lId.Size = new Size(52, 20);
            lId.TabIndex = 0;
            lId.Text = "Mã số:";
            // 
            // pPosition
            // 
            pPosition.Controls.Add(cbPosition);
            pPosition.Controls.Add(lPosition);
            pPosition.Location = new Point(6, 126);
            pPosition.Name = "pPosition";
            pPosition.Size = new Size(393, 34);
            pPosition.TabIndex = 5;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(119, -3);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(271, 28);
            cbPosition.TabIndex = 1;
            // 
            // lPosition
            // 
            lPosition.AutoSize = true;
            lPosition.Location = new Point(3, 0);
            lPosition.Name = "lPosition";
            lPosition.Size = new Size(64, 20);
            lPosition.TabIndex = 0;
            lPosition.Text = "Chức vụ:";
            // 
            // pFullName
            // 
            pFullName.Controls.Add(tbFullName);
            pFullName.Controls.Add(lFullName);
            pFullName.Location = new Point(6, 166);
            pFullName.Name = "pFullName";
            pFullName.Size = new Size(393, 34);
            pFullName.TabIndex = 4;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(119, 3);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(271, 27);
            tbFullName.TabIndex = 1;
            // 
            // lFullName
            // 
            lFullName.AutoSize = true;
            lFullName.Location = new Point(0, 0);
            lFullName.Name = "lFullName";
            lFullName.Size = new Size(76, 20);
            lFullName.TabIndex = 0;
            lFullName.Text = "Họ và tên:";
            // 
            // pPhoneNumber
            // 
            pPhoneNumber.Controls.Add(tbPhoneNumber);
            pPhoneNumber.Controls.Add(lPhoneNumber);
            pPhoneNumber.Location = new Point(6, 86);
            pPhoneNumber.Name = "pPhoneNumber";
            pPhoneNumber.Size = new Size(393, 34);
            pPhoneNumber.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(119, 3);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(271, 27);
            tbPhoneNumber.TabIndex = 1;
            // 
            // lPhoneNumber
            // 
            lPhoneNumber.AutoSize = true;
            lPhoneNumber.Location = new Point(0, 0);
            lPhoneNumber.Name = "lPhoneNumber";
            lPhoneNumber.Size = new Size(100, 20);
            lPhoneNumber.TabIndex = 0;
            lPhoneNumber.Text = "Số điện thoại:";
            // 
            // pRole
            // 
            pRole.Controls.Add(cbRole);
            pRole.Controls.Add(lRole);
            pRole.Location = new Point(6, 46);
            pRole.Name = "pRole";
            pRole.Size = new Size(393, 34);
            pRole.TabIndex = 2;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(119, -3);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(271, 28);
            cbRole.TabIndex = 1;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // lRole
            // 
            lRole.AutoSize = true;
            lRole.Location = new Point(3, 0);
            lRole.Name = "lRole";
            lRole.Size = new Size(55, 20);
            lRole.TabIndex = 0;
            lRole.Text = "Vai trò:";
            // 
            // pPassword
            // 
            pPassword.Controls.Add(textBox1);
            pPassword.Controls.Add(lPassword);
            pPassword.Location = new Point(405, 6);
            pPassword.Name = "pPassword";
            pPassword.Size = new Size(351, 34);
            pPassword.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 1;
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Location = new Point(3, 3);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(73, 20);
            lPassword.TabIndex = 0;
            lPassword.Text = "Mật khẩu:";
            // 
            // pUsername
            // 
            pUsername.Controls.Add(tbUsername);
            pUsername.Controls.Add(lUsername);
            pUsername.Location = new Point(6, 6);
            pUsername.Name = "pUsername";
            pUsername.Size = new Size(393, 34);
            pUsername.TabIndex = 0;
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
            // tpRole
            // 
            tpRole.Controls.Add(pPower2);
            tpRole.Controls.Add(bCreate2);
            tpRole.Controls.Add(bBack2);
            tpRole.Controls.Add(gb);
            tpRole.Controls.Add(pRoleName);
            tpRole.Location = new Point(4, 29);
            tpRole.Name = "tpRole";
            tpRole.Padding = new Padding(3);
            tpRole.Size = new Size(762, 368);
            tpRole.TabIndex = 1;
            tpRole.Text = "Vai trò";
            tpRole.UseVisualStyleBackColor = true;
            // 
            // pPower2
            // 
            pPower2.Controls.Add(cbPower2);
            pPower2.Controls.Add(lPower2);
            pPower2.Location = new Point(6, 46);
            pPower2.Name = "pPower2";
            pPower2.Size = new Size(750, 34);
            pPower2.TabIndex = 13;
            // 
            // cbPower2
            // 
            cbPower2.AutoSize = true;
            cbPower2.Location = new Point(341, 0);
            cbPower2.Name = "cbPower2";
            cbPower2.Size = new Size(49, 24);
            cbPower2.TabIndex = 1;
            cbPower2.Text = "Có";
            cbPower2.UseVisualStyleBackColor = true;
            // 
            // lPower2
            // 
            lPower2.AutoSize = true;
            lPower2.Location = new Point(0, 0);
            lPower2.Name = "lPower2";
            lPower2.Size = new Size(312, 20);
            lPower2.TabIndex = 0;
            lPower2.Text = "Được phép cấp quyền tương tự cho role khác:";
            // 
            // bCreate2
            // 
            bCreate2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bCreate2.Location = new Point(252, 307);
            bCreate2.Name = "bCreate2";
            bCreate2.Size = new Size(133, 58);
            bCreate2.TabIndex = 12;
            bCreate2.Text = "Tạo mới";
            bCreate2.UseVisualStyleBackColor = true;
            bCreate2.Click += bCreate2_Click;
            // 
            // bBack2
            // 
            bBack2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bBack2.Location = new Point(391, 307);
            bBack2.Name = "bBack2";
            bBack2.Size = new Size(133, 58);
            bBack2.TabIndex = 11;
            bBack2.Text = "Quay lại";
            bBack2.UseVisualStyleBackColor = true;
            bBack2.Click += bBack2_Click;
            // 
            // gb
            // 
            gb.Controls.Add(pDelete);
            gb.Controls.Add(pInsert);
            gb.Controls.Add(pSelect);
            gb.Location = new Point(6, 86);
            gb.Name = "gb";
            gb.Size = new Size(753, 215);
            gb.TabIndex = 3;
            gb.TabStop = false;
            gb.Text = "Phân quyền";
            // 
            // pDelete
            // 
            pDelete.Controls.Add(tbDelete);
            pDelete.Controls.Add(lDelete);
            pDelete.Location = new Point(6, 175);
            pDelete.Name = "pDelete";
            pDelete.Size = new Size(741, 34);
            pDelete.TabIndex = 4;
            // 
            // tbDelete
            // 
            tbDelete.Location = new Point(119, 3);
            tbDelete.Multiline = true;
            tbDelete.Name = "tbDelete";
            tbDelete.ScrollBars = ScrollBars.Vertical;
            tbDelete.Size = new Size(619, 27);
            tbDelete.TabIndex = 1;
            // 
            // lDelete
            // 
            lDelete.AutoSize = true;
            lDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lDelete.Location = new Point(3, 0);
            lDelete.Name = "lDelete";
            lDelete.Size = new Size(72, 28);
            lDelete.TabIndex = 0;
            lDelete.Text = "Delete:";
            // 
            // pInsert
            // 
            pInsert.Controls.Add(tbInsert);
            pInsert.Controls.Add(lInsert);
            pInsert.Location = new Point(6, 100);
            pInsert.Name = "pInsert";
            pInsert.Size = new Size(741, 34);
            pInsert.TabIndex = 3;
            // 
            // tbInsert
            // 
            tbInsert.Location = new Point(119, 3);
            tbInsert.Multiline = true;
            tbInsert.Name = "tbInsert";
            tbInsert.ScrollBars = ScrollBars.Vertical;
            tbInsert.Size = new Size(619, 27);
            tbInsert.TabIndex = 1;
            // 
            // lInsert
            // 
            lInsert.AutoSize = true;
            lInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lInsert.Location = new Point(3, 0);
            lInsert.Name = "lInsert";
            lInsert.Size = new Size(64, 28);
            lInsert.TabIndex = 0;
            lInsert.Text = "Insert:";
            // 
            // pSelect
            // 
            pSelect.Controls.Add(tbSelect);
            pSelect.Controls.Add(lSelect);
            pSelect.Location = new Point(6, 26);
            pSelect.Name = "pSelect";
            pSelect.Size = new Size(741, 34);
            pSelect.TabIndex = 2;
            // 
            // tbSelect
            // 
            tbSelect.Location = new Point(119, 3);
            tbSelect.Multiline = true;
            tbSelect.Name = "tbSelect";
            tbSelect.ScrollBars = ScrollBars.Vertical;
            tbSelect.Size = new Size(619, 27);
            tbSelect.TabIndex = 1;
            // 
            // lSelect
            // 
            lSelect.AutoSize = true;
            lSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lSelect.Location = new Point(3, 0);
            lSelect.Name = "lSelect";
            lSelect.Size = new Size(68, 28);
            lSelect.TabIndex = 0;
            lSelect.Text = "Select:";
            // 
            // pRoleName
            // 
            pRoleName.Controls.Add(textBox4);
            pRoleName.Controls.Add(lRoleName);
            pRoleName.Location = new Point(6, 6);
            pRoleName.Name = "pRoleName";
            pRoleName.Size = new Size(393, 34);
            pRoleName.TabIndex = 1;
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
            // CreateForm
            // 
            AcceptButton = bCreate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bBack;
            ClientSize = new Size(800, 425);
            Controls.Add(panel1);
            Name = "CreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo mới";
            panel1.ResumeLayout(false);
            tcCreate.ResumeLayout(false);
            tpUser.ResumeLayout(false);
            pPower.ResumeLayout(false);
            pPower.PerformLayout();
            pId.ResumeLayout(false);
            pId.PerformLayout();
            pPosition.ResumeLayout(false);
            pPosition.PerformLayout();
            pFullName.ResumeLayout(false);
            pFullName.PerformLayout();
            pPhoneNumber.ResumeLayout(false);
            pPhoneNumber.PerformLayout();
            pRole.ResumeLayout(false);
            pRole.PerformLayout();
            pPassword.ResumeLayout(false);
            pPassword.PerformLayout();
            pUsername.ResumeLayout(false);
            pUsername.PerformLayout();
            tpRole.ResumeLayout(false);
            pPower2.ResumeLayout(false);
            pPower2.PerformLayout();
            gb.ResumeLayout(false);
            pDelete.ResumeLayout(false);
            pDelete.PerformLayout();
            pInsert.ResumeLayout(false);
            pInsert.PerformLayout();
            pSelect.ResumeLayout(false);
            pSelect.PerformLayout();
            pRoleName.ResumeLayout(false);
            pRoleName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private TabControl tcCreate;
        private TabPage tpUser;
        private TabPage tpRole;
        private Panel pPassword;
        private TextBox textBox1;
        private Label lPassword;
        private Panel pUsername;
        private TextBox tbUsername;
        private Label lUsername;
        private Panel pRole;
        private Label lRole;
        private Panel pPhoneNumber;
        private Label lPhoneNumber;
        private ComboBox cbRole;
        private TextBox tbPhoneNumber;
        private Panel pFullName;
        private TextBox tbFullName;
        private Label lFullName;
        private Panel pId;
        private TextBox textBox2;
        private Label lId;
        private Panel pPosition;
        private ComboBox cbPosition;
        private Label lPosition;
        private Panel pPower;
        private Label lPower;
        private Button bCreate;
        private Button bBack;
        private Panel pRoleName;
        private TextBox textBox4;
        private Label lRoleName;
        private Button bCreate2;
        private Button bBack2;
        private GroupBox gb;
        private Panel pInsert;
        private TextBox tbInsert;
        private Label lInsert;
        private Panel pSelect;
        private TextBox tbSelect;
        private Label lSelect;
        private Panel pDelete;
        private TextBox tbDelete;
        private Label lDelete;
        private CheckBox cbPower;
        private Panel pPower2;
        private CheckBox cbPower2;
        private Label lPower2;
    }
}
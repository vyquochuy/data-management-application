namespace QUANTRICSDL
{
    partial class UserRoleList
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            userListView = new ListView();
            tabPage2 = new TabPage();
            roleListView = new ListView();
            btnBack = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 435);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(773, 383);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(userListView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(765, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Người dùng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // userListView
            // 
            userListView.Location = new Point(0, 0);
            userListView.Name = "userListView";
            userListView.Size = new Size(766, 381);
            userListView.TabIndex = 0;
            userListView.UseCompatibleStateImageBehavior = false;
            userListView.SelectedIndexChanged += userListView_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(roleListView);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(762, 381);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vai trò";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // roleListView
            // 
            roleListView.Location = new Point(6, 6);
            roleListView.Name = "roleListView";
            roleListView.Size = new Size(753, 369);
            roleListView.TabIndex = 0;
            roleListView.UseCompatibleStateImageBehavior = false;
            roleListView.SelectedIndexChanged += roleListView_SelectedIndexChanged;
            // 
            // button1
            // 
            btnBack.Location = new Point(4, 5);
            btnBack.Name = "Back";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Back_Click;
            // 
            // UserRoleList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UserRoleList";
            Text = "UserRoleList";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView userListView;
        private TabPage tabPage2;
        private ListView roleListView;
        private Button btnBack;
    }
}
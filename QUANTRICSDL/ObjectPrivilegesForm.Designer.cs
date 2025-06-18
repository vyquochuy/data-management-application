using System.Windows.Forms;

namespace QUANTRICSDL
{
    partial class ObjectPrivilegesForm
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
            btnBack = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            tabPage2 = new TabPage();
            listView2 = new ListView();
            tabPage3 = new TabPage();
            listView3 = new ListView();
            tabPage4 = new TabPage();
            listView4 = new ListView();
            tabPage5 = new TabPage();
            listView5 = new ListView();
            tabPage6 = new TabPage();
            listView6 = new ListView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(10, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Back_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(3, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 377);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(762, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewDangKy
            // 
            listView1.Location = new Point(6, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(750, 332);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(762, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sinh viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 6);
            listView2.Name = "listView2";
            listView2.Size = new Size(750, 332);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(762, 347);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Đơn vị";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.Location = new Point(3, 6);
            listView3.Name = "listView3";
            listView3.Size = new Size(753, 335);
            listView3.TabIndex = 0;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listView4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(762, 347);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Học phần";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            listView4.Location = new Point(0, 6);
            listView4.Name = "listView4";
            listView4.Size = new Size(756, 332);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(listView5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(762, 347);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Môn học";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            listView5.Location = new Point(6, 6);
            listView5.Name = "listView5";
            listView5.Size = new Size(750, 332);
            listView5.TabIndex = 0;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(listView6);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(762, 347);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Đăng kí";
            tabPage6.UseVisualStyleBackColor = true;
            tabPage6.Click += tabPage6_Click;
            // 
            // listView6
            // 
            listView6.Location = new Point(6, 6);
            listView6.Name = "listView6";
            listView6.Size = new Size(750, 332);
            listView6.TabIndex = 0;
            listView6.UseCompatibleStateImageBehavior = false;
            // 
            // ObjectPrivilegesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ObjectPrivilegesForm";
            Text = "ObjectPrivilegesForm";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private ListView listView5;
        private ListView listView6;
    }
}
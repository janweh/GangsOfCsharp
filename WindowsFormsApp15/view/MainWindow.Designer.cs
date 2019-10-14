namespace WindowsFormsApp15.view
{
    partial class MainWindow
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.leftSidebarPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.contactButton = new System.Windows.Forms.Button();
            this.faqButton = new System.Windows.Forms.Button();
            this.tuitonFeesButton = new System.Windows.Forms.Button();
            this.universitiesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.topHeaderPanel = new System.Windows.Forms.Panel();
            this.openRatingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.bottomGangsOfCsharpPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.overallSearchPanel = new System.Windows.Forms.Panel();
            this.searchResultPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.professorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.universityComboBox = new System.Windows.Forms.ComboBox();
            this.leftSidebarPanel.SuspendLayout();
            this.topHeaderPanel.SuspendLayout();
            this.bottomGangsOfCsharpPanel.SuspendLayout();
            this.overallSearchPanel.SuspendLayout();
            this.searchResultPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSidebarPanel
            // 
            this.leftSidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftSidebarPanel.Controls.Add(this.logoPanel);
            this.leftSidebarPanel.Controls.Add(this.contactButton);
            this.leftSidebarPanel.Controls.Add(this.faqButton);
            this.leftSidebarPanel.Controls.Add(this.tuitonFeesButton);
            this.leftSidebarPanel.Controls.Add(this.universitiesButton);
            this.leftSidebarPanel.Controls.Add(this.homeButton);
            this.leftSidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidebarPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftSidebarPanel.Name = "leftSidebarPanel";
            this.leftSidebarPanel.Size = new System.Drawing.Size(300, 923);
            this.leftSidebarPanel.TabIndex = 0;
            this.leftSidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(300, 249);
            this.logoPanel.TabIndex = 2;
            this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // contactButton
            // 
            this.contactButton.FlatAppearance.BorderSize = 0;
            this.contactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contactButton.ForeColor = System.Drawing.Color.White;
            this.contactButton.Image = ((System.Drawing.Image)(resources.GetObject("contactButton.Image")));
            this.contactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactButton.Location = new System.Drawing.Point(39, 722);
            this.contactButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(237, 69);
            this.contactButton.TabIndex = 8;
            this.contactButton.Text = " CONTACT";
            this.contactButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contactButton.UseVisualStyleBackColor = true;
            // 
            // faqButton
            // 
            this.faqButton.FlatAppearance.BorderSize = 0;
            this.faqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faqButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faqButton.ForeColor = System.Drawing.Color.White;
            this.faqButton.Image = ((System.Drawing.Image)(resources.GetObject("faqButton.Image")));
            this.faqButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.faqButton.Location = new System.Drawing.Point(39, 618);
            this.faqButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(237, 69);
            this.faqButton.TabIndex = 7;
            this.faqButton.Text = " FAQ";
            this.faqButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.faqButton.UseVisualStyleBackColor = true;
            // 
            // tuitonFeesButton
            // 
            this.tuitonFeesButton.FlatAppearance.BorderSize = 0;
            this.tuitonFeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tuitonFeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tuitonFeesButton.ForeColor = System.Drawing.Color.White;
            this.tuitonFeesButton.Image = ((System.Drawing.Image)(resources.GetObject("tuitonFeesButton.Image")));
            this.tuitonFeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tuitonFeesButton.Location = new System.Drawing.Point(39, 509);
            this.tuitonFeesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tuitonFeesButton.Name = "tuitonFeesButton";
            this.tuitonFeesButton.Size = new System.Drawing.Size(254, 69);
            this.tuitonFeesButton.TabIndex = 6;
            this.tuitonFeesButton.Text = "TUITION FEES";
            this.tuitonFeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tuitonFeesButton.UseVisualStyleBackColor = true;
            // 
            // universitiesButton
            // 
            this.universitiesButton.FlatAppearance.BorderSize = 0;
            this.universitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.universitiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.universitiesButton.ForeColor = System.Drawing.Color.White;
            this.universitiesButton.Image = ((System.Drawing.Image)(resources.GetObject("universitiesButton.Image")));
            this.universitiesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.universitiesButton.Location = new System.Drawing.Point(39, 403);
            this.universitiesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.universitiesButton.Name = "universitiesButton";
            this.universitiesButton.Size = new System.Drawing.Size(254, 69);
            this.universitiesButton.TabIndex = 4;
            this.universitiesButton.Text = "UNIVERSITIES";
            this.universitiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.universitiesButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(39, 286);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(237, 69);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "HOME";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topHeaderPanel.Controls.Add(this.openRatingLabel);
            this.topHeaderPanel.Controls.Add(this.label2);
            this.topHeaderPanel.Controls.Add(this.label1);
            this.topHeaderPanel.Controls.Add(this.registerButton);
            this.topHeaderPanel.Controls.Add(this.loginButton);
            this.topHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeaderPanel.Location = new System.Drawing.Point(300, 0);
            this.topHeaderPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(900, 115);
            this.topHeaderPanel.TabIndex = 1;
            this.topHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopHeaderPanel_Paint);
            // 
            // openRatingLabel
            // 
            this.openRatingLabel.AutoSize = true;
            this.openRatingLabel.Location = new System.Drawing.Point(41, 53);
            this.openRatingLabel.Name = "openRatingLabel";
            this.openRatingLabel.Size = new System.Drawing.Size(99, 20);
            this.openRatingLabel.TabIndex = 5;
            this.openRatingLabel.Text = "Open Rating";
            this.openRatingLabel.Click += new System.EventHandler(this.OpenRatingLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(322, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Know Your University";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(345, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "KnowUni";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Silver;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.Location = new System.Drawing.Point(777, 43);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(105, 34);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "SIGN IN";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Silver;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Location = new System.Drawing.Point(650, 43);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(99, 34);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // bottomGangsOfCsharpPanel
            // 
            this.bottomGangsOfCsharpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomGangsOfCsharpPanel.Controls.Add(this.label8);
            this.bottomGangsOfCsharpPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomGangsOfCsharpPanel.Location = new System.Drawing.Point(300, 874);
            this.bottomGangsOfCsharpPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bottomGangsOfCsharpPanel.Name = "bottomGangsOfCsharpPanel";
            this.bottomGangsOfCsharpPanel.Size = new System.Drawing.Size(900, 49);
            this.bottomGangsOfCsharpPanel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(322, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Created by GANGS OF C#";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 26);
            this.textBox2.TabIndex = 0;
            // 
            // overallSearchPanel
            // 
            this.overallSearchPanel.Controls.Add(this.searchResultPanel);
            this.overallSearchPanel.Location = new System.Drawing.Point(300, 105);
            this.overallSearchPanel.Name = "overallSearchPanel";
            this.overallSearchPanel.Size = new System.Drawing.Size(900, 777);
            this.overallSearchPanel.TabIndex = 3;
            this.overallSearchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OverallSearchPanel_Paint);
            // 
            // searchResultPanel
            // 
            this.searchResultPanel.Controls.Add(this.searchPanel);
            this.searchResultPanel.Location = new System.Drawing.Point(8, 3);
            this.searchResultPanel.Name = "searchResultPanel";
            this.searchResultPanel.Size = new System.Drawing.Size(876, 758);
            this.searchResultPanel.TabIndex = 1;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.courseNameTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.professorComboBox);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.majorComboBox);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.universityComboBox);
            this.searchPanel.Location = new System.Drawing.Point(132, 82);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(644, 602);
            this.searchPanel.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(160, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(375, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Please select at least one field before Searching!";
            this.label9.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(178, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "QUICK SEARCHING";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(264, 292);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(250, 26);
            this.courseNameTextBox.TabIndex = 32;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.Location = new System.Drawing.Point(320, 411);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 48);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = " SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(84, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Professor :";
            // 
            // professorComboBox
            // 
            this.professorComboBox.FormattingEnabled = true;
            this.professorComboBox.Location = new System.Drawing.Point(264, 343);
            this.professorComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.professorComboBox.Name = "professorComboBox";
            this.professorComboBox.Size = new System.Drawing.Size(250, 28);
            this.professorComboBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(99, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Major :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Course Name :";
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(264, 240);
            this.majorComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(250, 28);
            this.majorComboBox.TabIndex = 26;
            this.majorComboBox.SelectedIndexChanged += new System.EventHandler(this.MajorComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "University Name :";
            // 
            // universityComboBox
            // 
            this.universityComboBox.FormattingEnabled = true;
            this.universityComboBox.Location = new System.Drawing.Point(264, 189);
            this.universityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.universityComboBox.Name = "universityComboBox";
            this.universityComboBox.Size = new System.Drawing.Size(250, 28);
            this.universityComboBox.TabIndex = 24;
            this.universityComboBox.SelectedIndexChanged += new System.EventHandler(this.UniversityComboBox_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 923);
            this.Controls.Add(this.overallSearchPanel);
            this.Controls.Add(this.bottomGangsOfCsharpPanel);
            this.Controls.Add(this.topHeaderPanel);
            this.Controls.Add(this.leftSidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftSidebarPanel.ResumeLayout(false);
            this.topHeaderPanel.ResumeLayout(false);
            this.topHeaderPanel.PerformLayout();
            this.bottomGangsOfCsharpPanel.ResumeLayout(false);
            this.bottomGangsOfCsharpPanel.PerformLayout();
            this.overallSearchPanel.ResumeLayout(false);
            this.searchResultPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSidebarPanel;
        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel bottomGangsOfCsharpPanel;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button faqButton;
        private System.Windows.Forms.Button tuitonFeesButton;
        private System.Windows.Forms.Button universitiesButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel overallSearchPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel searchResultPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox professorComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox universityComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label openRatingLabel;
    }
}


namespace WindowsFormsApp15.view
{
    partial class RatingCourseWindow
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblOverallRating = new System.Windows.Forms.Label();
            this.lblContactHours = new System.Windows.Forms.Label();
            this.lblSelfStudyHours = new System.Windows.Forms.Label();
            this.lblHowOrganized = new System.Windows.Forms.Label();
            this.lblHowMuchLearned = new System.Windows.Forms.Label();
            this.lblHowInterested = new System.Windows.Forms.Label();
            this.lblHowPresented = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxComments = new System.Windows.Forms.RichTextBox();
            this.nupdContactHours = new System.Windows.Forms.NumericUpDown();
            this.nupdSelfStudyHours = new System.Windows.Forms.NumericUpDown();
            this.Rate1 = new System.Windows.Forms.Label();
            this.Rate2 = new System.Windows.Forms.Label();
            this.Rate3 = new System.Windows.Forms.Label();
            this.Rate4 = new System.Windows.Forms.Label();
            this.Rate5 = new System.Windows.Forms.Label();
            this.RatingOrganized1 = new System.Windows.Forms.CheckBox();
            this.RatingOrganized2 = new System.Windows.Forms.CheckBox();
            this.RatingOrganized3 = new System.Windows.Forms.CheckBox();
            this.RatingOrganized4 = new System.Windows.Forms.CheckBox();
            this.RatingOrganized5 = new System.Windows.Forms.CheckBox();
            this.RatingLearned5 = new System.Windows.Forms.CheckBox();
            this.RatingLearned4 = new System.Windows.Forms.CheckBox();
            this.RatingLearned3 = new System.Windows.Forms.CheckBox();
            this.RatingLearned2 = new System.Windows.Forms.CheckBox();
            this.RatingLearned1 = new System.Windows.Forms.CheckBox();
            this.RatingInterested5 = new System.Windows.Forms.CheckBox();
            this.RatingInterested4 = new System.Windows.Forms.CheckBox();
            this.RatingInterested3 = new System.Windows.Forms.CheckBox();
            this.RatingInterested2 = new System.Windows.Forms.CheckBox();
            this.RatingInterested1 = new System.Windows.Forms.CheckBox();
            this.RatingPresent5 = new System.Windows.Forms.CheckBox();
            this.RatingPresent4 = new System.Windows.Forms.CheckBox();
            this.RatingPresent3 = new System.Windows.Forms.CheckBox();
            this.RatingPresent2 = new System.Windows.Forms.CheckBox();
            this.RatingPresent1 = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbBoxSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupdContactHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSelfStudyHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseName.Location = new System.Drawing.Point(25, 22);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(110, 16);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name :";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniversity.Location = new System.Drawing.Point(25, 52);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(59, 13);
            this.lblUniversity.TabIndex = 1;
            this.lblUniversity.Text = "University :";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBy.Location = new System.Drawing.Point(25, 77);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(25, 13);
            this.lblBy.TabIndex = 2;
            this.lblBy.Text = "By :";
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSince.Location = new System.Drawing.Point(25, 100);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(40, 13);
            this.lblSince.TabIndex = 3;
            this.lblSince.Text = "Since :";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSemester.Location = new System.Drawing.Point(25, 144);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(165, 13);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "When did you attend the course?";
            // 
            // lblOverallRating
            // 
            this.lblOverallRating.AutoSize = true;
            this.lblOverallRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOverallRating.Location = new System.Drawing.Point(25, 182);
            this.lblOverallRating.Name = "lblOverallRating";
            this.lblOverallRating.Size = new System.Drawing.Size(75, 13);
            this.lblOverallRating.TabIndex = 6;
            this.lblOverallRating.Text = "Overall rating :";
            // 
            // lblContactHours
            // 
            this.lblContactHours.AutoSize = true;
            this.lblContactHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContactHours.Location = new System.Drawing.Point(25, 213);
            this.lblContactHours.Name = "lblContactHours";
            this.lblContactHours.Size = new System.Drawing.Size(123, 13);
            this.lblContactHours.TabIndex = 8;
            this.lblContactHours.Text = "Contact hours per week:";
            // 
            // lblSelfStudyHours
            // 
            this.lblSelfStudyHours.AutoSize = true;
            this.lblSelfStudyHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelfStudyHours.Location = new System.Drawing.Point(25, 247);
            this.lblSelfStudyHours.Name = "lblSelfStudyHours";
            this.lblSelfStudyHours.Size = new System.Drawing.Size(132, 13);
            this.lblSelfStudyHours.TabIndex = 9;
            this.lblSelfStudyHours.Text = "Self-study hours per week:";
            // 
            // lblHowOrganized
            // 
            this.lblHowOrganized.AutoSize = true;
            this.lblHowOrganized.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHowOrganized.Location = new System.Drawing.Point(25, 300);
            this.lblHowOrganized.Name = "lblHowOrganized";
            this.lblHowOrganized.Size = new System.Drawing.Size(158, 13);
            this.lblHowOrganized.TabIndex = 10;
            this.lblHowOrganized.Text = "How well the course organized?";
            // 
            // lblHowMuchLearned
            // 
            this.lblHowMuchLearned.AutoSize = true;
            this.lblHowMuchLearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHowMuchLearned.Location = new System.Drawing.Point(25, 325);
            this.lblHowMuchLearned.Name = "lblHowMuchLearned";
            this.lblHowMuchLearned.Size = new System.Drawing.Size(195, 13);
            this.lblHowMuchLearned.TabIndex = 11;
            this.lblHowMuchLearned.Text = "How much did you learn on the course?";
            // 
            // lblHowInterested
            // 
            this.lblHowInterested.AutoSize = true;
            this.lblHowInterested.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHowInterested.Location = new System.Drawing.Point(25, 356);
            this.lblHowInterested.Name = "lblHowInterested";
            this.lblHowInterested.Size = new System.Drawing.Size(196, 13);
            this.lblHowInterested.TabIndex = 12;
            this.lblHowInterested.Text = "How interesting did you find the course?";
            // 
            // lblHowPresented
            // 
            this.lblHowPresented.AutoSize = true;
            this.lblHowPresented.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHowPresented.Location = new System.Drawing.Point(25, 382);
            this.lblHowPresented.Name = "lblHowPresented";
            this.lblHowPresented.Size = new System.Drawing.Size(229, 13);
            this.lblHowPresented.TabIndex = 13;
            this.lblHowPresented.Text = "How well did the lecturer present the contents?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(25, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Comments :";
            // 
            // txtBoxComments
            // 
            this.txtBoxComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxComments.Location = new System.Drawing.Point(28, 463);
            this.txtBoxComments.Name = "txtBoxComments";
            this.txtBoxComments.Size = new System.Drawing.Size(513, 96);
            this.txtBoxComments.TabIndex = 15;
            this.txtBoxComments.Text = "";
            // 
            // nupdContactHours
            // 
            this.nupdContactHours.Location = new System.Drawing.Point(212, 211);
            this.nupdContactHours.Name = "nupdContactHours";
            this.nupdContactHours.Size = new System.Drawing.Size(34, 20);
            this.nupdContactHours.TabIndex = 16;
            // 
            // nupdSelfStudyHours
            // 
            this.nupdSelfStudyHours.Location = new System.Drawing.Point(212, 240);
            this.nupdSelfStudyHours.Name = "nupdSelfStudyHours";
            this.nupdSelfStudyHours.Size = new System.Drawing.Size(34, 20);
            this.nupdSelfStudyHours.TabIndex = 17;
            // 
            // Rate1
            // 
            this.Rate1.AutoSize = true;
            this.Rate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rate1.Location = new System.Drawing.Point(270, 271);
            this.Rate1.Name = "Rate1";
            this.Rate1.Size = new System.Drawing.Size(14, 13);
            this.Rate1.TabIndex = 18;
            this.Rate1.Text = "1";
            // 
            // Rate2
            // 
            this.Rate2.AutoSize = true;
            this.Rate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rate2.Location = new System.Drawing.Point(299, 271);
            this.Rate2.Name = "Rate2";
            this.Rate2.Size = new System.Drawing.Size(14, 13);
            this.Rate2.TabIndex = 19;
            this.Rate2.Text = "2";
            // 
            // Rate3
            // 
            this.Rate3.AutoSize = true;
            this.Rate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rate3.Location = new System.Drawing.Point(329, 271);
            this.Rate3.Name = "Rate3";
            this.Rate3.Size = new System.Drawing.Size(14, 13);
            this.Rate3.TabIndex = 20;
            this.Rate3.Text = "3";
            // 
            // Rate4
            // 
            this.Rate4.AutoSize = true;
            this.Rate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rate4.Location = new System.Drawing.Point(358, 271);
            this.Rate4.Name = "Rate4";
            this.Rate4.Size = new System.Drawing.Size(14, 13);
            this.Rate4.TabIndex = 21;
            this.Rate4.Text = "4";
            // 
            // Rate5
            // 
            this.Rate5.AutoSize = true;
            this.Rate5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rate5.Location = new System.Drawing.Point(387, 271);
            this.Rate5.Name = "Rate5";
            this.Rate5.Size = new System.Drawing.Size(14, 13);
            this.Rate5.TabIndex = 22;
            this.Rate5.Text = "5";
            // 
            // RatingOrganized1
            // 
            this.RatingOrganized1.AutoSize = true;
            this.RatingOrganized1.Location = new System.Drawing.Point(273, 301);
            this.RatingOrganized1.Name = "RatingOrganized1";
            this.RatingOrganized1.Size = new System.Drawing.Size(15, 14);
            this.RatingOrganized1.TabIndex = 28;
            this.RatingOrganized1.UseVisualStyleBackColor = true;
            // 
            // RatingOrganized2
            // 
            this.RatingOrganized2.AutoSize = true;
            this.RatingOrganized2.Location = new System.Drawing.Point(302, 301);
            this.RatingOrganized2.Name = "RatingOrganized2";
            this.RatingOrganized2.Size = new System.Drawing.Size(15, 14);
            this.RatingOrganized2.TabIndex = 29;
            this.RatingOrganized2.UseVisualStyleBackColor = true;
            // 
            // RatingOrganized3
            // 
            this.RatingOrganized3.AutoSize = true;
            this.RatingOrganized3.Location = new System.Drawing.Point(332, 301);
            this.RatingOrganized3.Name = "RatingOrganized3";
            this.RatingOrganized3.Size = new System.Drawing.Size(15, 14);
            this.RatingOrganized3.TabIndex = 30;
            this.RatingOrganized3.UseVisualStyleBackColor = true;
            // 
            // RatingOrganized4
            // 
            this.RatingOrganized4.AutoSize = true;
            this.RatingOrganized4.Location = new System.Drawing.Point(361, 301);
            this.RatingOrganized4.Name = "RatingOrganized4";
            this.RatingOrganized4.Size = new System.Drawing.Size(15, 14);
            this.RatingOrganized4.TabIndex = 31;
            this.RatingOrganized4.UseVisualStyleBackColor = true;
            // 
            // RatingOrganized5
            // 
            this.RatingOrganized5.AutoSize = true;
            this.RatingOrganized5.Location = new System.Drawing.Point(390, 301);
            this.RatingOrganized5.Name = "RatingOrganized5";
            this.RatingOrganized5.Size = new System.Drawing.Size(15, 14);
            this.RatingOrganized5.TabIndex = 32;
            this.RatingOrganized5.UseVisualStyleBackColor = true;
            // 
            // RatingLearned5
            // 
            this.RatingLearned5.AutoSize = true;
            this.RatingLearned5.Location = new System.Drawing.Point(390, 325);
            this.RatingLearned5.Name = "RatingLearned5";
            this.RatingLearned5.Size = new System.Drawing.Size(15, 14);
            this.RatingLearned5.TabIndex = 42;
            this.RatingLearned5.UseVisualStyleBackColor = true;
            // 
            // RatingLearned4
            // 
            this.RatingLearned4.AutoSize = true;
            this.RatingLearned4.Location = new System.Drawing.Point(361, 325);
            this.RatingLearned4.Name = "RatingLearned4";
            this.RatingLearned4.Size = new System.Drawing.Size(15, 14);
            this.RatingLearned4.TabIndex = 41;
            this.RatingLearned4.UseVisualStyleBackColor = true;
            // 
            // RatingLearned3
            // 
            this.RatingLearned3.AutoSize = true;
            this.RatingLearned3.Location = new System.Drawing.Point(332, 325);
            this.RatingLearned3.Name = "RatingLearned3";
            this.RatingLearned3.Size = new System.Drawing.Size(15, 14);
            this.RatingLearned3.TabIndex = 40;
            this.RatingLearned3.UseVisualStyleBackColor = true;
            // 
            // RatingLearned2
            // 
            this.RatingLearned2.AutoSize = true;
            this.RatingLearned2.Location = new System.Drawing.Point(302, 325);
            this.RatingLearned2.Name = "RatingLearned2";
            this.RatingLearned2.Size = new System.Drawing.Size(15, 14);
            this.RatingLearned2.TabIndex = 39;
            this.RatingLearned2.UseVisualStyleBackColor = true;
            // 
            // RatingLearned1
            // 
            this.RatingLearned1.AutoSize = true;
            this.RatingLearned1.Location = new System.Drawing.Point(273, 325);
            this.RatingLearned1.Name = "RatingLearned1";
            this.RatingLearned1.Size = new System.Drawing.Size(15, 14);
            this.RatingLearned1.TabIndex = 38;
            this.RatingLearned1.UseVisualStyleBackColor = true;
            // 
            // RatingInterested5
            // 
            this.RatingInterested5.AutoSize = true;
            this.RatingInterested5.Location = new System.Drawing.Point(390, 355);
            this.RatingInterested5.Name = "RatingInterested5";
            this.RatingInterested5.Size = new System.Drawing.Size(15, 14);
            this.RatingInterested5.TabIndex = 52;
            this.RatingInterested5.UseVisualStyleBackColor = true;
            // 
            // RatingInterested4
            // 
            this.RatingInterested4.AutoSize = true;
            this.RatingInterested4.Location = new System.Drawing.Point(361, 355);
            this.RatingInterested4.Name = "RatingInterested4";
            this.RatingInterested4.Size = new System.Drawing.Size(15, 14);
            this.RatingInterested4.TabIndex = 51;
            this.RatingInterested4.UseVisualStyleBackColor = true;
            // 
            // RatingInterested3
            // 
            this.RatingInterested3.AutoSize = true;
            this.RatingInterested3.Location = new System.Drawing.Point(332, 355);
            this.RatingInterested3.Name = "RatingInterested3";
            this.RatingInterested3.Size = new System.Drawing.Size(15, 14);
            this.RatingInterested3.TabIndex = 50;
            this.RatingInterested3.UseVisualStyleBackColor = true;
            // 
            // RatingInterested2
            // 
            this.RatingInterested2.AutoSize = true;
            this.RatingInterested2.Location = new System.Drawing.Point(302, 355);
            this.RatingInterested2.Name = "RatingInterested2";
            this.RatingInterested2.Size = new System.Drawing.Size(15, 14);
            this.RatingInterested2.TabIndex = 49;
            this.RatingInterested2.UseVisualStyleBackColor = true;
            // 
            // RatingInterested1
            // 
            this.RatingInterested1.AutoSize = true;
            this.RatingInterested1.Location = new System.Drawing.Point(273, 355);
            this.RatingInterested1.Name = "RatingInterested1";
            this.RatingInterested1.Size = new System.Drawing.Size(15, 14);
            this.RatingInterested1.TabIndex = 48;
            this.RatingInterested1.UseVisualStyleBackColor = true;
            // 
            // RatingPresent5
            // 
            this.RatingPresent5.AutoSize = true;
            this.RatingPresent5.Location = new System.Drawing.Point(390, 382);
            this.RatingPresent5.Name = "RatingPresent5";
            this.RatingPresent5.Size = new System.Drawing.Size(15, 14);
            this.RatingPresent5.TabIndex = 62;
            this.RatingPresent5.UseVisualStyleBackColor = true;
            // 
            // RatingPresent4
            // 
            this.RatingPresent4.AutoSize = true;
            this.RatingPresent4.Location = new System.Drawing.Point(361, 382);
            this.RatingPresent4.Name = "RatingPresent4";
            this.RatingPresent4.Size = new System.Drawing.Size(15, 14);
            this.RatingPresent4.TabIndex = 61;
            this.RatingPresent4.UseVisualStyleBackColor = true;
            // 
            // RatingPresent3
            // 
            this.RatingPresent3.AutoSize = true;
            this.RatingPresent3.Location = new System.Drawing.Point(332, 382);
            this.RatingPresent3.Name = "RatingPresent3";
            this.RatingPresent3.Size = new System.Drawing.Size(15, 14);
            this.RatingPresent3.TabIndex = 60;
            this.RatingPresent3.UseVisualStyleBackColor = true;
            // 
            // RatingPresent2
            // 
            this.RatingPresent2.AutoSize = true;
            this.RatingPresent2.Location = new System.Drawing.Point(302, 382);
            this.RatingPresent2.Name = "RatingPresent2";
            this.RatingPresent2.Size = new System.Drawing.Size(15, 14);
            this.RatingPresent2.TabIndex = 59;
            this.RatingPresent2.UseVisualStyleBackColor = true;
            // 
            // RatingPresent1
            // 
            this.RatingPresent1.AutoSize = true;
            this.RatingPresent1.Location = new System.Drawing.Point(273, 382);
            this.RatingPresent1.Name = "RatingPresent1";
            this.RatingPresent1.Size = new System.Drawing.Size(15, 14);
            this.RatingPresent1.TabIndex = 58;
            this.RatingPresent1.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(420, 583);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 68;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // cmbBoxSemester
            // 
            this.cmbBoxSemester.FormattingEnabled = true;
            this.cmbBoxSemester.Location = new System.Drawing.Point(212, 141);
            this.cmbBoxSemester.Name = "cmbBoxSemester";
            this.cmbBoxSemester.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSemester.TabIndex = 69;
            // 
            // RatingCourseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(569, 618);
            this.Controls.Add(this.cmbBoxSemester);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.RatingPresent5);
            this.Controls.Add(this.RatingPresent4);
            this.Controls.Add(this.RatingPresent3);
            this.Controls.Add(this.RatingPresent2);
            this.Controls.Add(this.RatingPresent1);
            this.Controls.Add(this.RatingInterested5);
            this.Controls.Add(this.RatingInterested4);
            this.Controls.Add(this.RatingInterested3);
            this.Controls.Add(this.RatingInterested2);
            this.Controls.Add(this.RatingInterested1);
            this.Controls.Add(this.RatingLearned5);
            this.Controls.Add(this.RatingLearned4);
            this.Controls.Add(this.RatingLearned3);
            this.Controls.Add(this.RatingLearned2);
            this.Controls.Add(this.RatingLearned1);
            this.Controls.Add(this.RatingOrganized5);
            this.Controls.Add(this.RatingOrganized4);
            this.Controls.Add(this.RatingOrganized3);
            this.Controls.Add(this.RatingOrganized2);
            this.Controls.Add(this.RatingOrganized1);
            this.Controls.Add(this.Rate5);
            this.Controls.Add(this.Rate4);
            this.Controls.Add(this.Rate3);
            this.Controls.Add(this.Rate2);
            this.Controls.Add(this.Rate1);
            this.Controls.Add(this.nupdSelfStudyHours);
            this.Controls.Add(this.nupdContactHours);
            this.Controls.Add(this.txtBoxComments);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblHowPresented);
            this.Controls.Add(this.lblHowInterested);
            this.Controls.Add(this.lblHowMuchLearned);
            this.Controls.Add(this.lblHowOrganized);
            this.Controls.Add(this.lblSelfStudyHours);
            this.Controls.Add(this.lblContactHours);
            this.Controls.Add(this.lblOverallRating);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.lblCourseName);
            this.Name = "RatingCourseWindow";
            this.Text = "RatingCourseWindow";
            ((System.ComponentModel.ISupportInitialize)(this.nupdContactHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSelfStudyHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblOverallRating;
        private System.Windows.Forms.Label lblContactHours;
        private System.Windows.Forms.Label lblSelfStudyHours;
        private System.Windows.Forms.Label lblHowOrganized;
        private System.Windows.Forms.Label lblHowMuchLearned;
        private System.Windows.Forms.Label lblHowInterested;
        private System.Windows.Forms.Label lblHowPresented;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtBoxComments;
        private System.Windows.Forms.NumericUpDown nupdContactHours;
        private System.Windows.Forms.NumericUpDown nupdSelfStudyHours;
        private System.Windows.Forms.Label Rate1;
        private System.Windows.Forms.Label Rate2;
        private System.Windows.Forms.Label Rate3;
        private System.Windows.Forms.Label Rate4;
        private System.Windows.Forms.Label Rate5;
        private System.Windows.Forms.CheckBox RatingOrganized1;
        private System.Windows.Forms.CheckBox RatingOrganized2;
        private System.Windows.Forms.CheckBox RatingOrganized3;
        private System.Windows.Forms.CheckBox RatingOrganized4;
        private System.Windows.Forms.CheckBox RatingOrganized5;
        private System.Windows.Forms.CheckBox RatingLearned5;
        private System.Windows.Forms.CheckBox RatingLearned4;
        private System.Windows.Forms.CheckBox RatingLearned3;
        private System.Windows.Forms.CheckBox RatingLearned2;
        private System.Windows.Forms.CheckBox RatingLearned1;
        private System.Windows.Forms.CheckBox RatingInterested5;
        private System.Windows.Forms.CheckBox RatingInterested4;
        private System.Windows.Forms.CheckBox RatingInterested3;
        private System.Windows.Forms.CheckBox RatingInterested2;
        private System.Windows.Forms.CheckBox RatingInterested1;
        private System.Windows.Forms.CheckBox RatingPresent5;
        private System.Windows.Forms.CheckBox RatingPresent4;
        private System.Windows.Forms.CheckBox RatingPresent3;
        private System.Windows.Forms.CheckBox RatingPresent2;
        private System.Windows.Forms.CheckBox RatingPresent1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbBoxSemester;
    }
}
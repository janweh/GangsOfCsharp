namespace WindowsFormsApp15.view
{
    partial class MajorSearchResultWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.University = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfProfessors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 547);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.University,
            this.Rating,
            this.NumberOfCourses,
            this.NumberOfMajors,
            this.NumberOfProfessors});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 484);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // University
            // 
            this.University.HeaderText = "University";
            this.University.MinimumWidth = 8;
            this.University.Name = "University";
            this.University.Width = 150;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 8;
            this.Rating.Name = "Rating";
            this.Rating.Width = 150;
            // 
            // NumberOfCourses
            // 
            this.NumberOfCourses.HeaderText = "Number of Courses";
            this.NumberOfCourses.MinimumWidth = 8;
            this.NumberOfCourses.Name = "NumberOfCourses";
            this.NumberOfCourses.Width = 150;
            // 
            // NumberOfMajors
            // 
            this.NumberOfMajors.HeaderText = "Number of Majors";
            this.NumberOfMajors.MinimumWidth = 8;
            this.NumberOfMajors.Name = "NumberOfMajors";
            this.NumberOfMajors.Width = 150;
            // 
            // NumberOfProfessors
            // 
            this.NumberOfProfessors.HeaderText = "Number of Professors";
            this.NumberOfProfessors.MinimumWidth = 8;
            this.NumberOfProfessors.Name = "NumberOfProfessors";
            this.NumberOfProfessors.Width = 150;
            // 
            // MajorSearchResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panel1);
            this.Name = "MajorSearchResultWindow";
            this.Text = "MajorSearchResultWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewLinkColumn University;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfMajors;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProfessors;
    }
}
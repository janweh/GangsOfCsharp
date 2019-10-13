namespace WindowsFormsApp15.view
{
    partial class CourseNameSearchResultWindow
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
            this.keywordLabel = new System.Windows.Forms.Label();
            this.numberResultsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfRatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordLabel.Location = new System.Drawing.Point(0, 9);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(100, 37);
            this.keywordLabel.TabIndex = 0;
            this.keywordLabel.Text = "label1";
            // 
            // numberResultsLabel
            // 
            this.numberResultsLabel.AutoSize = true;
            this.numberResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberResultsLabel.Location = new System.Drawing.Point(686, 9);
            this.numberResultsLabel.Name = "numberResultsLabel";
            this.numberResultsLabel.Size = new System.Drawing.Size(102, 37);
            this.numberResultsLabel.TabIndex = 1;
            this.numberResultsLabel.Text = "label2";
            this.numberResultsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Rating,
            this.NumberOfRatings,
            this.Lecturer});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(804, 392);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 8;
            this.Course.Name = "Course";
            this.Course.Width = 150;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 8;
            this.Rating.Name = "Rating";
            this.Rating.Width = 150;
            // 
            // NumberOfRatings
            // 
            this.NumberOfRatings.HeaderText = "Number of Ratings";
            this.NumberOfRatings.MinimumWidth = 8;
            this.NumberOfRatings.Name = "NumberOfRatings";
            this.NumberOfRatings.Width = 150;
            // 
            // Lecturer
            // 
            this.Lecturer.HeaderText = "Lecturer";
            this.Lecturer.MinimumWidth = 8;
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Width = 150;
            // 
            // CourseNameSearchResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numberResultsLabel);
            this.Controls.Add(this.keywordLabel);
            this.Name = "CourseNameSearchResultWindow";
            this.Text = "CourseNameSearchResultWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.Label numberResultsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfRatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lecturer;
    }
}
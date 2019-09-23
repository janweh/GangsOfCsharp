namespace WindowsFormsApp15.view
{
    partial class UniSearchResultWindow
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MajorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverallRatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfCoursesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfProfessorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 547);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MajorColumn,
            this.OverallRatingColumn,
            this.NumberOfCoursesColumn,
            this.NumberOfProfessorsColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 484);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(837, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(WindowsFormsApp15.model.Major);
            // 
            // MajorColumn
            // 
            this.MajorColumn.DataPropertyName = "majors.Name";
            this.MajorColumn.HeaderText = "Major";
            this.MajorColumn.MinimumWidth = 8;
            this.MajorColumn.Name = "MajorColumn";
            this.MajorColumn.Width = 150;
            // 
            // OverallRatingColumn
            // 
            this.OverallRatingColumn.HeaderText = "Rating";
            this.OverallRatingColumn.MinimumWidth = 8;
            this.OverallRatingColumn.Name = "OverallRatingColumn";
            this.OverallRatingColumn.Width = 150;
            // 
            // NumberOfCoursesColumn
            // 
            this.NumberOfCoursesColumn.HeaderText = "Number of Courses";
            this.NumberOfCoursesColumn.MinimumWidth = 8;
            this.NumberOfCoursesColumn.Name = "NumberOfCoursesColumn";
            this.NumberOfCoursesColumn.Width = 150;
            // 
            // NumberOfProfessorsColumn
            // 
            this.NumberOfProfessorsColumn.HeaderText = "Number of Professors";
            this.NumberOfProfessorsColumn.MinimumWidth = 8;
            this.NumberOfProfessorsColumn.Name = "NumberOfProfessorsColumn";
            this.NumberOfProfessorsColumn.Width = 150;
            // 
            // UniSearchResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panel1);
            this.Name = "UniSearchResultWindow";
            this.Text = "UniSearchResultWindow";
            this.Load += new System.EventHandler(this.UniSearchResultWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverallRatingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCoursesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProfessorsColumn;
    }
}
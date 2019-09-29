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
            this.dataGridView1.Location = new System.Drawing.Point(-2, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(804, 392);
            this.dataGridView1.TabIndex = 2;
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
    }
}
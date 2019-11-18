namespace WindowsFormsApp15.view
{
    partial class CourseViewWindow
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
            this.dataVizualisation1 = new WindowsFormsApp15.view.DataVizualisation();
            this.detailedCourseStatistics1 = new WindowsFormsApp15.view.DetailedCourseStatistics();
            this.SuspendLayout();
            // 
            // dataVizualisation1
            // 
            this.dataVizualisation1.AutoScroll = true;
            this.dataVizualisation1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataVizualisation1.Location = new System.Drawing.Point(1, -1);
            this.dataVizualisation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataVizualisation1.Name = "dataVizualisation1";
            this.dataVizualisation1.Size = new System.Drawing.Size(850, 3000);
            this.dataVizualisation1.TabIndex = 1;
            this.dataVizualisation1.Visible = false;
            // 
            // detailedCourseStatistics1
            // 
            this.detailedCourseStatistics1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.detailedCourseStatistics1.Location = new System.Drawing.Point(-9, -1);
            this.detailedCourseStatistics1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.detailedCourseStatistics1.Name = "detailedCourseStatistics1";
            this.detailedCourseStatistics1.Size = new System.Drawing.Size(686, 692);
            this.detailedCourseStatistics1.TabIndex = 0;
            // 
            // CourseViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.dataVizualisation1);
            this.Controls.Add(this.detailedCourseStatistics1);
            this.Name = "CourseViewWindow";
            this.Text = "CourseViewWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private DetailedCourseStatistics detailedCourseStatistics1;
        private DataVizualisation dataVizualisation1;
    }
}
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
            this.dataVizualisation1.Location = new System.Drawing.Point(2, -1);
            this.dataVizualisation1.Name = "dataVizualisation1";
            this.dataVizualisation1.Size = new System.Drawing.Size(1014, 824);
            this.dataVizualisation1.TabIndex = 1;
            this.dataVizualisation1.Visible = false;
            // 
            // detailedCourseStatistics1
            // 
            this.detailedCourseStatistics1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.detailedCourseStatistics1.Location = new System.Drawing.Point(-13, -1);
            this.detailedCourseStatistics1.Name = "detailedCourseStatistics1";
            this.detailedCourseStatistics1.Size = new System.Drawing.Size(1029, 1065);
            this.detailedCourseStatistics1.TabIndex = 0;
            // 
            // CourseViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1016, 820);
            this.Controls.Add(this.dataVizualisation1);
            this.Controls.Add(this.detailedCourseStatistics1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CourseViewWindow";
            this.Text = "CourseViewWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private DetailedCourseStatistics detailedCourseStatistics1;
        private DataVizualisation dataVizualisation1;
    }
}
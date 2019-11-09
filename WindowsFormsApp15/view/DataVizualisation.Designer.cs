namespace WindowsFormsApp15.view
{
    partial class DataVizualisation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overallRatingPanel = new System.Windows.Forms.Panel();
            this.varianceOverallRatingLabel = new System.Windows.Forms.Label();
            this.medianOverallRatingLabel = new System.Windows.Forms.Label();
            this.mostCommonOverallRatingLabel = new System.Windows.Forms.Label();
            this.averageOverallRatingLabel = new System.Windows.Forms.Label();
            this.overallRatingChart = new LiveCharts.WinForms.CartesianChart();
            this.overallRatingLabel = new System.Windows.Forms.Label();
            this.numberOfRatingsLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.organizedRatingPanel = new System.Windows.Forms.Panel();
            this.varianceOrganizedRatingLabel = new System.Windows.Forms.Label();
            this.medianOrganizedRatingLabel = new System.Windows.Forms.Label();
            this.mostCommonOrganizedRatingLabel = new System.Windows.Forms.Label();
            this.averageOrganizedRatingLabel = new System.Windows.Forms.Label();
            this.organizedRatingChart = new LiveCharts.WinForms.CartesianChart();
            this.organizedRatingLabel = new System.Windows.Forms.Label();
            this.interestingRatingPanel = new System.Windows.Forms.Panel();
            this.varianceInterestingRatingLabel = new System.Windows.Forms.Label();
            this.medianInterestingRatingLabel = new System.Windows.Forms.Label();
            this.mostCommonInterestingRatingLabel = new System.Windows.Forms.Label();
            this.averageInterestingRatingLabel = new System.Windows.Forms.Label();
            this.interestingRatingChart = new LiveCharts.WinForms.CartesianChart();
            this.interestingRatingLabel = new System.Windows.Forms.Label();
            this.presentedRatingPanel = new System.Windows.Forms.Panel();
            this.variancePresentedRatingLabel = new System.Windows.Forms.Label();
            this.medianPresentedRatingLabel = new System.Windows.Forms.Label();
            this.mostCommonPresentedRatingLabel = new System.Windows.Forms.Label();
            this.averagePresentedRatingLabel = new System.Windows.Forms.Label();
            this.presentedRatingChart = new LiveCharts.WinForms.CartesianChart();
            this.presentedRatingLabel = new System.Windows.Forms.Label();
            this.learnedRatingPanel = new System.Windows.Forms.Panel();
            this.varianceLearnedRatingLabel = new System.Windows.Forms.Label();
            this.medianLearnedRatingLabel = new System.Windows.Forms.Label();
            this.mostCommonLearnedRatingLabel = new System.Windows.Forms.Label();
            this.averageLearnedRatingLabel = new System.Windows.Forms.Label();
            this.learnedRatingChart = new LiveCharts.WinForms.CartesianChart();
            this.learnedRatingLabel = new System.Windows.Forms.Label();
            this.overallRatingPanel.SuspendLayout();
            this.organizedRatingPanel.SuspendLayout();
            this.interestingRatingPanel.SuspendLayout();
            this.presentedRatingPanel.SuspendLayout();
            this.learnedRatingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // overallRatingPanel
            // 
            this.overallRatingPanel.Controls.Add(this.varianceOverallRatingLabel);
            this.overallRatingPanel.Controls.Add(this.medianOverallRatingLabel);
            this.overallRatingPanel.Controls.Add(this.mostCommonOverallRatingLabel);
            this.overallRatingPanel.Controls.Add(this.averageOverallRatingLabel);
            this.overallRatingPanel.Controls.Add(this.overallRatingChart);
            this.overallRatingPanel.Controls.Add(this.overallRatingLabel);
            this.overallRatingPanel.Location = new System.Drawing.Point(19, 54);
            this.overallRatingPanel.Name = "overallRatingPanel";
            this.overallRatingPanel.Size = new System.Drawing.Size(802, 407);
            this.overallRatingPanel.TabIndex = 5;
            // 
            // varianceOverallRatingLabel
            // 
            this.varianceOverallRatingLabel.AutoSize = true;
            this.varianceOverallRatingLabel.Location = new System.Drawing.Point(537, 170);
            this.varianceOverallRatingLabel.Name = "varianceOverallRatingLabel";
            this.varianceOverallRatingLabel.Size = new System.Drawing.Size(76, 20);
            this.varianceOverallRatingLabel.TabIndex = 5;
            this.varianceOverallRatingLabel.Text = "Variance:";
            // 
            // medianOverallRatingLabel
            // 
            this.medianOverallRatingLabel.AutoSize = true;
            this.medianOverallRatingLabel.Location = new System.Drawing.Point(537, 130);
            this.medianOverallRatingLabel.Name = "medianOverallRatingLabel";
            this.medianOverallRatingLabel.Size = new System.Drawing.Size(65, 20);
            this.medianOverallRatingLabel.TabIndex = 4;
            this.medianOverallRatingLabel.Text = "Median:";
            // 
            // mostCommonOverallRatingLabel
            // 
            this.mostCommonOverallRatingLabel.AutoSize = true;
            this.mostCommonOverallRatingLabel.Location = new System.Drawing.Point(537, 89);
            this.mostCommonOverallRatingLabel.Name = "mostCommonOverallRatingLabel";
            this.mostCommonOverallRatingLabel.Size = new System.Drawing.Size(113, 20);
            this.mostCommonOverallRatingLabel.TabIndex = 3;
            this.mostCommonOverallRatingLabel.Text = "Most common:";
            // 
            // averageOverallRatingLabel
            // 
            this.averageOverallRatingLabel.AutoSize = true;
            this.averageOverallRatingLabel.Location = new System.Drawing.Point(537, 52);
            this.averageOverallRatingLabel.Name = "averageOverallRatingLabel";
            this.averageOverallRatingLabel.Size = new System.Drawing.Size(72, 20);
            this.averageOverallRatingLabel.TabIndex = 2;
            this.averageOverallRatingLabel.Text = "Average:";
            // 
            // overallRatingChart
            // 
            this.overallRatingChart.Location = new System.Drawing.Point(12, 33);
            this.overallRatingChart.Name = "overallRatingChart";
            this.overallRatingChart.Size = new System.Drawing.Size(470, 371);
            this.overallRatingChart.TabIndex = 1;
            this.overallRatingChart.Text = "cartesianChart1";
            // 
            // overallRatingLabel
            // 
            this.overallRatingLabel.AutoSize = true;
            this.overallRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallRatingLabel.Location = new System.Drawing.Point(13, 5);
            this.overallRatingLabel.Name = "overallRatingLabel";
            this.overallRatingLabel.Size = new System.Drawing.Size(150, 25);
            this.overallRatingLabel.TabIndex = 0;
            this.overallRatingLabel.Text = "Overall Ratings:";
            // 
            // numberOfRatingsLabel
            // 
            this.numberOfRatingsLabel.AutoSize = true;
            this.numberOfRatingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRatingsLabel.Location = new System.Drawing.Point(574, 25);
            this.numberOfRatingsLabel.Name = "numberOfRatingsLabel";
            this.numberOfRatingsLabel.Size = new System.Drawing.Size(178, 25);
            this.numberOfRatingsLabel.TabIndex = 4;
            this.numberOfRatingsLabel.Text = "Number of Ratings:";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(31, 19);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(199, 32);
            this.courseNameLabel.TabIndex = 3;
            this.courseNameLabel.Text = "Course Name";
            // 
            // organizedRatingPanel
            // 
            this.organizedRatingPanel.Controls.Add(this.varianceOrganizedRatingLabel);
            this.organizedRatingPanel.Controls.Add(this.medianOrganizedRatingLabel);
            this.organizedRatingPanel.Controls.Add(this.mostCommonOrganizedRatingLabel);
            this.organizedRatingPanel.Controls.Add(this.averageOrganizedRatingLabel);
            this.organizedRatingPanel.Controls.Add(this.organizedRatingChart);
            this.organizedRatingPanel.Controls.Add(this.organizedRatingLabel);
            this.organizedRatingPanel.Location = new System.Drawing.Point(19, 467);
            this.organizedRatingPanel.Name = "organizedRatingPanel";
            this.organizedRatingPanel.Size = new System.Drawing.Size(802, 407);
            this.organizedRatingPanel.TabIndex = 6;
            // 
            // varianceOrganizedRatingLabel
            // 
            this.varianceOrganizedRatingLabel.AutoSize = true;
            this.varianceOrganizedRatingLabel.Location = new System.Drawing.Point(537, 170);
            this.varianceOrganizedRatingLabel.Name = "varianceOrganizedRatingLabel";
            this.varianceOrganizedRatingLabel.Size = new System.Drawing.Size(76, 20);
            this.varianceOrganizedRatingLabel.TabIndex = 5;
            this.varianceOrganizedRatingLabel.Text = "Variance:";
            // 
            // medianOrganizedRatingLabel
            // 
            this.medianOrganizedRatingLabel.AutoSize = true;
            this.medianOrganizedRatingLabel.Location = new System.Drawing.Point(537, 130);
            this.medianOrganizedRatingLabel.Name = "medianOrganizedRatingLabel";
            this.medianOrganizedRatingLabel.Size = new System.Drawing.Size(65, 20);
            this.medianOrganizedRatingLabel.TabIndex = 4;
            this.medianOrganizedRatingLabel.Text = "Median:";
            // 
            // mostCommonOrganizedRatingLabel
            // 
            this.mostCommonOrganizedRatingLabel.AutoSize = true;
            this.mostCommonOrganizedRatingLabel.Location = new System.Drawing.Point(537, 89);
            this.mostCommonOrganizedRatingLabel.Name = "mostCommonOrganizedRatingLabel";
            this.mostCommonOrganizedRatingLabel.Size = new System.Drawing.Size(113, 20);
            this.mostCommonOrganizedRatingLabel.TabIndex = 3;
            this.mostCommonOrganizedRatingLabel.Text = "Most common:";
            // 
            // averageOrganizedRatingLabel
            // 
            this.averageOrganizedRatingLabel.AutoSize = true;
            this.averageOrganizedRatingLabel.Location = new System.Drawing.Point(537, 52);
            this.averageOrganizedRatingLabel.Name = "averageOrganizedRatingLabel";
            this.averageOrganizedRatingLabel.Size = new System.Drawing.Size(72, 20);
            this.averageOrganizedRatingLabel.TabIndex = 2;
            this.averageOrganizedRatingLabel.Text = "Average:";
            // 
            // organizedRatingChart
            // 
            this.organizedRatingChart.Location = new System.Drawing.Point(12, 33);
            this.organizedRatingChart.Name = "organizedRatingChart";
            this.organizedRatingChart.Size = new System.Drawing.Size(470, 371);
            this.organizedRatingChart.TabIndex = 1;
            this.organizedRatingChart.Text = "cartesianChart1";
            // 
            // organizedRatingLabel
            // 
            this.organizedRatingLabel.AutoSize = true;
            this.organizedRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizedRatingLabel.Location = new System.Drawing.Point(13, 5);
            this.organizedRatingLabel.Name = "organizedRatingLabel";
            this.organizedRatingLabel.Size = new System.Drawing.Size(179, 25);
            this.organizedRatingLabel.TabIndex = 0;
            this.organizedRatingLabel.Text = "Organized Ratings:";
            // 
            // interestingRatingPanel
            // 
            this.interestingRatingPanel.Controls.Add(this.varianceInterestingRatingLabel);
            this.interestingRatingPanel.Controls.Add(this.medianInterestingRatingLabel);
            this.interestingRatingPanel.Controls.Add(this.mostCommonInterestingRatingLabel);
            this.interestingRatingPanel.Controls.Add(this.averageInterestingRatingLabel);
            this.interestingRatingPanel.Controls.Add(this.interestingRatingChart);
            this.interestingRatingPanel.Controls.Add(this.interestingRatingLabel);
            this.interestingRatingPanel.Location = new System.Drawing.Point(19, 877);
            this.interestingRatingPanel.Name = "interestingRatingPanel";
            this.interestingRatingPanel.Size = new System.Drawing.Size(802, 407);
            this.interestingRatingPanel.TabIndex = 7;
            // 
            // varianceInterestingRatingLabel
            // 
            this.varianceInterestingRatingLabel.AutoSize = true;
            this.varianceInterestingRatingLabel.Location = new System.Drawing.Point(537, 170);
            this.varianceInterestingRatingLabel.Name = "varianceInterestingRatingLabel";
            this.varianceInterestingRatingLabel.Size = new System.Drawing.Size(76, 20);
            this.varianceInterestingRatingLabel.TabIndex = 5;
            this.varianceInterestingRatingLabel.Text = "Variance:";
            // 
            // medianInterestingRatingLabel
            // 
            this.medianInterestingRatingLabel.AutoSize = true;
            this.medianInterestingRatingLabel.Location = new System.Drawing.Point(537, 130);
            this.medianInterestingRatingLabel.Name = "medianInterestingRatingLabel";
            this.medianInterestingRatingLabel.Size = new System.Drawing.Size(65, 20);
            this.medianInterestingRatingLabel.TabIndex = 4;
            this.medianInterestingRatingLabel.Text = "Median:";
            // 
            // mostCommonInterestingRatingLabel
            // 
            this.mostCommonInterestingRatingLabel.AutoSize = true;
            this.mostCommonInterestingRatingLabel.Location = new System.Drawing.Point(537, 89);
            this.mostCommonInterestingRatingLabel.Name = "mostCommonInterestingRatingLabel";
            this.mostCommonInterestingRatingLabel.Size = new System.Drawing.Size(113, 20);
            this.mostCommonInterestingRatingLabel.TabIndex = 3;
            this.mostCommonInterestingRatingLabel.Text = "Most common:";
            // 
            // averageInterestingRatingLabel
            // 
            this.averageInterestingRatingLabel.AutoSize = true;
            this.averageInterestingRatingLabel.Location = new System.Drawing.Point(537, 52);
            this.averageInterestingRatingLabel.Name = "averageInterestingRatingLabel";
            this.averageInterestingRatingLabel.Size = new System.Drawing.Size(72, 20);
            this.averageInterestingRatingLabel.TabIndex = 2;
            this.averageInterestingRatingLabel.Text = "Average:";
            // 
            // interestingRatingChart
            // 
            this.interestingRatingChart.Location = new System.Drawing.Point(12, 33);
            this.interestingRatingChart.Name = "interestingRatingChart";
            this.interestingRatingChart.Size = new System.Drawing.Size(470, 371);
            this.interestingRatingChart.TabIndex = 1;
            this.interestingRatingChart.Text = "cartesianChart1";
            // 
            // interestingRatingLabel
            // 
            this.interestingRatingLabel.AutoSize = true;
            this.interestingRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestingRatingLabel.Location = new System.Drawing.Point(13, 5);
            this.interestingRatingLabel.Name = "interestingRatingLabel";
            this.interestingRatingLabel.Size = new System.Drawing.Size(178, 25);
            this.interestingRatingLabel.TabIndex = 0;
            this.interestingRatingLabel.Text = "Interesting Ratings:";
            // 
            // presentedRatingPanel
            // 
            this.presentedRatingPanel.Controls.Add(this.variancePresentedRatingLabel);
            this.presentedRatingPanel.Controls.Add(this.medianPresentedRatingLabel);
            this.presentedRatingPanel.Controls.Add(this.mostCommonPresentedRatingLabel);
            this.presentedRatingPanel.Controls.Add(this.averagePresentedRatingLabel);
            this.presentedRatingPanel.Controls.Add(this.presentedRatingChart);
            this.presentedRatingPanel.Controls.Add(this.presentedRatingLabel);
            this.presentedRatingPanel.Location = new System.Drawing.Point(19, 1287);
            this.presentedRatingPanel.Name = "presentedRatingPanel";
            this.presentedRatingPanel.Size = new System.Drawing.Size(802, 407);
            this.presentedRatingPanel.TabIndex = 8;
            // 
            // variancePresentedRatingLabel
            // 
            this.variancePresentedRatingLabel.AutoSize = true;
            this.variancePresentedRatingLabel.Location = new System.Drawing.Point(537, 170);
            this.variancePresentedRatingLabel.Name = "variancePresentedRatingLabel";
            this.variancePresentedRatingLabel.Size = new System.Drawing.Size(76, 20);
            this.variancePresentedRatingLabel.TabIndex = 5;
            this.variancePresentedRatingLabel.Text = "Variance:";
            // 
            // medianPresentedRatingLabel
            // 
            this.medianPresentedRatingLabel.AutoSize = true;
            this.medianPresentedRatingLabel.Location = new System.Drawing.Point(537, 130);
            this.medianPresentedRatingLabel.Name = "medianPresentedRatingLabel";
            this.medianPresentedRatingLabel.Size = new System.Drawing.Size(65, 20);
            this.medianPresentedRatingLabel.TabIndex = 4;
            this.medianPresentedRatingLabel.Text = "Median:";
            // 
            // mostCommonPresentedRatingLabel
            // 
            this.mostCommonPresentedRatingLabel.AutoSize = true;
            this.mostCommonPresentedRatingLabel.Location = new System.Drawing.Point(537, 89);
            this.mostCommonPresentedRatingLabel.Name = "mostCommonPresentedRatingLabel";
            this.mostCommonPresentedRatingLabel.Size = new System.Drawing.Size(113, 20);
            this.mostCommonPresentedRatingLabel.TabIndex = 3;
            this.mostCommonPresentedRatingLabel.Text = "Most common:";
            // 
            // averagePresentedRatingLabel
            // 
            this.averagePresentedRatingLabel.AutoSize = true;
            this.averagePresentedRatingLabel.Location = new System.Drawing.Point(537, 52);
            this.averagePresentedRatingLabel.Name = "averagePresentedRatingLabel";
            this.averagePresentedRatingLabel.Size = new System.Drawing.Size(72, 20);
            this.averagePresentedRatingLabel.TabIndex = 2;
            this.averagePresentedRatingLabel.Text = "Average:";
            // 
            // presentedRatingChart
            // 
            this.presentedRatingChart.Location = new System.Drawing.Point(12, 33);
            this.presentedRatingChart.Name = "presentedRatingChart";
            this.presentedRatingChart.Size = new System.Drawing.Size(470, 371);
            this.presentedRatingChart.TabIndex = 1;
            this.presentedRatingChart.Text = "cartesianChart1";
            // 
            // presentedRatingLabel
            // 
            this.presentedRatingLabel.AutoSize = true;
            this.presentedRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentedRatingLabel.Location = new System.Drawing.Point(13, 5);
            this.presentedRatingLabel.Name = "presentedRatingLabel";
            this.presentedRatingLabel.Size = new System.Drawing.Size(177, 25);
            this.presentedRatingLabel.TabIndex = 0;
            this.presentedRatingLabel.Text = "Presented Ratings:";
            // 
            // learnedRatingPanel
            // 
            this.learnedRatingPanel.Controls.Add(this.varianceLearnedRatingLabel);
            this.learnedRatingPanel.Controls.Add(this.medianLearnedRatingLabel);
            this.learnedRatingPanel.Controls.Add(this.mostCommonLearnedRatingLabel);
            this.learnedRatingPanel.Controls.Add(this.averageLearnedRatingLabel);
            this.learnedRatingPanel.Controls.Add(this.learnedRatingChart);
            this.learnedRatingPanel.Controls.Add(this.learnedRatingLabel);
            this.learnedRatingPanel.Location = new System.Drawing.Point(19, 1700);
            this.learnedRatingPanel.Name = "learnedRatingPanel";
            this.learnedRatingPanel.Size = new System.Drawing.Size(802, 407);
            this.learnedRatingPanel.TabIndex = 9;
            // 
            // varianceLearnedRatingLabel
            // 
            this.varianceLearnedRatingLabel.AutoSize = true;
            this.varianceLearnedRatingLabel.Location = new System.Drawing.Point(537, 170);
            this.varianceLearnedRatingLabel.Name = "varianceLearnedRatingLabel";
            this.varianceLearnedRatingLabel.Size = new System.Drawing.Size(76, 20);
            this.varianceLearnedRatingLabel.TabIndex = 5;
            this.varianceLearnedRatingLabel.Text = "Variance:";
            // 
            // medianLearnedRatingLabel
            // 
            this.medianLearnedRatingLabel.AutoSize = true;
            this.medianLearnedRatingLabel.Location = new System.Drawing.Point(537, 130);
            this.medianLearnedRatingLabel.Name = "medianLearnedRatingLabel";
            this.medianLearnedRatingLabel.Size = new System.Drawing.Size(65, 20);
            this.medianLearnedRatingLabel.TabIndex = 4;
            this.medianLearnedRatingLabel.Text = "Median:";
            // 
            // mostCommonLearnedRatingLabel
            // 
            this.mostCommonLearnedRatingLabel.AutoSize = true;
            this.mostCommonLearnedRatingLabel.Location = new System.Drawing.Point(537, 89);
            this.mostCommonLearnedRatingLabel.Name = "mostCommonLearnedRatingLabel";
            this.mostCommonLearnedRatingLabel.Size = new System.Drawing.Size(113, 20);
            this.mostCommonLearnedRatingLabel.TabIndex = 3;
            this.mostCommonLearnedRatingLabel.Text = "Most common:";
            // 
            // averageLearnedRatingLabel
            // 
            this.averageLearnedRatingLabel.AutoSize = true;
            this.averageLearnedRatingLabel.Location = new System.Drawing.Point(537, 52);
            this.averageLearnedRatingLabel.Name = "averageLearnedRatingLabel";
            this.averageLearnedRatingLabel.Size = new System.Drawing.Size(72, 20);
            this.averageLearnedRatingLabel.TabIndex = 2;
            this.averageLearnedRatingLabel.Text = "Average:";
            // 
            // learnedRatingChart
            // 
            this.learnedRatingChart.Location = new System.Drawing.Point(12, 33);
            this.learnedRatingChart.Name = "learnedRatingChart";
            this.learnedRatingChart.Size = new System.Drawing.Size(470, 371);
            this.learnedRatingChart.TabIndex = 1;
            this.learnedRatingChart.Text = "cartesianChart1";
            // 
            // learnedRatingLabel
            // 
            this.learnedRatingLabel.AutoSize = true;
            this.learnedRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnedRatingLabel.Location = new System.Drawing.Point(13, 5);
            this.learnedRatingLabel.Name = "learnedRatingLabel";
            this.learnedRatingLabel.Size = new System.Drawing.Size(177, 25);
            this.learnedRatingLabel.TabIndex = 0;
            this.learnedRatingLabel.Text = "Presented Ratings:";
            // 
            // DataVizualisation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.learnedRatingPanel);
            this.Controls.Add(this.presentedRatingPanel);
            this.Controls.Add(this.interestingRatingPanel);
            this.Controls.Add(this.organizedRatingPanel);
            this.Controls.Add(this.overallRatingPanel);
            this.Controls.Add(this.numberOfRatingsLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Name = "DataVizualisation";
            this.Size = new System.Drawing.Size(850, 4000);
            this.overallRatingPanel.ResumeLayout(false);
            this.overallRatingPanel.PerformLayout();
            this.organizedRatingPanel.ResumeLayout(false);
            this.organizedRatingPanel.PerformLayout();
            this.interestingRatingPanel.ResumeLayout(false);
            this.interestingRatingPanel.PerformLayout();
            this.presentedRatingPanel.ResumeLayout(false);
            this.presentedRatingPanel.PerformLayout();
            this.learnedRatingPanel.ResumeLayout(false);
            this.learnedRatingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel overallRatingPanel;
        private System.Windows.Forms.Label varianceOverallRatingLabel;
        private System.Windows.Forms.Label medianOverallRatingLabel;
        private System.Windows.Forms.Label mostCommonOverallRatingLabel;
        private System.Windows.Forms.Label averageOverallRatingLabel;
        private LiveCharts.WinForms.CartesianChart overallRatingChart;
        private System.Windows.Forms.Label overallRatingLabel;
        private System.Windows.Forms.Label numberOfRatingsLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Panel organizedRatingPanel;
        private System.Windows.Forms.Label varianceOrganizedRatingLabel;
        private System.Windows.Forms.Label medianOrganizedRatingLabel;
        private System.Windows.Forms.Label mostCommonOrganizedRatingLabel;
        private System.Windows.Forms.Label averageOrganizedRatingLabel;
        private LiveCharts.WinForms.CartesianChart organizedRatingChart;
        private System.Windows.Forms.Label organizedRatingLabel;
        private System.Windows.Forms.Panel interestingRatingPanel;
        private System.Windows.Forms.Label varianceInterestingRatingLabel;
        private System.Windows.Forms.Label medianInterestingRatingLabel;
        private System.Windows.Forms.Label mostCommonInterestingRatingLabel;
        private System.Windows.Forms.Label averageInterestingRatingLabel;
        private LiveCharts.WinForms.CartesianChart interestingRatingChart;
        private System.Windows.Forms.Label interestingRatingLabel;
        private System.Windows.Forms.Panel presentedRatingPanel;
        private System.Windows.Forms.Label variancePresentedRatingLabel;
        private System.Windows.Forms.Label medianPresentedRatingLabel;
        private System.Windows.Forms.Label mostCommonPresentedRatingLabel;
        private System.Windows.Forms.Label averagePresentedRatingLabel;
        private LiveCharts.WinForms.CartesianChart presentedRatingChart;
        private System.Windows.Forms.Label presentedRatingLabel;
        private System.Windows.Forms.Panel learnedRatingPanel;
        private System.Windows.Forms.Label varianceLearnedRatingLabel;
        private System.Windows.Forms.Label medianLearnedRatingLabel;
        private System.Windows.Forms.Label mostCommonLearnedRatingLabel;
        private System.Windows.Forms.Label averageLearnedRatingLabel;
        private LiveCharts.WinForms.CartesianChart learnedRatingChart;
        private System.Windows.Forms.Label learnedRatingLabel;
    }
}

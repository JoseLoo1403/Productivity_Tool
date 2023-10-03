namespace Productivity_Tool.Forms
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblStreak = new System.Windows.Forms.Label();
            this.GoalBar = new CircularProgressBar.CircularProgressBar();
            this.ChDailyInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChDailyInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblStreak
            // 
            this.LblStreak.AutoSize = true;
            this.LblStreak.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.LblStreak.Location = new System.Drawing.Point(36, 47);
            this.LblStreak.Name = "LblStreak";
            this.LblStreak.Size = new System.Drawing.Size(147, 31);
            this.LblStreak.TabIndex = 0;
            this.LblStreak.Text = "Day-Streak: 0";
            // 
            // GoalBar
            // 
            this.GoalBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GoalBar.AnimationSpeed = 500;
            this.GoalBar.BackColor = System.Drawing.Color.Transparent;
            this.GoalBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoalBar.InnerColor = System.Drawing.Color.Transparent;
            this.GoalBar.InnerMargin = 2;
            this.GoalBar.InnerWidth = -1;
            this.GoalBar.Location = new System.Drawing.Point(442, 18);
            this.GoalBar.MarqueeAnimationSpeed = 2000;
            this.GoalBar.Name = "GoalBar";
            this.GoalBar.OuterColor = System.Drawing.Color.Gray;
            this.GoalBar.OuterMargin = -25;
            this.GoalBar.OuterWidth = 26;
            this.GoalBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.GoalBar.ProgressWidth = 25;
            this.GoalBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoalBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalBar.Size = new System.Drawing.Size(240, 238);
            this.GoalBar.StartAngle = 270;
            this.GoalBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GoalBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.GoalBar.SubscriptText = "";
            this.GoalBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GoalBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.GoalBar.SuperscriptText = "";
            this.GoalBar.TabIndex = 1;
            this.GoalBar.Text = "Goal 0/3";
            this.GoalBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.GoalBar.Value = 68;
            // 
            // ChDailyInfo
            // 
            this.ChDailyInfo.BackColor = System.Drawing.Color.Transparent;
            this.ChDailyInfo.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChDailyInfo.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.ChDailyInfo.Legends.Add(legend2);
            this.ChDailyInfo.Location = new System.Drawing.Point(42, 262);
            this.ChDailyInfo.Name = "ChDailyInfo";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.RoyalBlue;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Study Hours";
            this.ChDailyInfo.Series.Add(series2);
            this.ChDailyInfo.Size = new System.Drawing.Size(661, 355);
            this.ChDailyInfo.TabIndex = 2;
            this.ChDailyInfo.Text = "chart1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChDailyInfo);
            this.Controls.Add(this.GoalBar);
            this.Controls.Add(this.LblStreak);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(750, 700);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChDailyInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStreak;
        private CircularProgressBar.CircularProgressBar GoalBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChDailyInfo;
    }
}

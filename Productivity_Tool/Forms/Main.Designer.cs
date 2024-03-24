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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblStreak = new System.Windows.Forms.Label();
            this.GoalBar = new CircularProgressBar.CircularProgressBar();
            this.ChDailyInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblTodayTime = new System.Windows.Forms.Label();
            this.CbMonth = new System.Windows.Forms.ComboBox();
            this.LblMonthTime = new System.Windows.Forms.Label();
            this.LblSelectedMonth = new System.Windows.Forms.Label();
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
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChDailyInfo.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.ChDailyInfo.Legends.Add(legend1);
            this.ChDailyInfo.Location = new System.Drawing.Point(42, 321);
            this.ChDailyInfo.Name = "ChDailyInfo";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.RoyalBlue;
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Study Hours";
            series1.YValuesPerPoint = 4;
            this.ChDailyInfo.Series.Add(series1);
            this.ChDailyInfo.Size = new System.Drawing.Size(661, 355);
            this.ChDailyInfo.TabIndex = 2;
            this.ChDailyInfo.Text = "chart1";
            // 
            // LblTodayTime
            // 
            this.LblTodayTime.AutoSize = true;
            this.LblTodayTime.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.LblTodayTime.Location = new System.Drawing.Point(36, 149);
            this.LblTodayTime.Name = "LblTodayTime";
            this.LblTodayTime.Size = new System.Drawing.Size(224, 31);
            this.LblTodayTime.TabIndex = 3;
            this.LblTodayTime.Text = "Today\'s Study Time: 0";
            // 
            // CbMonth
            // 
            this.CbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMonth.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
            this.CbMonth.FormattingEnabled = true;
            this.CbMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbMonth.Location = new System.Drawing.Point(530, 339);
            this.CbMonth.Name = "CbMonth";
            this.CbMonth.Size = new System.Drawing.Size(143, 31);
            this.CbMonth.TabIndex = 4;
            this.CbMonth.SelectedIndexChanged += new System.EventHandler(this.CbMonth_SelectedIndexChanged);
            // 
            // LblMonthTime
            // 
            this.LblMonthTime.AutoSize = true;
            this.LblMonthTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblMonthTime.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.LblMonthTime.Location = new System.Drawing.Point(36, 205);
            this.LblMonthTime.Name = "LblMonthTime";
            this.LblMonthTime.Size = new System.Drawing.Size(218, 31);
            this.LblMonthTime.TabIndex = 5;
            this.LblMonthTime.Text = "Month Study Time: 0";
            // 
            // LblSelectedMonth
            // 
            this.LblSelectedMonth.AutoSize = true;
            this.LblSelectedMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblSelectedMonth.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.8F);
            this.LblSelectedMonth.Location = new System.Drawing.Point(208, 337);
            this.LblSelectedMonth.Name = "LblSelectedMonth";
            this.LblSelectedMonth.Size = new System.Drawing.Size(0, 20);
            this.LblSelectedMonth.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblSelectedMonth);
            this.Controls.Add(this.LblMonthTime);
            this.Controls.Add(this.CbMonth);
            this.Controls.Add(this.LblTodayTime);
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
        private System.Windows.Forms.Label LblTodayTime;
        private System.Windows.Forms.ComboBox CbMonth;
        private System.Windows.Forms.Label LblMonthTime;
        private System.Windows.Forms.Label LblSelectedMonth;
    }
}

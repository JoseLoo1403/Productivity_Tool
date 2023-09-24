namespace Productivity_Tool.Forms
{
    partial class Pomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerBar = new CircularProgressBar.CircularProgressBar();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.LblStudy = new System.Windows.Forms.Label();
            this.LblRest = new System.Windows.Forms.Label();
            this.TxtHourStudy = new System.Windows.Forms.NumericUpDown();
            this.TxtMinuteStudy = new System.Windows.Forms.NumericUpDown();
            this.TxtHourRest = new System.Windows.Forms.NumericUpDown();
            this.TxtMinuteRest = new System.Windows.Forms.NumericUpDown();
            this.BtnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHourStudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinuteStudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHourRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinuteRest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomodoro view";
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnStart.FlatAppearance.BorderSize = 2;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.BtnStart.Location = new System.Drawing.Point(142, 373);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(199, 59);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerBar
            // 
            this.TimerBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.TimerBar.AnimationSpeed = 500;
            this.TimerBar.BackColor = System.Drawing.Color.Transparent;
            this.TimerBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBar.ForeColor = System.Drawing.Color.Black;
            this.TimerBar.InnerColor = System.Drawing.Color.Transparent;
            this.TimerBar.InnerMargin = 2;
            this.TimerBar.InnerWidth = -1;
            this.TimerBar.Location = new System.Drawing.Point(219, 72);
            this.TimerBar.MarqueeAnimationSpeed = 2000;
            this.TimerBar.Name = "TimerBar";
            this.TimerBar.OuterColor = System.Drawing.Color.Gray;
            this.TimerBar.OuterMargin = -25;
            this.TimerBar.OuterWidth = 26;
            this.TimerBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TimerBar.ProgressWidth = 25;
            this.TimerBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TimerBar.Size = new System.Drawing.Size(271, 270);
            this.TimerBar.StartAngle = 270;
            this.TimerBar.Step = 0;
            this.TimerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimerBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TimerBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TimerBar.SubscriptText = "";
            this.TimerBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TimerBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TimerBar.SuperscriptText = "";
            this.TimerBar.TabIndex = 3;
            this.TimerBar.Text = "00:00:00";
            this.TimerBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.TimerBar.Value = 68;
            // 
            // BtnConfig
            // 
            this.BtnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfig.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfig.Image")));
            this.BtnConfig.Location = new System.Drawing.Point(352, 438);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(42, 36);
            this.BtnConfig.TabIndex = 4;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnStop.FlatAppearance.BorderSize = 2;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.BtnStop.Location = new System.Drawing.Point(405, 373);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(199, 59);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // LblStudy
            // 
            this.LblStudy.AutoSize = true;
            this.LblStudy.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.LblStudy.Location = new System.Drawing.Point(139, 505);
            this.LblStudy.Name = "LblStudy";
            this.LblStudy.Size = new System.Drawing.Size(128, 31);
            this.LblStudy.TabIndex = 7;
            this.LblStudy.Text = "Study Time:";
            this.LblStudy.Visible = false;
            // 
            // LblRest
            // 
            this.LblRest.AutoSize = true;
            this.LblRest.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.LblRest.Location = new System.Drawing.Point(476, 505);
            this.LblRest.Name = "LblRest";
            this.LblRest.Size = new System.Drawing.Size(113, 31);
            this.LblRest.TabIndex = 10;
            this.LblRest.Text = "Rest Time:";
            this.LblRest.Visible = false;
            // 
            // TxtHourStudy
            // 
            this.TxtHourStudy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtHourStudy.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.TxtHourStudy.Location = new System.Drawing.Point(112, 562);
            this.TxtHourStudy.Name = "TxtHourStudy";
            this.TxtHourStudy.Size = new System.Drawing.Size(81, 32);
            this.TxtHourStudy.TabIndex = 12;
            this.TxtHourStudy.Visible = false;
            // 
            // TxtMinuteStudy
            // 
            this.TxtMinuteStudy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMinuteStudy.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.TxtMinuteStudy.Location = new System.Drawing.Point(219, 562);
            this.TxtMinuteStudy.Name = "TxtMinuteStudy";
            this.TxtMinuteStudy.Size = new System.Drawing.Size(81, 32);
            this.TxtMinuteStudy.TabIndex = 13;
            this.TxtMinuteStudy.Visible = false;
            // 
            // TxtHourRest
            // 
            this.TxtHourRest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtHourRest.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.TxtHourRest.Location = new System.Drawing.Point(447, 562);
            this.TxtHourRest.Name = "TxtHourRest";
            this.TxtHourRest.Size = new System.Drawing.Size(81, 32);
            this.TxtHourRest.TabIndex = 14;
            this.TxtHourRest.Visible = false;
            // 
            // TxtMinuteRest
            // 
            this.TxtMinuteRest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMinuteRest.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.TxtMinuteRest.Location = new System.Drawing.Point(556, 562);
            this.TxtMinuteRest.Name = "TxtMinuteRest";
            this.TxtMinuteRest.Size = new System.Drawing.Size(81, 32);
            this.TxtMinuteRest.TabIndex = 15;
            this.TxtMinuteRest.Visible = false;
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnApply.BackColor = System.Drawing.Color.Transparent;
            this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnApply.FlatAppearance.BorderSize = 2;
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Font = new System.Drawing.Font("Nirmala UI Semilight", 8F);
            this.BtnApply.Location = new System.Drawing.Point(332, 621);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(85, 35);
            this.BtnApply.TabIndex = 16;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = false;
            this.BtnApply.Visible = false;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.TxtMinuteRest);
            this.Controls.Add(this.TxtHourRest);
            this.Controls.Add(this.TxtMinuteStudy);
            this.Controls.Add(this.TxtHourStudy);
            this.Controls.Add(this.LblRest);
            this.Controls.Add(this.LblStudy);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerBar);
            this.Name = "Pomodoro";
            this.Size = new System.Drawing.Size(750, 680);
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtHourStudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinuteStudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHourRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinuteRest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar TimerBar;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label LblStudy;
        private System.Windows.Forms.Label LblRest;
        private System.Windows.Forms.NumericUpDown TxtHourStudy;
        private System.Windows.Forms.NumericUpDown TxtMinuteStudy;
        private System.Windows.Forms.NumericUpDown TxtHourRest;
        private System.Windows.Forms.NumericUpDown TxtMinuteRest;
        private System.Windows.Forms.Button BtnApply;
    }
}

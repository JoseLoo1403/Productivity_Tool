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
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerBar = new CircularProgressBar.CircularProgressBar();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.LblStudyInfo = new System.Windows.Forms.Label();
            this.LblRestInfo = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.LblSessionCount = new System.Windows.Forms.Label();
            this.BtnRestartCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnStart.FlatAppearance.BorderSize = 2;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.BtnStart.Location = new System.Drawing.Point(167, 464);
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
            this.TimerBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.TimerBar.AnimationSpeed = 500;
            this.TimerBar.BackColor = System.Drawing.Color.Transparent;
            this.TimerBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBar.ForeColor = System.Drawing.Color.Black;
            this.TimerBar.InnerColor = System.Drawing.Color.Transparent;
            this.TimerBar.InnerMargin = 2;
            this.TimerBar.InnerWidth = -1;
            this.TimerBar.Location = new System.Drawing.Point(232, 70);
            this.TimerBar.MarqueeAnimationSpeed = 2000;
            this.TimerBar.Name = "TimerBar";
            this.TimerBar.OuterColor = System.Drawing.Color.Gray;
            this.TimerBar.OuterMargin = -25;
            this.TimerBar.OuterWidth = 26;
            this.TimerBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TimerBar.ProgressWidth = 25;
            this.TimerBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TimerBar.Size = new System.Drawing.Size(320, 320);
            this.TimerBar.StartAngle = 270;
            this.TimerBar.Step = 0;
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
            this.BtnConfig.Location = new System.Drawing.Point(375, 531);
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
            this.BtnStop.Location = new System.Drawing.Point(429, 464);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(199, 59);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // LblStudyInfo
            // 
            this.LblStudyInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblStudyInfo.AutoSize = true;
            this.LblStudyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblStudyInfo.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.LblStudyInfo.Location = new System.Drawing.Point(160, 580);
            this.LblStudyInfo.Name = "LblStudyInfo";
            this.LblStudyInfo.Size = new System.Drawing.Size(48, 25);
            this.LblStudyInfo.TabIndex = 6;
            this.LblStudyInfo.Text = "label";
            this.LblStudyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblStudyInfo.Visible = false;
            // 
            // LblRestInfo
            // 
            this.LblRestInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRestInfo.AutoSize = true;
            this.LblRestInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRestInfo.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.LblRestInfo.Location = new System.Drawing.Point(437, 580);
            this.LblRestInfo.Name = "LblRestInfo";
            this.LblRestInfo.Size = new System.Drawing.Size(48, 25);
            this.LblRestInfo.TabIndex = 7;
            this.LblRestInfo.Text = "label";
            this.LblRestInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRestInfo.Visible = false;
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblMessage.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.LblMessage.Location = new System.Drawing.Point(162, 409);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(466, 25);
            this.LblMessage.TabIndex = 8;
            this.LblMessage.Text = "label";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 180;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // LblSessionCount
            // 
            this.LblSessionCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSessionCount.AutoSize = true;
            this.LblSessionCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSessionCount.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.8F);
            this.LblSessionCount.Location = new System.Drawing.Point(371, 275);
            this.LblSessionCount.Name = "LblSessionCount";
            this.LblSessionCount.Size = new System.Drawing.Size(34, 23);
            this.LblSessionCount.TabIndex = 9;
            this.LblSessionCount.Text = "0/3";
            // 
            // BtnRestartCount
            // 
            this.BtnRestartCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRestartCount.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestartCount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnRestartCount.FlatAppearance.BorderSize = 2;
            this.BtnRestartCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestartCount.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.BtnRestartCount.Location = new System.Drawing.Point(272, 631);
            this.BtnRestartCount.Name = "BtnRestartCount";
            this.BtnRestartCount.Size = new System.Drawing.Size(237, 40);
            this.BtnRestartCount.TabIndex = 10;
            this.BtnRestartCount.Text = "Restart session count";
            this.BtnRestartCount.UseVisualStyleBackColor = false;
            this.BtnRestartCount.Visible = false;
            this.BtnRestartCount.Click += new System.EventHandler(this.BtnRestartCount_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnRestartCount);
            this.Controls.Add(this.LblSessionCount);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.LblRestInfo);
            this.Controls.Add(this.LblStudyInfo);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TimerBar);
            this.Name = "Pomodoro";
            this.Size = new System.Drawing.Size(780, 720);
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar TimerBar;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label LblStudyInfo;
        private System.Windows.Forms.Label LblRestInfo;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Label LblSessionCount;
        private System.Windows.Forms.Button BtnRestartCount;
    }
}

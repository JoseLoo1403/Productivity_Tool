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
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerBar);
            this.Name = "Pomodoro";
            this.Size = new System.Drawing.Size(750, 680);
            this.Load += new System.EventHandler(this.Pomodoro_Load);
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
    }
}

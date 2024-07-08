using System.Threading;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerBar = new CircularProgressBar.CircularProgressBar();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.LblStudyInfo = new System.Windows.Forms.Label();
            this.LblRestInfo = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.LblSessionCount = new System.Windows.Forms.Label();
            this.BtnRestartCount = new System.Windows.Forms.Button();
            this.BtnZenMode = new System.Windows.Forms.Button();
            this.BtnSkip = new System.Windows.Forms.Button();
            this.BtnStart = new Guna.UI2.WinForms.Guna2Button();
            this.BtnStop = new Guna.UI2.WinForms.Guna2Button();
            this.CbTasks = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
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
            this.TimerBar.Location = new System.Drawing.Point(197, 26);
            this.TimerBar.MarqueeAnimationSpeed = 2000;
            this.TimerBar.Name = "TimerBar";
            this.TimerBar.OuterColor = System.Drawing.Color.Gray;
            this.TimerBar.OuterMargin = -25;
            this.TimerBar.OuterWidth = 26;
            this.TimerBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TimerBar.ProgressWidth = 25;
            this.TimerBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TimerBar.Size = new System.Drawing.Size(360, 360);
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
            this.BtnConfig.Location = new System.Drawing.Point(358, 521);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(47, 36);
            this.BtnConfig.TabIndex = 4;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // LblStudyInfo
            // 
            this.LblStudyInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblStudyInfo.AutoSize = true;
            this.LblStudyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblStudyInfo.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.LblStudyInfo.Location = new System.Drawing.Point(126, 570);
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
            this.LblRestInfo.Location = new System.Drawing.Point(438, 570);
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
            this.LblMessage.Location = new System.Drawing.Point(118, 399);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(524, 25);
            this.LblMessage.TabIndex = 8;
            this.LblMessage.Text = "label";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 200;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // LblSessionCount
            // 
            this.LblSessionCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSessionCount.AutoSize = true;
            this.LblSessionCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSessionCount.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.8F);
            this.LblSessionCount.Location = new System.Drawing.Point(371, 245);
            this.LblSessionCount.Name = "LblSessionCount";
            this.LblSessionCount.Size = new System.Drawing.Size(34, 23);
            this.LblSessionCount.TabIndex = 9;
            this.LblSessionCount.Text = "0/3";
            // 
            // BtnRestartCount
            // 
            this.BtnRestartCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRestartCount.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestartCount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.BtnRestartCount.FlatAppearance.BorderSize = 2;
            this.BtnRestartCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestartCount.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.BtnRestartCount.Location = new System.Drawing.Point(252, 621);
            this.BtnRestartCount.Name = "BtnRestartCount";
            this.BtnRestartCount.Size = new System.Drawing.Size(267, 40);
            this.BtnRestartCount.TabIndex = 10;
            this.BtnRestartCount.Text = "Restart session count";
            this.BtnRestartCount.UseVisualStyleBackColor = false;
            this.BtnRestartCount.Visible = false;
            this.BtnRestartCount.Click += new System.EventHandler(this.BtnRestartCount_Click);
            // 
            // BtnZenMode
            // 
            this.BtnZenMode.BackColor = System.Drawing.Color.Transparent;
            this.BtnZenMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.BtnZenMode.FlatAppearance.BorderSize = 0;
            this.BtnZenMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZenMode.Image = ((System.Drawing.Image)(resources.GetObject("BtnZenMode.Image")));
            this.BtnZenMode.Location = new System.Drawing.Point(24, 19);
            this.BtnZenMode.Name = "BtnZenMode";
            this.BtnZenMode.Size = new System.Drawing.Size(66, 42);
            this.BtnZenMode.TabIndex = 11;
            this.BtnZenMode.UseVisualStyleBackColor = false;
            this.BtnZenMode.Click += new System.EventHandler(this.BtnZenMode_Click);
            // 
            // BtnSkip
            // 
            this.BtnSkip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSkip.BackColor = System.Drawing.Color.Transparent;
            this.BtnSkip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.BtnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSkip.Font = new System.Drawing.Font("Nirmala UI Semilight", 8F);
            this.BtnSkip.Location = new System.Drawing.Point(358, 271);
            this.BtnSkip.Name = "BtnSkip";
            this.BtnSkip.Size = new System.Drawing.Size(55, 31);
            this.BtnSkip.TabIndex = 12;
            this.BtnSkip.Text = "Skip";
            this.BtnSkip.UseVisualStyleBackColor = false;
            this.BtnSkip.Visible = false;
            this.BtnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStart.Animated = true;
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.BtnStart.BorderRadius = 28;
            this.BtnStart.BorderThickness = 2;
            this.BtnStart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.BtnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.FillColor = System.Drawing.Color.White;
            this.BtnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStart.FillColor = System.Drawing.Color.White;
            this.BtnStart.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.BtnStart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.BtnStart.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(97, 454);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.ShadowDecoration.BorderRadius = 28;
            this.BtnStart.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.BtnStart.ShadowDecoration.Depth = 60;
            this.BtnStart.ShadowDecoration.Enabled = true;
            this.BtnStart.Size = new System.Drawing.Size(231, 59);
            this.BtnStart.TabIndex = 14;
            this.BtnStart.Text = "Start";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStop.Animated = true;
            this.BtnStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.BtnStop.BorderRadius = 26;
            this.BtnStop.BorderThickness = 2;
            this.BtnStop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.BtnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStop.DisabledState.FillColor = System.Drawing.Color.White;
            this.BtnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStop.FillColor = System.Drawing.Color.White;
            this.BtnStop.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.BtnStop.ForeColor = System.Drawing.Color.Black;
            this.BtnStop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.BtnStop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.BtnStop.Location = new System.Drawing.Point(411, 454);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.ShadowDecoration.BorderRadius = 26;
            this.BtnStop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.BtnStop.ShadowDecoration.Enabled = true;
            this.BtnStop.Size = new System.Drawing.Size(231, 59);
            this.BtnStop.TabIndex = 16;
            this.BtnStop.Text = "Pause";
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // CbTasks
            // 
            this.CbTasks.BackColor = System.Drawing.Color.Transparent;
            this.CbTasks.BorderRadius = 10;
            this.CbTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTasks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTasks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTasks.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.CbTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbTasks.ItemHeight = 30;
            this.CbTasks.Location = new System.Drawing.Point(545, 19);
            this.CbTasks.Name = "CbTasks";
            this.CbTasks.Size = new System.Drawing.Size(189, 36);
            this.CbTasks.TabIndex = 17;
            this.CbTasks.SelectedIndexChanged += new System.EventHandler(this.CbTasks_SelectedIndexChanged);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CbTasks);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnSkip);
            this.Controls.Add(this.BtnZenMode);
            this.Controls.Add(this.BtnRestartCount);
            this.Controls.Add(this.LblSessionCount);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.LblRestInfo);
            this.Controls.Add(this.LblStudyInfo);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.TimerBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Pomodoro";
            this.Size = new System.Drawing.Size(750, 700);
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            Thread.Sleep(90);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar TimerBar;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Label LblStudyInfo;
        private System.Windows.Forms.Label LblRestInfo;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Label LblSessionCount;
        private System.Windows.Forms.Button BtnRestartCount;
        private System.Windows.Forms.Button BtnZenMode;
        private System.Windows.Forms.Button BtnSkip;
        private Guna.UI2.WinForms.Guna2Button BtnStart;
        private Guna.UI2.WinForms.Guna2Button BtnStop;
        private Guna.UI2.WinForms.Guna2ComboBox CbTasks;
    }
}

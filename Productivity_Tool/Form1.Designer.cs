namespace Productivity_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NavBarPN = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnConfiguration = new System.Windows.Forms.Button();
            this.BtnPomodoro = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.MainDisplayPN = new System.Windows.Forms.Panel();
            this.PnTop = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.NavBarPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBarPN
            // 
            this.NavBarPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.NavBarPN.Controls.Add(this.lblVersion);
            this.NavBarPN.Controls.Add(this.pictureBox1);
            this.NavBarPN.Controls.Add(this.BtnConfiguration);
            this.NavBarPN.Controls.Add(this.BtnPomodoro);
            this.NavBarPN.Controls.Add(this.BtnMain);
            this.NavBarPN.Location = new System.Drawing.Point(0, -4);
            this.NavBarPN.Name = "NavBarPN";
            this.NavBarPN.Size = new System.Drawing.Size(276, 727);
            this.NavBarPN.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.8F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(83, 698);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 20);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version: 0.1.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnConfiguration
            // 
            this.BtnConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfiguration.FlatAppearance.BorderSize = 0;
            this.BtnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguration.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguration.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguration.Image")));
            this.BtnConfiguration.Location = new System.Drawing.Point(-3, 428);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Size = new System.Drawing.Size(282, 49);
            this.BtnConfiguration.TabIndex = 2;
            this.BtnConfiguration.Text = "Configuration";
            this.BtnConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConfiguration.UseVisualStyleBackColor = false;
            this.BtnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            this.BtnConfiguration.MouseEnter += new System.EventHandler(this.HoverEffect);
            this.BtnConfiguration.MouseLeave += new System.EventHandler(this.HoverEffectExit);
            // 
            // BtnPomodoro
            // 
            this.BtnPomodoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPomodoro.FlatAppearance.BorderSize = 0;
            this.BtnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPomodoro.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPomodoro.ForeColor = System.Drawing.Color.White;
            this.BtnPomodoro.Image = ((System.Drawing.Image)(resources.GetObject("BtnPomodoro.Image")));
            this.BtnPomodoro.Location = new System.Drawing.Point(0, 373);
            this.BtnPomodoro.Name = "BtnPomodoro";
            this.BtnPomodoro.Size = new System.Drawing.Size(276, 49);
            this.BtnPomodoro.TabIndex = 1;
            this.BtnPomodoro.Text = "Pomodoro     ";
            this.BtnPomodoro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPomodoro.UseVisualStyleBackColor = false;
            this.BtnPomodoro.Click += new System.EventHandler(this.BtnPomodoro_Click);
            this.BtnPomodoro.MouseEnter += new System.EventHandler(this.HoverEffect);
            this.BtnPomodoro.MouseLeave += new System.EventHandler(this.HoverEffectExit);
            // 
            // BtnMain
            // 
            this.BtnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMain.FlatAppearance.BorderSize = 0;
            this.BtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMain.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.BtnMain.ForeColor = System.Drawing.Color.White;
            this.BtnMain.Image = ((System.Drawing.Image)(resources.GetObject("BtnMain.Image")));
            this.BtnMain.Location = new System.Drawing.Point(3, 318);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(273, 49);
            this.BtnMain.TabIndex = 0;
            this.BtnMain.Text = "Main              ";
            this.BtnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMain.UseVisualStyleBackColor = false;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            this.BtnMain.MouseEnter += new System.EventHandler(this.HoverEffect);
            this.BtnMain.MouseLeave += new System.EventHandler(this.HoverEffectExit);
            // 
            // MainDisplayPN
            // 
            this.MainDisplayPN.BackColor = System.Drawing.Color.White;
            this.MainDisplayPN.Location = new System.Drawing.Point(274, 36);
            this.MainDisplayPN.Name = "MainDisplayPN";
            this.MainDisplayPN.Size = new System.Drawing.Size(788, 687);
            this.MainDisplayPN.TabIndex = 2;
            // 
            // PnTop
            // 
            this.PnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.PnTop.Controls.Add(this.BtnMinimize);
            this.PnTop.Controls.Add(this.BtnExit);
            this.PnTop.Location = new System.Drawing.Point(-3, 0);
            this.PnTop.Name = "PnTop";
            this.PnTop.Size = new System.Drawing.Size(1065, 37);
            this.PnTop.TabIndex = 3;
            this.PnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseDown);
            this.PnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseMove);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.Location = new System.Drawing.Point(975, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(42, 37);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1023, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(42, 37);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 723);
            this.Controls.Add(this.NavBarPN);
            this.Controls.Add(this.PnTop);
            this.Controls.Add(this.MainDisplayPN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavBarPN.ResumeLayout(false);
            this.NavBarPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBarPN;
        private System.Windows.Forms.Button BtnPomodoro;
        private System.Windows.Forms.Button BtnMain;
        private System.Windows.Forms.Panel MainDisplayPN;
        private System.Windows.Forms.Button BtnConfiguration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel PnTop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
    }
}


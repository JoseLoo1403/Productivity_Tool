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
            this.BtnPomodoro = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.MainDisplayPN = new System.Windows.Forms.Panel();
            this.NavBarPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBarPN
            // 
            this.NavBarPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.NavBarPN.Controls.Add(this.BtnPomodoro);
            this.NavBarPN.Controls.Add(this.BtnMain);
            this.NavBarPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBarPN.Location = new System.Drawing.Point(0, 0);
            this.NavBarPN.Name = "NavBarPN";
            this.NavBarPN.Size = new System.Drawing.Size(316, 664);
            this.NavBarPN.TabIndex = 1;
            // 
            // BtnPomodoro
            // 
            this.BtnPomodoro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPomodoro.FlatAppearance.BorderSize = 0;
            this.BtnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPomodoro.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPomodoro.ForeColor = System.Drawing.Color.White;
            this.BtnPomodoro.Image = ((System.Drawing.Image)(resources.GetObject("BtnPomodoro.Image")));
            this.BtnPomodoro.Location = new System.Drawing.Point(0, 224);
            this.BtnPomodoro.Name = "BtnPomodoro";
            this.BtnPomodoro.Size = new System.Drawing.Size(316, 49);
            this.BtnPomodoro.TabIndex = 1;
            this.BtnPomodoro.Text = "Pomodoro";
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
            this.BtnMain.Location = new System.Drawing.Point(0, 176);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(316, 49);
            this.BtnMain.TabIndex = 0;
            this.BtnMain.Text = "Main        ";
            this.BtnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMain.UseVisualStyleBackColor = false;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            this.BtnMain.MouseEnter += new System.EventHandler(this.HoverEffect);
            this.BtnMain.MouseLeave += new System.EventHandler(this.HoverEffectExit);
            // 
            // MainDisplayPN
            // 
            this.MainDisplayPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDisplayPN.Location = new System.Drawing.Point(316, 0);
            this.MainDisplayPN.Name = "MainDisplayPN";
            this.MainDisplayPN.Size = new System.Drawing.Size(858, 664);
            this.MainDisplayPN.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 664);
            this.Controls.Add(this.MainDisplayPN);
            this.Controls.Add(this.NavBarPN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Study-Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavBarPN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBarPN;
        private System.Windows.Forms.Button BtnPomodoro;
        private System.Windows.Forms.Button BtnMain;
        private System.Windows.Forms.Panel MainDisplayPN;
    }
}


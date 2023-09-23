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
            this.NavBarPN = new System.Windows.Forms.Panel();
            this.BtnPomodoro = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.MainDisplayPN = new System.Windows.Forms.Panel();
            this.NavBarPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBarPN
            // 
            this.NavBarPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NavBarPN.Controls.Add(this.BtnPomodoro);
            this.NavBarPN.Controls.Add(this.BtnMain);
            this.NavBarPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBarPN.Location = new System.Drawing.Point(0, 0);
            this.NavBarPN.Name = "NavBarPN";
            this.NavBarPN.Size = new System.Drawing.Size(181, 546);
            this.NavBarPN.TabIndex = 1;
            // 
            // BtnPomodoro
            // 
            this.BtnPomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.BtnPomodoro.FlatAppearance.BorderSize = 0;
            this.BtnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPomodoro.Location = new System.Drawing.Point(0, 199);
            this.BtnPomodoro.Name = "BtnPomodoro";
            this.BtnPomodoro.Size = new System.Drawing.Size(181, 49);
            this.BtnPomodoro.TabIndex = 1;
            this.BtnPomodoro.Text = "Pomodoro";
            this.BtnPomodoro.UseVisualStyleBackColor = false;
            this.BtnPomodoro.Click += new System.EventHandler(this.BtnPomodoro_Click);
            // 
            // BtnMain
            // 
            this.BtnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.BtnMain.FlatAppearance.BorderSize = 0;
            this.BtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMain.Location = new System.Drawing.Point(0, 151);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(181, 49);
            this.BtnMain.TabIndex = 0;
            this.BtnMain.Text = "Main";
            this.BtnMain.UseVisualStyleBackColor = false;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // MainDisplayPN
            // 
            this.MainDisplayPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDisplayPN.Location = new System.Drawing.Point(181, 0);
            this.MainDisplayPN.Name = "MainDisplayPN";
            this.MainDisplayPN.Size = new System.Drawing.Size(485, 546);
            this.MainDisplayPN.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 546);
            this.Controls.Add(this.MainDisplayPN);
            this.Controls.Add(this.NavBarPN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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


namespace Productivity_Tool.Forms
{
    partial class TasksView
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
            this.LblNameAdd = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CbTasks = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTaskName = new System.Windows.Forms.TextBox();
            this.PgTaskByMonth = new LiveCharts.WinForms.PieChart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNewName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNameAdd
            // 
            this.LblNameAdd.AutoSize = true;
            this.LblNameAdd.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.LblNameAdd.Location = new System.Drawing.Point(127, 96);
            this.LblNameAdd.Name = "LblNameAdd";
            this.LblNameAdd.Size = new System.Drawing.Size(66, 25);
            this.LblNameAdd.TabIndex = 17;
            this.LblNameAdd.Text = "Name:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.BtnAdd.Location = new System.Drawing.Point(564, 127);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(80, 34);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CbTasks
            // 
            this.CbTasks.BackColor = System.Drawing.Color.Transparent;
            this.CbTasks.BorderRadius = 10;
            this.CbTasks.BorderThickness = 2;
            this.CbTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTasks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTasks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTasks.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.8F);
            this.CbTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbTasks.ItemHeight = 30;
            this.CbTasks.Location = new System.Drawing.Point(205, 214);
            this.CbTasks.Name = "CbTasks";
            this.CbTasks.Size = new System.Drawing.Size(439, 36);
            this.CbTasks.TabIndex = 18;
            this.CbTasks.SelectedIndexChanged += new System.EventHandler(this.CbTasks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(141, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Task:";
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTaskName.Font = new System.Drawing.Font("Nirmala UI Semilight", 12.8F);
            this.TxtTaskName.Location = new System.Drawing.Point(199, 88);
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Size = new System.Drawing.Size(445, 29);
            this.TxtTaskName.TabIndex = 20;
            // 
            // PgTaskByMonth
            // 
            this.PgTaskByMonth.BackColor = System.Drawing.Color.Black;
            this.PgTaskByMonth.BackColorTransparent = true;
            this.PgTaskByMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PgTaskByMonth.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PgTaskByMonth.Location = new System.Drawing.Point(245, 342);
            this.PgTaskByMonth.Name = "PgTaskByMonth";
            this.PgTaskByMonth.Size = new System.Drawing.Size(386, 302);
            this.PgTaskByMonth.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.8F);
            this.label2.Location = new System.Drawing.Point(257, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Division of time investment in the month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(97, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Update task:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(82, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Add new task:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.BtnUpdate.Location = new System.Drawing.Point(548, 291);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(96, 34);
            this.BtnUpdate.TabIndex = 27;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tasks";
            // 
            // TxtNewName
            // 
            this.TxtNewName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNewName.Enabled = false;
            this.TxtNewName.Font = new System.Drawing.Font("Nirmala UI Semilight", 12.8F);
            this.TxtNewName.Location = new System.Drawing.Point(205, 256);
            this.TxtNewName.MaxLength = 40;
            this.TxtNewName.Name = "TxtNewName";
            this.TxtNewName.Size = new System.Drawing.Size(439, 29);
            this.TxtNewName.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.label6.Location = new System.Drawing.Point(91, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "New Name:";
            this.label6.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.BtnDelete.Location = new System.Drawing.Point(446, 291);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(96, 34);
            this.BtnDelete.TabIndex = 31;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtNewName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PgTaskByMonth);
            this.Controls.Add(this.TxtTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbTasks);
            this.Controls.Add(this.LblNameAdd);
            this.Controls.Add(this.BtnAdd);
            this.Name = "TasksView";
            this.Size = new System.Drawing.Size(812, 709);
            this.Load += new System.EventHandler(this.TasksView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNameAdd;
        private System.Windows.Forms.Button BtnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox CbTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTaskName;
        private LiveCharts.WinForms.PieChart PgTaskByMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnDelete;
    }
}

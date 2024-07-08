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
            this.MonthGraph = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNameAdd
            // 
            this.LblNameAdd.AutoSize = true;
            this.LblNameAdd.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.LblNameAdd.Location = new System.Drawing.Point(38, 85);
            this.LblNameAdd.Name = "LblNameAdd";
            this.LblNameAdd.Size = new System.Drawing.Size(62, 25);
            this.LblNameAdd.TabIndex = 17;
            this.LblNameAdd.Text = "Name:";
            this.LblNameAdd.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.BtnAdd.Location = new System.Drawing.Point(25, 20);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(99, 43);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "New task";
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
            this.CbTasks.Location = new System.Drawing.Point(83, 288);
            this.CbTasks.Name = "CbTasks";
            this.CbTasks.Size = new System.Drawing.Size(301, 36);
            this.CbTasks.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.8F);
            this.label1.Location = new System.Drawing.Point(25, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Task:";
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTaskName.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F);
            this.TxtTaskName.Location = new System.Drawing.Point(106, 85);
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Size = new System.Drawing.Size(287, 24);
            this.TxtTaskName.TabIndex = 20;
            this.TxtTaskName.Visible = false;
            // 
            // MonthGraph
            // 
            this.MonthGraph.BackColorTransparent = true;
            this.MonthGraph.Location = new System.Drawing.Point(25, 330);
            this.MonthGraph.Name = "MonthGraph";
            this.MonthGraph.Size = new System.Drawing.Size(745, 357);
            this.MonthGraph.TabIndex = 21;
            this.MonthGraph.Visible = false;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(495, 56);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(275, 238);
            this.pieChart1.TabIndex = 22;
            this.pieChart1.Text = "pieChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.8F);
            this.label2.Location = new System.Drawing.Point(570, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Time by task";
            // 
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.MonthGraph);
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
        private LiveCharts.WinForms.CartesianChart MonthGraph;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label2;
    }
}

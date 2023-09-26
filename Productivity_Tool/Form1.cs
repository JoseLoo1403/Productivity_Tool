using System;
using System.Drawing;
using System.Windows.Forms;
using Productivity_Tool.Forms;

namespace Productivity_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.Add(m);
            m.Show();
        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            Pomodoro f = new Pomodoro();
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void HoverEffect(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.FromArgb(29, 93, 130);
        }

        private void HoverEffectExit(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.FromArgb(8, 65, 92);
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            Configuration f = new Configuration();
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }
    }
}

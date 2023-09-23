using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pomodoro m = new Pomodoro();
            this.MainDisplayPN.Controls.Add(m);
            m.Show();
        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            Pomodoro f = new Pomodoro();
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productivity_Tool.Helpers;

namespace Productivity_Tool.Forms
{
    public partial class Pomodoro : UserControl
    {
        TimerObj time;
        public Pomodoro()
        {
            InitializeComponent();
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            time = new TimerObj();
            TimerBar.Value = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerBar.Value += 1;
            TimerBar.Text = time.AddTime();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

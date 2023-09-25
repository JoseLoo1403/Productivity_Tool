using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;
using Data.Entities;
using Productivity_Tool.Helpers;

namespace Productivity_Tool.Forms
{
    public partial class Pomodoro : UserControl
    {
        TimerObj BarTime;
        TimerObj StudyTime;
        TimerObj RestTime;
        int Mode = 0;  // 0 = study    1 = rest

        private void ReloadTimer()
        {
            TimerBar.Value = 0;
            TimerBar.Refresh();
            TimerBar.Text = "00:00:00";

            BarTime = new TimerObj(0,0);
        }

        private void LoadStudyConfigurations()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            int[] temp = repo.GetConfigurationValueByName("Study Time");

            StudyTime.Hour = temp[0];
            StudyTime.Minute = temp[1];
            StudyTime.Seconds = temp[2];

            temp = repo.GetConfigurationValueByName("Rest Time");

            RestTime.Hour = temp[0];
            RestTime.Minute = temp[1];
            RestTime.Seconds = temp[2];
        }

        public Pomodoro()
        {
            InitializeComponent();
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            StudyTime = new TimerObj(0, 0);
            RestTime = new TimerObj(0, 0);
            BarTime = new TimerObj(0,0);
            TimerBar.Value = 0;

            LoadStudyConfigurations();

            TimerBar.Maximum = StudyTime.GetTotalSeconds();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if(BtnStop.Text == "Restart")
            {
                BtnStop.Text = "Stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerBar.Value += 1;
            TimerBar.Text = BarTime.AddTime();

            if(Mode == 0 )
            {
                if (BarTime.Hour == StudyTime.Hour && BarTime.Minute == StudyTime.Minute)
                {
                    TimerBar.Maximum = StudyTime.GetTotalSeconds();
                    ReloadTimer();
                }
            }
            else if (Mode == 1)
            {
                if (BarTime.Hour == RestTime.Hour && BarTime.Minute == RestTime.Minute)
                {
                    TimerBar.Maximum = RestTime.GetTotalSeconds();
                    ReloadTimer();
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if(BtnStop.Text == "Stop" && timer1.Enabled)
            {
                timer1.Stop();
                BtnStop.Text = "Restart";
            }
            else
            {
                TimerBar.Value = 0;
                BtnStop.Text = "Stop";
                ReloadTimer();
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {

        }
    }
}

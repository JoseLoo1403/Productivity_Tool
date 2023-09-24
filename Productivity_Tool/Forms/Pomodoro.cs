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

        public Pomodoro()
        {
            InitializeComponent();
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            BarTime = new TimerObj(0,0);
            TimerBar.Value = 0;

            StudyTime = new TimerObj(0,2);
            RestTime = new TimerObj(0,1);

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

            if(LblStudy.Visible == true)
            {
                LblStudy.Visible = false;
                TxtHourStudy.Visible = false;
                TxtMinuteStudy.Visible = false;

                LblRest.Visible = false;
                TxtHourRest.Visible = false;
                TxtMinuteRest.Visible = false;

                BtnApply.Visible = false;
            }
            else
            {
                LblStudy.Visible = true;
                TxtHourStudy.Visible = true;
                TxtMinuteStudy.Visible = true;

                LblRest.Visible = true;
                TxtHourRest.Visible = true;
                TxtMinuteRest.Visible = true;

                BtnApply.Visible = true;
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

        }
    }
}

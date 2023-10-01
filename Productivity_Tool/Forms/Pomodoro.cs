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
using Productivity_Tool.Helpers;
using System.Media;

namespace Productivity_Tool.Forms
{
    public partial class Pomodoro : UserControl
    {
        TimerObj BarTime;
        TimerObj StudyTime;
        TimerObj RestTime;
        int Mode = 0;  // 0 = study    1 = rest
        bool WaitSecond;
        string Message;
        int StrIndex;
        SoundPlayer sound;

        int CurrentSessionCount = 0;
        int GoalCount = 3;

        private void ReloadTimer()
        {
            TimerBar.Value = 0;
            TimerBar.Refresh();
            TimerBar.Text = "00:00:00";

            BarTime = new TimerObj(0,0);
        }

        private void RefreshCounter()
        {
            LblSessionCount.Text = $"{CurrentSessionCount}/{GoalCount}";
        }

        private void SendMessage(string text)
        {
            Message = text;
            LblMessage.Text = string.Empty;
            StrIndex = 0;
            AnimationTimer.Start();
        }

        private void SaveStudyTime()
        {
            StudySessionsRepository repo = new StudySessionsRepository();

            repo.AddTimeToSession(DateTime.Today.ToString("yyyy/MM/dd"), StudyTime.Hour, StudyTime.Minute, StudyTime.Seconds);

            ConfigurationRepository con = new ConfigurationRepository();

            con.UpdateConfigurationByName("Current count", CurrentSessionCount.ToString());
        }

        private void LoadStudyConfigurations()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            int[] temp = repo.GetConfigurationTimeByName("Study Time");

            StudyTime.Hour = temp[0];
            StudyTime.Minute = temp[1];
            StudyTime.Seconds = temp[2];

            temp = repo.GetConfigurationTimeByName("Rest Time");

            RestTime.Hour = temp[0];
            RestTime.Minute = temp[1];
            RestTime.Seconds = temp[2];

            LblStudyInfo.Text = $"Study time {StudyTime.GetTimeFormat()}";
            LblRestInfo.Text = $"Rest Time {RestTime.GetTimeFormat()}";


            GoalCount = Convert.ToInt32(repo.GetConfigurationValueByName("Session Goal"));
            CurrentSessionCount = Convert.ToInt32(repo.GetConfigurationValueByName("Current count"));

            SendMessage("Lets study!");
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
            WaitSecond = false;

            RefreshCounter();
            sound = new SoundPlayer(@".\Sound\Stop_Sound.wav");
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (CurrentSessionCount >= GoalCount)
            {
                BtnStop.Enabled = true;
                BtnStart.Text = "Start";
                CurrentSessionCount = 0;
                ReloadTimer();

                ConfigurationRepository repo = new ConfigurationRepository();

                repo.UpdateConfigurationByName("Current count", "0");

                RefreshCounter();
                Mode = 0;
            }

            timer1.Start();

            if (BtnStop.Text == "Restart")
            {
                BtnStop.Text = "Stop";
            }

            if (BtnStart.Enabled == true)
            {
                BtnStart.Enabled = false;
            }
            else
            {
                BtnStart.Enabled = true;
            }

            if (Mode == 0)
            {
                SendMessage("Study...");
            }
            else
            {
                SendMessage("Rest...");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!WaitSecond)
            {
                TimerBar.Value += 1;
                TimerBar.Text = BarTime.AddTime();
            }
            
            if(Mode == 0 )
            {
                if (TimerBar.Value == TimerBar.Maximum)
                {
                    if(WaitSecond)
                    {
                        Mode = 1;
                        TimerBar.Maximum = RestTime.GetTotalSeconds();
                        ReloadTimer();
                        SaveStudyTime();
                        SendMessage("Rest...");
                        sound.Play();

                        TimerBar.ProgressColor = Color.FromArgb(26, 117, 255);

                        WaitSecond = false;
                    }
                    else
                    {
                        CurrentSessionCount++;
                        RefreshCounter();

                        WaitSecond = true;

                        if (CurrentSessionCount == GoalCount)
                        {
                            timer1.Stop();
                            SendMessage($"Sessions Completed {CurrentSessionCount}/{GoalCount}");
                            BtnStop.Enabled = false;
                            BtnStart.Enabled = true;
                            BtnStart.Text = "Restart sessions";
                            SaveStudyTime();
                            WaitSecond = false;
                        }
                    }
                }
            }
            else if (Mode == 1)
            {
                if (TimerBar.Value == TimerBar.Maximum)
                {
                    if(WaitSecond)
                    {
                        Mode = 0;
                        TimerBar.Maximum = StudyTime.GetTotalSeconds();
                        ReloadTimer();

                        TimerBar.ProgressColor = Color.FromArgb(255, 128, 0);

                        SendMessage("Study...");
                        WaitSecond = false;
                    }
                    else
                    {
                        WaitSecond = true;
                    }
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if(BtnStop.Text == "Stop" && timer1.Enabled)
            {
                timer1.Stop();
                BtnStop.Text = "Restart";
                BtnStart.Enabled = true;
                BtnStart.Text = "Continue";
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
            if (LblStudyInfo.Visible == true)
            {
                LblStudyInfo.Visible = false;
                LblRestInfo.Visible = false;
            }
            else
            {
                LblStudyInfo.Visible = true;
                LblRestInfo.Visible = true;
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (StrIndex < Message.Length)
            {
                LblMessage.Text += Message[StrIndex];
                StrIndex++;
            }
            else
            {
                AnimationTimer.Stop();
            }
        }
    }
}

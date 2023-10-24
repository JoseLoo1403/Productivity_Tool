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
using Productivity_Tool.Properties;

namespace Productivity_Tool.Forms
{
    public partial class Pomodoro : UserControl
    {
        TimerObj BarTime;
        TimerObj Temp_Timer;
        TimerObj StudyTime;
        TimerObj RestTime;
        int Mode = 0;  // 0 = study    1 = rest
        bool WaitSecond;
        string Message;
        int StrIndex;
        SoundPlayer Stop_Sound;
        GlobalContextInfo ContextInfo;
        bool Zen = false;

        int CurrentSessionCount = 0;
        int GoalCount = 3;

        private void ReloadTimer()
        {
            TimerBar.Value = 0;
            TimerBar.Refresh();
            TimerBar.Text = "00:00:00";

            BarTime.ResetTime();
            Temp_Timer.ResetTime();
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

        private void RestartSession()
        {
            CurrentSessionCount = 0;
            ReloadTimer();

            ConfigurationRepository repo = new ConfigurationRepository();

            repo.UpdateConfigurationByName("Current count", "0");

            RefreshCounter();
            Mode = 0;
        }

        private void SaveCurrentInfoInContext()
        {
            ContextInfo.CurrentTime = BarTime;
            ContextInfo.Mode = Mode;
            ContextInfo.PomodoroValue = TimerBar.Value;
        }

        private void SaveStudyTime()
        {
            var time = Temp_Timer;

            StudySessionsRepository repo = new StudySessionsRepository();

            repo.AddTimeToSession(DateTime.Today.ToString("yyyy/MM/dd"), time.Hour, time.Minute, time.Seconds);

            ConfigurationRepository con = new ConfigurationRepository();

            con.UpdateConfigurationByName("Current count", CurrentSessionCount.ToString());

            Temp_Timer.ResetTime();
        }

        private void LoadPresavedInformation()
        {
            BarTime = ContextInfo.CurrentTime != null ? ContextInfo.CurrentTime : new TimerObj(0, 0);
            Mode = ContextInfo.Mode;

            if (Mode == 0)
            {
                TimerBar.Maximum = StudyTime.GetTotalSeconds();
            }
            else
            {
                TimerBar.Maximum = RestTime.GetTotalSeconds();
                TimerBar.ProgressColor = Color.FromArgb(26, 117, 255);
            }

            if (ContextInfo.CurrentTime != null)
            {
                TimerBar.Text = ContextInfo.CurrentTime.GetTimeFormat();
            }

            TimerBar.Value = ContextInfo.PomodoroValue;

            if (TimerBar.Value > 0)
            {
                BtnStop.Text = "Restart";
            }
            else
            {
                BtnStop.Enabled = false;
            }
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

        public Pomodoro(GlobalContextInfo contextInfo)
        {
            InitializeComponent();
            ContextInfo = contextInfo;
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            StudyTime = new TimerObj(0, 0);
            RestTime = new TimerObj(0, 0);
            Temp_Timer = new TimerObj(0,0);

            LoadStudyConfigurations();
            LoadPresavedInformation();
            WaitSecond = false;

            RefreshCounter();
            Stop_Sound = new SoundPlayer(@".\Sound\Stop_Sound.wav");
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (CurrentSessionCount >= GoalCount)
            {
                BtnStart.Text = "Start";

                RestartSession();
            }

            timer1.Start();

            BtnStop.Text = "Stop";
            BtnStop.Enabled = true;
            BtnStart.Enabled = false;
            BtnRestartCount.Enabled = false;

            if (Mode == 0)
            {
                SendMessage("Study...");
            }
            else
            {
                SendMessage("Rest...");
            }

            ContextInfo.EnableBaseInterface(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!WaitSecond && TimerBar.Maximum > TimerBar.Value)
            {
                TimerBar.Value += 1;
                if (Mode == 0) 
                {
                    Temp_Timer.AddTime();
                }
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
                        SaveStudyTime();
                        ReloadTimer();
                        SendMessage("Rest...");
                        Stop_Sound.Play();

                        TimerBar.ProgressColor = Color.FromArgb(26, 117, 255);

                        WaitSecond = false;
                    }
                    else
                    {
                        CurrentSessionCount++;
                        RefreshCounter();

                        WaitSecond = true;

                        if (CurrentSessionCount == GoalCount) //Study session completed
                        {
                            timer1.Stop();
                            SendMessage($"Sessions Completed {CurrentSessionCount}/{GoalCount}");
                            BtnStop.Enabled = false;
                            BtnStart.Enabled = true;
                            BtnStart.Text = "Restart sessions";
                            SaveStudyTime();
                            WaitSecond = false;
                            ContextInfo.EnableBaseInterface(true);
                            SaveCurrentInfoInContext();
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
                        Stop_Sound.Play();

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
                BtnConfig.Enabled = true;
                BtnStart.Text = "Continue";
                SaveStudyTime();
                BtnRestartCount.Enabled = true;
            }
            else
            {
                TimerBar.Value = 0;
                BtnStop.Text = "Stop";
                BtnStop.Enabled = false;
                ReloadTimer();
            }

            ContextInfo.EnableBaseInterface(true);
            SaveCurrentInfoInContext();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            if (LblStudyInfo.Visible == true)
            {
                LblStudyInfo.Visible = false;
                LblRestInfo.Visible = false;
                BtnRestartCount.Visible = false;
            }
            else
            {
                LblStudyInfo.Visible = true;
                LblRestInfo.Visible = true;
                BtnRestartCount.Visible = true;
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

        private void BtnRestartCount_Click(object sender, EventArgs e)
        {
            CurrentSessionCount = 0;
            ContextInfo.CurrentCount = 0;
            Mode = 0;

            TimerBar.Maximum = StudyTime.GetTotalSeconds();
            TimerBar.ProgressColor = Color.FromArgb(255, 128, 0);
            SendMessage("Lets study!");

            RestartSession();
            BtnStart.Text = "Start";
            BtnStop.Text = "Stop";
            BtnStop.Enabled = false;
        }

        private void BtnZenMode_Click(object sender, EventArgs e)
        {
            if (Zen)
            {
                //Stop zen mode
                BtnZenMode.Image = Properties.Resources.eye_open;
                Zen = false;
                ContextInfo.ZenModeInvoke(false);
            }
            else
            {
                //Activate zen mode
                BtnZenMode.Image = Properties.Resources.eye_close1;
                Zen = true;
                ContextInfo.ZenModeInvoke(true);
            }
        }
    }
}

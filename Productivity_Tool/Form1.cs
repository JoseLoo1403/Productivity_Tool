using System;
using System.Drawing;
using System.Windows.Forms;
using Productivity_Tool.Forms;
using Data.Repositories;
using Data.Entities;
using System.Linq;
using Productivity_Tool.Helpers;

namespace Productivity_Tool
{
    public partial class Form1 : Form
    {
        //Global variables
        public Point mouseLocation;
        GlobalContextInfo ContextInfo { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMonthSessionIfApplies()
        {
            ConfigurationRepository config = new ConfigurationRepository();
            MonthSessionRepository repo = new MonthSessionRepository();

            if (config.GetConfigurationValueByName("Month Update") != DateTime.Today.Month.ToString())
            {
                repo.CreateNewMonthSession();
                config.UpdateConfigurationByName("Month Update", DateTime.Today.Month.ToString());
            }

            ContextInfo.MonthId = repo.GetLastId();
        }

        private void MakeTodaySession()
        {
            CreateMonthSessionIfApplies();
            StudySessionsRepository repo = new StudySessionsRepository();
            ConfigurationRepository config = new ConfigurationRepository();

            if (config.GetConfigurationValueByName("Streak Update") != DateTime.Now.ToString("yyyy/MM/dd"))
            {
                DateTime now = DateTime.Now;
                now = now.AddDays(-1);

                StudySessions yesturday = repo.GetStudySessionByDate(now.ToString("yyyy/MM/dd"));

                if (yesturday != null)
                {
                    config.AddDayStreak();
                }
                else
                {
                    config.UpdateConfigurationByName("Day Streak", "0");
                }

                config.UpdateConfigurationByName("Streak Update", DateTime.Now.ToString("yyyy/MM/dd"));
            }

            ContextInfo.CurrentDate = DateTime.Today;
            repo.CreateSessionIfApplies(ContextInfo.MonthId);
        }

        private void EnableButtons(object sender, bool arg)
        {
            BtnConfiguration.Enabled = arg;
            BtnMain.Enabled = arg;
            BtnPomodoro.Enabled = arg;
        }

        private void ZenModeEventHandler(object sender, bool e)
        {
            //Zen mode visual configurations
            if (e)
            {
                this.WindowState = FormWindowState.Maximized;
                MainDisplayPN.Dock = DockStyle.Fill;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MainDisplayPN.Dock = DockStyle.None;
            }

        }
        
        private void CreateNewSessionEventHandler(object sender, bool e)
        {
            MakeTodaySession();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            if (this.MainDisplayPN.Controls[0].Name == "Main")
            {
                return;
            }

            Main f = new Main();
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextInfo = new GlobalContextInfo();
            MakeTodaySession();

            Main m = new Main();
            m.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.Add(m);
            m.Show();

            //Events
            ContextInfo.EnableBaseInterfaceEvent += EnableButtons;
            ContextInfo.ZenModeEvent += ZenModeEventHandler;
            ContextInfo.CreateNewSessionEvent += CreateNewSessionEventHandler;
        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            if (this.MainDisplayPN.Controls[0].Name == "Pomodoro")
            {
                return;
            }

            Pomodoro f = new Pomodoro(ContextInfo);
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            if (this.MainDisplayPN.Controls[0].Name == "Configuration")
            {
                return;
            }

            Configuration f = new Configuration();
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void PnTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void PnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

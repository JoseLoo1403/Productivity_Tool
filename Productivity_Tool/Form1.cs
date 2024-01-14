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

        private void MakeTodaySession()
        {
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
            repo.CreateSessionIfApplies();
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

            ContextInfo = new GlobalContextInfo();
            MakeTodaySession();

            //Events
            ContextInfo.EnableBaseInterfaceEvent += EnableButtons;
            ContextInfo.ZenModeEvent += ZenModeEventHandler;
            ContextInfo.CreateNewSessionEvent += CreateNewSessionEventHandler;
        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            Pomodoro f = new Pomodoro(ContextInfo);
            f.Dock = DockStyle.Fill;
            this.MainDisplayPN.Controls.RemoveAt(0);
            this.MainDisplayPN.Controls.Add(f);
            f.Show();
        }

        private void HoverEffect(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.FromArgb(8, 92, 175);
        }

        private void HoverEffectExit(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.FromArgb(5, 74, 145);
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
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

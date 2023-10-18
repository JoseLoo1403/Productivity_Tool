using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Data.Entities;
using Data.Repositories;
using Productivity_Tool.Helpers;

namespace Productivity_Tool.Forms
{
    public partial class Main : UserControl
    {
        StudySessions CurrentSession;
        public Main()
        {
            InitializeComponent();
        }

        private List<StudySessions> GetAllSessions()
        {
            StudySessionsRepository studySessionsRepository = new StudySessionsRepository();

            return studySessionsRepository.GetAllStudySessions();
        }

        private double ConvertToHoursValue(string s)
        {
            string[] t = s.Split(':');

            double TotalHours = Convert.ToDouble(t[0]) + (Convert.ToDouble(t[1]) / 60) + (Convert.ToDouble(t[2])/3600);

            return TotalHours;
        }

        private void CreateFormatData()
        {
            List<StudySessions> studySessions = GetAllSessions();
            List<SessionModel> finalTable = new List<SessionModel>();
            List<SessionModel> formatS = new List<SessionModel>();

            CurrentSession = studySessions.LastOrDefault();

            foreach (var x in studySessions)
            {
                formatS.Add(new SessionModel(x.Date, ConvertToHoursValue(x.Time)));
            }

            DateTime Index = formatS.FirstOrDefault().Date;

            foreach (var x in formatS)
            {
                if (Index == x.Date)
                {
                    finalTable.Add(x);
                }
                else
                {
                    while(Index != x.Date)
                    {
                        finalTable.Add(new SessionModel(Index.ToString("yyyy/MM/dd"), 0));
                        Index = Index.AddDays(1);
                    }
                }

                Index = Index.AddDays(1);
            }

            foreach (var x in finalTable)
            {
                ChDailyInfo.Series["Study Hours"].Points.AddXY(x.Date.ToString("yyyy/MM/dd"),x.Time);
            }
        }

        private void LoadGoal()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            string Goal, Count;
            Goal = repo.GetConfigurationValueByName("Session Goal");
            Count = repo.GetConfigurationValueByName("Current count");


            GoalBar.Maximum = Convert.ToInt32(Goal);
            GoalBar.Value = Convert.ToInt32(Count);
            GoalBar.Text = $"{Count}/{Goal}";
            LblTodayTime.Text = "Today's Study Time: " + CurrentSession.Time;
            GoalBar.Refresh();
        }

        private void LoadDayStreak()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            LblStreak.Text = "Day-Streak: " + repo.GetConfigurationValueByName("Day Streak");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateFormatData();
            LoadDayStreak();
            LoadGoal();
        }
    }
}

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
using LiveCharts.Wpf;
using LiveCharts;
using Productivity_Tool.Helpers;
using LiveCharts.Defaults;

namespace Productivity_Tool.Forms
{
    public partial class Main : UserControl
    {
        StudySessions CurrentSession;
        MonthSession CurrentmonthSession;
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
            MonthSessionRepository repo = new MonthSessionRepository();

            CurrentSession = studySessions.LastOrDefault();
            CurrentmonthSession = repo.GetSessionByDate(DateTime.Now.ToString("yyyy/MM"));

            List<string> format = repo.GetDates();

            foreach (string x in format)
            {
                CbMonth.Items.Add(x);
            }

            CbMonth.Text = DateTime.Today.ToString("yyyy/MM");
        }

        private void LoadGraphData(string date)
        {
            List<StudySessions> studySessions = GetAllSessions();
            MonthSessionRepository repo = new MonthSessionRepository();
            MonthSession SelectedMonth = repo.GetSessionByDate(date); 
            List<SessionModel> finalTable = new List<SessionModel>();
            List<SessionModel> formatS = new List<SessionModel>();
            List<string> Days = new List<string>();
            ChartValues<double> studytime = new ChartValues<double>(); 


            LblSelectedMonth.Text = "Month time: " + SelectedMonth.TotalTime;

            foreach (var x in studySessions)
            {
                if (x.MonthId == SelectedMonth.Id)
                {
                    formatS.Add(new SessionModel(x.Date, ConvertToHoursValue(x.Time)));
                    Days.Add($"{x.Date[8]}{x.Date[9]}");
                }
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
                    while (Index < x.Date)
                    {
                        finalTable.Add(new SessionModel(Index.ToString("yyyy/MM/dd"), 0));
                        Index = Index.AddDays(1);
                    }

                    finalTable.Add(x);
                }

                Index = Index.AddDays(1);
            }

            foreach (var x in finalTable)
            {
                studytime.Add(x.Time);
                Days.Add(x.Date.ToString("dd"));
            }

            MonthGraph.Series.Clear();

            MonthGraph.Series.Add(new LineSeries
            {
                Values = studytime,
                PointGeometrySize = 7,
                Title = "Study hours: "
            });

            MonthGraph.AxisY.Clear();

            MonthGraph.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Hours",
                LabelFormatter = value => value.ToString("N2"),
                MinValue = 0
            });
        }

        private void LoadGoal()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            int Goal, Count;
            Goal = Convert.ToInt32(repo.GetConfigurationValueByName("Session Goal"));
            Count = Convert.ToInt32(repo.GetConfigurationValueByName("Current count"));

            if (Goal >= Count)
            {
                GoalBar.Maximum = Goal;
                GoalBar.Value = Count;
            }
            else
            {

                GoalBar.Maximum = Goal;
                GoalBar.Value = Goal;
            }

            GoalBar.Text = $"{Count}/{Goal}";
            LblTodayTime.Text = "Today's Study Time: " + CurrentSession.Time;
            LblMonthTime.Text = "Month Study Time: " + CurrentmonthSession.TotalTime;
            GoalBar.Refresh();
        }

        private void LoadDayStreak()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            LblStreak.Text = "Day-Streak: " + repo.GetConfigurationValueByName("Day Streak") + " 🔥";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateFormatData();
            LoadDayStreak();
            LoadGoal();
            LoadGraphData(DateTime.Today.ToString("yyyy/MM"));
            MonthGraph.Visible = true;
        }

        private void CbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGraphData(CbMonth.Text);
        }
    }
}

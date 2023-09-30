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

        private void LoadDataToChart()
        {
            List<StudySessions> studySessions = GetAllSessions();

            CurrentSession = studySessions.LastOrDefault();

            foreach (var x in studySessions)
            {
                ChDailyInfo.Series["Study Hours"].Points.AddXY(x.Date, ConvertToHoursValue(x.Time));
            }
        }

        private void LoadGoal()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            GoalBar.Maximum = Convert.ToInt32(repo.GetConfigurationValueByName("Session Goal"));
            GoalBar.Value = Convert.ToInt32(repo.GetConfigurationValueByName("Current count"));
            GoalBar.Refresh();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadDataToChart();
            LoadGoal();
        }
    }
}

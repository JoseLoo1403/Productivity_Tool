using Data.Repositories;
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

namespace Productivity_Tool.Forms
{
    public partial class Configuration : UserControl
    {
        private void UpdateConfiguration(string Name, string Value)
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            repo.UpdateConfigurationByName(Name, Value);
        }

        private void LoadConfiguration()
        {
            ConfigurationRepository repository = new ConfigurationRepository();

            int[] Times = repository.GetConfigurationTimeByName("Study Time");

            TxtStudyHour.Value = Times[0];
            TxtStudyMinute.Value = Times[1];
            TxtStudySecond.Value = Times[2];

            Times = repository.GetConfigurationTimeByName("Rest Time");

            TxtRestHour.Value = Times[0];
            TxtRestMinute.Value = Times[1];
            TxtRestSecond.Value = Times[2];

            TxtGoal.Value = Convert.ToInt16(repository.GetConfigurationValueByName("Session Goal"));
        }

        private void UploadNewConfigurations()
        {
            //Security
            decimal StudySum = TxtStudyHour.Value + TxtStudyMinute.Value + TxtStudySecond.Value;
            decimal RestSum = TxtRestHour.Value + TxtRestMinute.Value + TxtRestSecond.Value;

            if (StudySum < 1)
            {
                MessageBox.Show("Please insert an amount of time in study time");
                return;
            }

            if (RestSum < 1)
            {
                MessageBox.Show("Please insert an amount of time in rest time");
                return;
            }

            if (TxtGoal.Value < 1)
            {
                MessageBox.Show("Please insert an amount of sets");
                return;
            }

            string StudyValue, RestValue = "";

            StudyValue = $"{TxtStudyHour.Value}:{TxtStudyMinute.Value}:{TxtStudySecond.Value}";
            RestValue = $"{TxtRestHour.Value}:{TxtRestMinute.Value}:{TxtRestSecond.Value}";

            UpdateConfiguration("Study Time", StudyValue);
            UpdateConfiguration("Rest Time", RestValue);
            UpdateConfiguration("Session Goal", TxtGoal.Value.ToString());

            MessageBox.Show("Update been made");
        }

        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            UploadNewConfigurations();
        }
    }
}

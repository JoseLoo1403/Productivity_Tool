using Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_Tool.Forms
{
    public partial class Configuration : UserControl
    {
        private void CleanTextBoxes()
        {
            TxtStudyHour.Text = "00";
            TxtStudyMinute.Text = "00";
            TxtStudySecond.Text = "00";
        }

        private void UpdateConfiguration(string Name, string Value)
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            repo.UpdateByNameConfigurations(Name, Value);
        }

        private void LoadConfiguration()
        {
            ConfigurationRepository repository = new ConfigurationRepository();

            int[] Times = repository.GetConfigurationValueByName("Study Time");

            TxtStudyHour.Value = Times[0];
            TxtStudyMinute.Value = Times[1];
            TxtStudySecond.Value = Times[2];

            Times = repository.GetConfigurationValueByName("Rest Time");

            TxtRestHour.Value = Times[0];
            TxtRestMinute.Value = Times[1];
            TxtRestSecond.Value = Times[2];
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
            string StudyValue,RestValue = "";

            StudyValue = $"{TxtStudyHour.Value}:{TxtStudyMinute.Value}:{TxtStudySecond.Value}";
            RestValue = $"{TxtRestHour.Value}:{TxtRestMinute.Value}:{TxtRestSecond.Value}";

            UpdateConfiguration("Study Time",StudyValue);
            UpdateConfiguration("Rest Time", RestValue);

            //CleanTextBoxes();

            MessageBox.Show("Update been made");
        }
    }
}

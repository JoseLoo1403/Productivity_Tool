using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Entities;
using Data.Repositories;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Productivity_Tool.Helpers;

namespace Productivity_Tool.Forms
{
    public partial class TasksView : UserControl
    {
        List<SessionModel> TableData;
        MonthSession selectedMonth;
        Tasks selectedTask;

        public TasksView()
        {
            InitializeComponent();
        }
        private void TasksView_Load(object sender, EventArgs e)
        {
            LoadInitialTaskInformation();
            LoadGraphInformation();
        }

        private void LoadInitialTaskInformation()
        {
            TaskRepository taskRepository = new TaskRepository();
            List<Tasks> items = taskRepository.GetAllTasks();

            CbTasks.Items.Clear();
            foreach (Tasks item in items) 
            {
                CbTasks.Items.Add(item.Name);
            }
        }

        private double ConvertToHoursValue(string s)
        {
            string[] t = s.Split(':');

            double TotalHours = Convert.ToDouble(t[0]) + (Convert.ToDouble(t[1]) / 60) + (Convert.ToDouble(t[2]) / 3600);

            return TotalHours;
        }

        private TaskSessionModel FormatInfo(int taskId,int monthId, TaskSessionsRepository repo)
        {
            TaskRepository taskRepo = new TaskRepository();

            TaskSessionModel res = new TaskSessionModel(taskRepo.GetTaskById(taskId).Name, 0);

            res.value = repo.GetTotalTimeOfTaskByMonth(monthId, taskId);

            return res;
        }

        private void LoadGraphInformation()
        {
            TaskSessionsRepository repo = new TaskSessionsRepository();
            MonthSessionRepository monthRepo = new MonthSessionRepository();
            TaskRepository taskRepo = new TaskRepository();

            MonthSession CurrentMonth = monthRepo.GetCurrentMonthSession();
            List<int> TasksIds = repo.GetAllTasksIdOfMonth(CurrentMonth.Id);
            List<TaskSessionModel> PieComponents = new List<TaskSessionModel>();

            foreach (var x in TasksIds)
            {
                PieComponents.Add(FormatInfo(x, CurrentMonth.Id, repo));
            }

            PgTaskByMonth.Series.Clear();
            PgTaskByMonth.BackColorTransparent = true;

            foreach (var x in PieComponents)
            {
                PgTaskByMonth.Series.Add(new PieSeries
                {
                    Title = x.Title,
                    Values = new ChartValues<double> { x.value },
                    DataLabels = true,
                    
                });
            }
        }

        public void CreateNewTask() 
        {
            TaskRepository repo = new TaskRepository();

            if (repo.GetTaskByName(TxtTaskName.Text) != null)
            {
                MessageBox.Show("There already exist a task with this name");
                return;
            }

            repo.CreateTask(TxtTaskName.Text);

            MessageBox.Show("Task created!");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtTaskName.Text.Count() == 0)
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }

            CreateNewTask();
            TxtTaskName.Clear();

            LoadInitialTaskInformation();
        }

        private void CbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtNewName.Enabled = true;
            BtnDelete.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TaskRepository repo = new TaskRepository();

            if (CbTasks.Text == TxtNewName.Text)
            {
                MessageBox.Show("Please enter a new name");
                return;
            }

            if (TxtNewName.Text.Count() == 0)
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }

            if (repo.GetTaskByName(TxtTaskName.Text) != null)
            {
                MessageBox.Show("There already exist a task with this name");
                return;
            }

            repo.UpdateTaskByName(CbTasks.Text, TxtNewName.Text);
            TxtNewName.Clear();

            MessageBox.Show("Updated");

            LoadInitialTaskInformation();
            LoadGraphInformation();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("If you delete this task the time will still remain on the record", "Are you sure you want to delete thhis task?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            {
                TaskRepository repository = new TaskRepository();

                repository.DeleteTaskByName(CbTasks.Text);
                MessageBox.Show("Task deleted");
            }

            LoadInitialTaskInformation();
            LoadGraphInformation();
        }
    }
}

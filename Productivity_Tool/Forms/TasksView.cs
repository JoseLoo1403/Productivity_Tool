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

namespace Productivity_Tool.Forms
{
    public partial class TasksView : UserControl
    {
        public TasksView()
        {
            InitializeComponent();
        }
        private void TasksView_Load(object sender, EventArgs e)
        {
            LoadInitialInformation();
        }

        public void LoadInitialInformation()
        {
            TaskRepository taskRepository = new TaskRepository();
            List<Tasks> items = taskRepository.GetAllTasks();

            CbTasks.Items.Clear();
            foreach (Tasks item in items) 
            {
                CbTasks.Items.Add(item.Name);
            }
        }
        public void CreateNewTask()
        {
            TaskRepository repo = new TaskRepository();

            repo.CreateTask(TxtTaskName.Text);

            MessageBox.Show("Task created!");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (BtnAdd.Text == "New task")
            {
                LblNameAdd.Visible = true;
                TxtTaskName.Visible = true;
                BtnAdd.Text = "Add";
            }
            else
            {
                CreateNewTask();
                LblNameAdd.Visible = false;
                TxtTaskName.Visible= false;
                TxtTaskName.Clear();
                BtnAdd.Text = "New task";
            }
        }
    }
}

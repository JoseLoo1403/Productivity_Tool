using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data.Entities;
using System.Xml.Linq;

namespace Data.Repositories
{
    public class TaskRepository
    {
        public void CreateTask(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                int output = cnn.Query<int>("SELECT seq FROM sqlite_sequence where name = 'Tasks'", new DynamicParameters()).FirstOrDefault();
                output++;
                cnn.Execute($"INSERT INTO Tasks VALUES ({output},'{Name}')");
            }
        }


        public void UpdateTaskByName(string OldName, string NewName)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Tasks SET Name = '{NewName}' WHERE Name = '{OldName}'");
            }
        }

        public Tasks GetTaskById(int Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<Tasks>($"SELECT * FROM Tasks WHERE Id = '{Id}'", new DynamicParameters()).FirstOrDefault();

                return output;
            }
        }
        public List<Tasks> GetAllTasks()
        {
            using(IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<Tasks>("SELECT * FROM Tasks",new DynamicParameters()).ToList();

                return output;
            }
        }

        public Tasks GetTaskByName(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<Tasks>($"SELECT * FROM Tasks WHERE Name = '{Name}'", new DynamicParameters()).LastOrDefault();

                return output;
            }
        }

        public void DeleteTaskByName(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Tasks WHERE Name = '{Name}'");
            }
        }
    }
}

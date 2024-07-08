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
    public class TaskSessionsRepository
    {
        public TaskSessions GetTaskSessionByName(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<TaskSessions>($"SELECT * FROM Tasks WHERE Name = '{Name}'", new DynamicParameters()).FirstOrDefault();

                return output;
            }
        }

        public TaskSessions GetTodayTaskSessionOrCreate(int TaskId)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {

                int StudyId = cnn.Query<int>($"SELECT * FROM StudySessions WHERE Date = '{DateTime.Today.ToString("yyyy/MM/dd")}'",new DynamicParameters()).FirstOrDefault();

                var ouput = cnn.Query<TaskSessions>($"SELECT * FROM TaskSessions WHERE (Session_Id = {StudyId} and Task_Id = {TaskId})", new DynamicParameters());

                if (ouput.Count() > 0)
                {
                    return ouput.FirstOrDefault();
                }

                TaskSessions res = new TaskSessions();

                int Id = cnn.Query<int>("SELECT seq FROM sqlite_sequence WHERE name = 'TaskSessions'", new DynamicParameters()).FirstOrDefault();
                Id++;

                res.Id = Id;
                res.Time = "00:00:00";
                res.Session_Id = StudyId;
                res.Task_Id = TaskId;

                cnn.Execute($"INSERT INTO TaskSessions VALUES ({Id},'00:00:00',{StudyId},{TaskId})"); 

                return res;
            }
        }
        public void AddTimeToTaskSession(int Id, int Hours, int minutes, int seconds)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<string>($"SELECT Time FROM TaskSessions WHERE Id = {Id}", new DynamicParameters());

                output.ToList();

                string s = output.FirstOrDefault();

                int H, M, S = 0;

                string[] v = s.Split(':');

                H = Convert.ToInt32(v[0]);
                M = Convert.ToInt32(v[1]);
                S = Convert.ToInt32(v[2]);

                S += seconds;

                if (S >= 60)
                {
                    S -= 60;
                    M++;
                }

                M += minutes;

                if (M >= 60)
                {
                    M -= 60;
                    H++;
                }

                H += Hours;

                cnn.Execute($"update TaskSessions set Time = '{H.ToString("D2")}:{M.ToString("D2")}:{S.ToString("D2")}' where Id = '{Id}'");
                MonthSessionRepository repo = new MonthSessionRepository();
                repo.AddTimeToCurrentSession(Hours, minutes, seconds);
            }
        }
    }
}

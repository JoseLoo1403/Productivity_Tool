using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data.Entities;

namespace Data.Repositories
{
    public class StudySessionsRepository
    {
        public void AddTimeToSession(string date,int Hours,int minutes,int seconds)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<StudySessions>($"select Date,Time from StudySessions where Date = '{date}'", new DynamicParameters());

                output.ToList();

                string s = output.FirstOrDefault().Time;

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

                cnn.Execute($"update StudySessions set Time = '{H.ToString("D2")}:{M.ToString("D2")}:{S.ToString("D2")}' where Date = '{date}'");
                MonthSessionRepository repo = new MonthSessionRepository();
                repo.AddTimeToCurrentSession(Hours, minutes, seconds);
            }
        }


        public void CreateSessionIfApplies(int monthId)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<StudySessions>($"select Date,Time from StudySessions where Date = '{DateTime.Today.ToString("yyyy/MM/dd")}'", new DynamicParameters());

                if (output.Count() > 0)
                {
                    return;
                }

                cnn.Execute($"insert into StudySessions values ('{DateTime.Today.ToString("yyyy/MM/dd")}','0:0:0','{monthId}')");
                cnn.Execute("update Configurations set Value = '0' where Name = 'Current count'");
            }
        }

        public List<StudySessions> GetAllStudySessions()
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString())) 
            {
                var output = cnn.Query<StudySessions>("select * from StudySessions", new DynamicParameters());

                return output.ToList();
            }
        }

        public StudySessions GetStudySessionByDate(string date)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<StudySessions>($"select Date,Time from StudySessions where Date = '{date}'", new DynamicParameters());

                return output.ToList().FirstOrDefault();
            }
        }
    }
}

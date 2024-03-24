using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data.Entities;

namespace Data.Repositories
{
    public class MonthSessionRepository
    {
        public void CreateNewMonthSession()
        {
            using(IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                 var id = cnn.Query<int>("SELECT seq FROM sqlite_sequence WHERE name = 'MonthSession'",new DynamicParameters());

                cnn.Execute($"insert into MonthSession values ({id.FirstOrDefault() + 1},'{DateTime.Today.ToString("yyyy/MM")}','0:0:0')");
            }
        }

        public void AddTimeToCurrentSession(int Hours, int minutes, int seconds)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var id = cnn.Query<int>("select id from MonthSession last_value");

                var output = cnn.Query<string>($"select TotalTime from MonthSession where Id = '{id.FirstOrDefault()}'", new DynamicParameters());

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

                cnn.Execute($"update MonthSession set TotalTime = '{H.ToString("D2")}:{M.ToString("D2")}:{S.ToString("D2")}' where Id = '{id.FirstOrDefault()}'");
            }
        }

        public int GetLastId()
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var id = cnn.Query<int>("select id from MonthSession last_value");

                return id.FirstOrDefault();
            }
        }

        public MonthSession GetSessionByDate(string date)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var session= cnn.Query<MonthSession>($"select * from MonthSession where Date = '{date}'",new DynamicParameters());

                return session.FirstOrDefault();
            }
        }

        public List<string> GetDates()
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var sessions = cnn.Query<string>($"select date from MonthSession", new DynamicParameters());

                return sessions.ToList();
            }
        }
    }
}

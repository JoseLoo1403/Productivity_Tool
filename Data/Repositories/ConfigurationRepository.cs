using System;
using System.Collections.Generic;
using System.Configuration;
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
    public class ConfigurationRepository
    {
        public int[] GetConfigurationValueByName(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                var output = cnn.Query<Configurations>($"select Id,Name,Value from Configurations where Name = '{Name}'", new DynamicParameters());

                output.ToList();

                string time = output.FirstOrDefault().Value;

                string[] timeArr = time.Split(':');

                int[] res = {0,0,0};

                for (int i = 0; i < 3; i++)
                {
                    res[i] = Convert.ToInt32(timeArr[i]);
                }

                return res;
            }
        }

        public void UpdateByNameConfigurations(string Name, string Value)
        {
            using (IDbConnection cnn = new SQLiteConnection(DbContext.LoadConnectionString()))
            {
                cnn.Execute($"update Configurations set Value = '{Value}' WHERE Name = '{Name}'");
            }
        }
    }
}

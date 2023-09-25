using Dapper;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Class1
    {
        public static string Demo()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Configurations>("select * from Configurations", new DynamicParameters());
                output.ToList();

                return output.FirstOrDefault().Name;
            }
        }

        private static string LoadConnectionString()
        {
            string id = "Default";

            return ConfigurationManager.ConnectionStrings[id].ConnectionString;

        }
    }
}

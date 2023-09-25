using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public static class DbContext
    {
        public static string LoadConnectionString()
        {
            string id = "Default";

            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

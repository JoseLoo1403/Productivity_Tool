using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TaskSessions
    {
        public int Id { get; set; }

        public string Time { get; set; }
        public int Session_Id { get; set; }
        public int Task_Id { get; set; }
    }
}

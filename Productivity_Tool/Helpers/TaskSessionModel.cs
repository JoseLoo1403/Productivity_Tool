using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity_Tool.Helpers
{
    public class TaskSessionModel
    {
        public string Title { get; set; }
        public double value { get; set; }

        public TaskSessionModel(string t, double v)
        {
            Title = t;
            value = v;
        }
    }
}

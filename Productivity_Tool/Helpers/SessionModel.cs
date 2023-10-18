using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity_Tool.Helpers
{
    internal class SessionModel
    {
        public DateTime Date { get; set; }
        public double Time { get; set; }

        public SessionModel(string date, double val)
        {
            Date = DateTime.Parse(date,CultureInfo.InvariantCulture);
            Time = val;
        }
    }
}

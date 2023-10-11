using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Productivity_Tool.Helpers
{
    public class TimerObj
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Seconds { get; set; }


        public string GetTimeFormat()
        {
            return $"{Hour.ToString("D2")}:{Minute.ToString("D2")}:{Seconds.ToString("D2")}";
        }
        public string AddTime()
        {
            if (Seconds < 59)
            {
                Seconds++;
            }
            else if(Minute < 59 )
            {
                Seconds = 0;
                Minute++;
            }
            else
            {
                Hour = 1;
                Minute++;
            }

            return GetTimeFormat();
        }
        public int GetTotalSeconds()
        {
            int secs = Seconds + Minute * 60 + Hour * 3600;

            return secs;
        }

        public TimerObj(int _hour,int _minute)
        {
            Hour = _hour;
            Minute = _minute;
            Seconds = 0;
        }

        public void ResetTime()
        {
            Hour = 0;
            Minute = 0;
            Seconds = 0;
        }
    }
}

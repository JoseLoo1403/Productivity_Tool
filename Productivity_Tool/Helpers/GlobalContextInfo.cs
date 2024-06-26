﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity_Tool.Helpers
{
    public class GlobalContextInfo
    {
        //Events

        public event EventHandler<bool> EnableBaseInterfaceEvent;
        public event EventHandler<bool> ZenModeEvent;
        public event EventHandler<bool> CreateNewSessionEvent;

        //Global variables

        public int CurrentCount;
        public TimerObj CurrentTime;
        public int Mode = 0;
        public int PomodoroValue = 0;
        public DateTime CurrentDate;
        public int MonthId;

        public void EnableBaseInterface(bool arg)
        {
            EnableBaseInterfaceEvent?.Invoke(this,arg);
        }

        public void ZenModeInvoke(bool arg)
        {
            ZenModeEvent?.Invoke(this,arg);
        }

        public void CreateNewSession(bool arg)
        {
            CreateNewSessionEvent?.Invoke(this, arg);
        }
    }
}

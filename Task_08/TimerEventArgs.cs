using System;
using System.Collections.Generic;
using System.Text;

namespace Task_08
{
    public class TimerEventArgs
    {
        // Timer name
        public string TimerName { get; }
        // Long of the timer
        public int SecondsToStop { get; }

        public TimerEventArgs(string timerName, int secondsToStop)
        {
            TimerName = timerName;
            SecondsToStop = secondsToStop;
        }
    }
}

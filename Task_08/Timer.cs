using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_08
{
    public class Timer
    {
        public delegate void TimerHandler(object sender, TimerEventArgs e);
        //public delegate void TimerHandler(string timerName, int secondsToStop); //1. Объявляем делегат
        public event TimerHandler Notify; // 1.Определение события

        private int secondsToStop;
        private string timerName;

        public Timer(int secondsToStop, string timerName)
        {
            this.secondsToStop = secondsToStop;
            this.timerName = timerName;
        }

        public void StartTimer(int secondsToStop, string timerName)
        {
            
            Thread.Sleep(secondsToStop * 1000);
            Notify?.Invoke(this, new TimerEventArgs($"The timer has expired. The name of the timer is {timerName}", secondsToStop));
            //Notify?.Invoke($"The timer has expired.{secondsToStop}", timerName);
            //Notify?.Invoke($"The timer has expired. The name of the timer is {timerName}");

        }
    }
}

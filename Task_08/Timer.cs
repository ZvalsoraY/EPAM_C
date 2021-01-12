using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_08
{
    public class Timer
    {
        delegate void Message(); // 1. Объявляем делегат

        static void Main(string[] args)
        {
            Message mes; // 2. Создаем переменную делегата
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // 3. Присваиваем этой переменной адрес метода
            }
            else
            {
                mes = GoodEvening;
            }
            mes(); // 4. Вызываем метод
            Console.ReadKey();
        }


        delegate int TimerDelegate(int secondsToStop, string timerName = "no name timer");

        private int secondsToStop;
        private string timerName;

        public Timer(int secondsToStop, string timerName)
        {
            this.secondsToStop = secondsToStop;
            this.timerName = timerName;
        }

        public void StartTimer()
        {
            Thread.Sleep(secondsToStop * 1000);
        }
    }
}

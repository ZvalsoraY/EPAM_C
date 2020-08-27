using System;

namespace Task_05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Данна программа позволяет работать с трехмерными векторами.");
            Console.WriteLine("Вектор задаётся одной точкой, то есть он с началом в начале координат.");
            Console.WriteLine("Введите координаты x, y, z первого вектора через Enter");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x, y, z второго вектора через Enter");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());

            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            Console.WriteLine("Если вы хотите вычислить длину векторов введите 1.");
            Console.WriteLine("Если вы хотите получить сумму векторов введите 2.");
            Console.WriteLine("Если вы хотите вычесть из первого вектора второй введите 3.");
            Console.WriteLine("Если вы хотите вычесть из второго вектора первый введите 4.");
            Console.WriteLine("Если вы хотите получить скалярное произведение векторов введите 5.");
            Console.WriteLine("Если вы хотите умножить вектор на число введите 6.");
            Console.WriteLine("Если вы хотите получить строковое представление вектора введите 7.");

            Console.Write("Введите число : ");
            int funSelection = Convert.ToInt16(Console.ReadLine());
            if (funSelection == 1)
            {
                Console.WriteLine("Длина 1 вектора = {0}", vector1.Length());
                Console.WriteLine("Длина 2 вектора = {0}", vector2.Length());
            }
            else if (funSelection == 2)
            {
                Console.WriteLine("Сумма векторов = {0}", vector1 + vector2);
            }
            else if (funSelection == 3)
            {
                Console.WriteLine("Вектор 1 - вектор 2 = {0}", vector1 - vector2);
            }
            else if (funSelection == 4)
            {
                Console.WriteLine("Вектор 2 - вектор 1 = {0}", vector2 - vector1);
            }
            else if (funSelection == 5)
            {
                Console.WriteLine("Скалярное произведение векторов = {0}", vector1 * vector2);
            }
            else if (funSelection == 6)
            {
                Console.WriteLine("Введите число, на которое необходимо умножить вектор");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите номер вектора, котрый вы хотите умножить : ");
                int vectorSelection = Convert.ToInt16(Console.ReadLine());
                if (vectorSelection == 1)
                    Console.WriteLine("Произведение 1 вектора на число = {0}", vector1 * n);
                else if (vectorSelection == 2)
                    Console.WriteLine("ДПроизведение 2 вектора на число = {0}", vector2 * n);
                else Console.WriteLine("Было введено не корректное значение.");
            }
            else if (funSelection == 7)
            {
                Console.WriteLine("Строковое представление вектора 1 = {0}", vector1.ToString());
                Console.WriteLine("Строковое представление вектора 2 = {0}", vector2.ToString());
            }
            else Console.WriteLine("Было введено не корректное значение.");

        }
    }
}

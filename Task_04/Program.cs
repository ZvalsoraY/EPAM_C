using System;

namespace Task_04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Данна программа позволяет вычислять периметр и площадь треугольника.");
            Console.WriteLine("Введите длины сторон треугольника через Enter");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine("Периметр треугольника равен {0}", triangle.Perimeter);
            Console.WriteLine("Площадь треугольника равна {0}", triangle.Square);
            Console.WriteLine("Спасибо, что воспользовались нашей программой.");
            Console.ReadLine();
        }
    }
}
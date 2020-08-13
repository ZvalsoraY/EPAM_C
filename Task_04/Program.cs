using System;

namespace Task_04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine(triangle.SideA);
            Console.WriteLine(triangle.SideB);
            Console.WriteLine(triangle.SideC);
            Console.WriteLine("Спасибо, что воспользовались нашей программой.");
            Console.ReadLine();
        }
    }
}
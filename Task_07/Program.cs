using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            public void InputArray(int[,] array) //Метод заполнения матрицы
            {
                int i, j;

                for (i = 0; i < this.column; i++)
                {
                    for (j = 0; j < this.row; j++)
                    {
                        Console.WriteLine("Введите [{0},{1}] элемент матрицы", i + 1, j + 1);
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}

﻿using System;

namespace Task_07
{
    class Program
    {
        public static double[,] InputArray(long rowInputArray, long columnInputArray) //Метод заполнения матрицы
        {
            double[,] inputMatrix = new double[rowInputArray, columnInputArray];
            for (long i = 0; i < columnInputArray; i++)
            {
                for (long j = 0; j < rowInputArray; j++)
                {
                    Console.WriteLine("Please input [{0},{1}] element of the matrix", i + 1, j + 1);
                    inputMatrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            return inputMatrix;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the matrix via enter.");
            //Console.WriteLine("Enter the number of rows in the matrix.");
            //long rowEnter = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Enter the number of columns in the matrix.");
            //long colEnter = Convert.ToInt64(Console.ReadLine());
            //double[,] matrixEnter = InputArray(rowEnter, colEnter);

            double[,] matrixEnter = { { 5 } };
            double[,] matrix1 = { { 1, 1, 1 } };
            double[,] matrix2 = { { 1, 1, 1 } };

            Matrix addMatrix = new Matrix(1, 1, matrixEnter);
            var resultMatrix = addMatrix.AddMatrix(matrix1, matrix2);
            var subMatrix = addMatrix.SubMatrix(matrix1, matrix2);
            var facMatrix = addMatrix.FacMatrix(matrix1, 5);
            var mulMatrix = addMatrix.MultiplicationMatrix(matrixEnter, matrix2);
            var strMatrix = addMatrix.MatrixAsString(matrix2);
            Console.WriteLine(strMatrix);
            var equalMatrix = addMatrix.EqualMatrix(matrix2, matrix2);
            Console.WriteLine(equalMatrix);

            var emptyMatrix = addMatrix.GetEmpty(5, 2);
            
            //Console.WriteLine(addMatrix);
            //foreach (long i in addMatrix) Console.Write($"{i} ");
            Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine(resultMatrix.GetValue(0,0));

        }
    }
}

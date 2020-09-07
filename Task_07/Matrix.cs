using System;
using System.Collections.Generic;
using System.Text;

namespace Task_07
{
    class Matrix
    {
        private long row;
        private long column;
        private double[,] matrixArray;
        public Matrix(long row, long column, double[,] matrixArray)
        {
            this.row = row;
            this.column = column;
            this.matrixArray = matrixArray;
        }
        // метод расширения для получения количества строк матрицы
        public static int RowsCount(double[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        // метод расширения для получения количества столбцов матрицы
        public static int ColumnsCount(double[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
        /// <summary>
        /// Output matrix.
        /// </summary>
        /// <returns>
        /// Outputting the matrix to the console.
        /// </returns>
        public void OutputMatrix(double[,] matrix, long m, long n)
        {
            for (long i = 0; i < m; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Addition.
        /// </summary>
        /// <returns>
        /// Addition of two matrices.
        /// </returns>
        public double[,] AddMatrix(double[,] matrix1, double[,] matrix2)
        {
            long sumMatrixRow = matrix1.GetUpperBound(0) + 1;
            long sumMatrixCol = matrix1.GetUpperBound(1) + 1;
            double[,] sumMatrix = new double[sumMatrixRow, sumMatrixCol];
            //if (matrix1.Length != matrix2.Length)
            //    return null;
            for (long i = 0; i < this.column; i++)
            {
                for (long j = 0; j < this.row; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return sumMatrix;
        }
        //Метод разности двух матриц
        public double[,] SubMatrix(double[,] matrix1, double[,] matrix2)
        {
            long subMatrixRow = matrix1.GetUpperBound(0) + 1;
            long subMatrixCol = matrix1.GetUpperBound(1) + 1;
            double[,] subMatrix = new double[subMatrixRow, subMatrixCol];
            //if (matrix1.Length != matrix2.Length)
            //    return null;
            for (long i = 0; i < this.column; i++)
            {
                for (long j = 0; j < subMatrixCol; j++)
                {
                    subMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return subMatrix;
        }
        //Метод умножения матрицы на заданное число
        public void FacMatrix(double[,] matrix, double factor) 
        {
            for (long i = 0; i < matrix.GetUpperBound(1) + 1; i++)
            {
                for (long j = 0; j < matrix.GetUpperBound(0) + 1; j++)
                {
                    matrix[i, j] = factor * matrix[i, j];
                }
            }
        }
        //перемножение матриц
        // метод для умножения матриц
        static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        public double[,] TransposeMatrix(double[,] matrix) //Метод транспонирования матрицы
        {
            double[,] tmpArray = new double[this.row, this.column];

            for (long i = 0; i < this.column; i++)
            {
                for (long j = 0; j < this.row; j++)
                {
                    tmpArray[i, j] = array[j, i];
                }
            }

            return tmpArray;
        }
        
        

        public bool EqualMatrix(int[,] array, int[,] array2) //Метод проверки равенства двух матриц
        {
            int i, j;

            if (array.Length != array2.Length)
                return false;

            for (i = 0; i < this.column; i++)
            {
                for (j = 0; j < this.row; j++)
                {
                    if (array[i, j] != array2[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}

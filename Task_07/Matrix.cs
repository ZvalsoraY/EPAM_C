using System;

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
        public long RowsCount(double[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        // метод расширения для получения количества столбцов матрицы
        public long ColumnsCount(double[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
        /// <summary>
        /// Output matrix.
        /// </summary>
        /// <returns>
        /// Outputting the matrix to the console.
        /// </returns>
        public void OutputMatrix(double[,] matrix)
        {
            long matrixRow = RowsCount(matrix);
            long matrixCol = ColumnsCount(matrix);
            for (long i = 0; i < matrixCol; i++)
            {
                for (long j = 0; j < matrixRow; j++)
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
            long sumMatrixRow = RowsCount(matrix1);
            long sumMatrixCol = ColumnsCount(matrix1);
            double[,] sumMatrix = new double[sumMatrixRow, sumMatrixCol];
            //if (matrix1.Length != matrix2.Length)
            //    return null;
            for (long i = 0; i < sumMatrixCol; i++)
            {
                for (long j = 0; j < sumMatrixRow; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return sumMatrix;
        }
        //Метод разности двух матриц
        public double[,] SubMatrix(double[,] matrix1, double[,] matrix2)
        {
            long subMatrixRow = RowsCount(matrix1);
            long subMatrixCol = ColumnsCount(matrix1);
            double[,] subMatrix = new double[subMatrixRow, subMatrixCol];
            //if (matrix1.Length != matrix2.Length)
            //    return null;
            for (long i = 0; i < subMatrixCol; i++)
            {
                for (long j = 0; j < subMatrixRow; j++)
                {
                    subMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return subMatrix;
        }
        //Метод умножения матрицы на заданное число
        public double[,] FacMatrix(double[,] matrix, double factor) 
        {
            //long facMatrixRow = RowsCount(matrix);
            //long facMatrixCol = ColumnsCount(matrix);
            //double[,] facMatrix = new double[facMatrixRow, facMatrixCol];
            for (long i = 0; i < matrix.GetUpperBound(1) + 1; i++)
            {
                for (long j = 0; j < matrix.GetUpperBound(0) + 1; j++)
                {
                    matrix[i, j] = factor * matrix[i, j];
                }
            }
            return matrix;
        }
        //перемножение матриц
        // метод для умножения матриц
        static long[,] MultiplicationMatrix(long[,] matrix1, long[,] matrix2)
        {
            if (matrix1.ColumnsCount() != matrix2.RowsCount())
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            var matrixC = new int[matrix1.RowsCount(), matrix2.ColumnsCount()];

            for (var i = 0; i < matrix1.RowsCount(); i++)
            {
                for (var j = 0; j < matrix2.ColumnsCount(); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrix1.ColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrix1[i, k] * matrix2[k, j];
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

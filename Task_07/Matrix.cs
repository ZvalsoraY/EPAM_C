using System;

namespace Task_07
{
    public class Matrix
    {
        private long row;
        private long column;
        private double[,] matrixArray;
        public Matrix(long row, long column, double[,] matrixArray)
        {
            this.row = row;
            this.column = column;
            this.matrixArray = matrixArray;
            //this.matrixArray = InputMatrix(row, column);
        }
        //public double[,] InputMatrix(long rowInput, long columnInput ) //Метод заполнения матрицы
        //{
        //    double[,] matrixInput = new double[rowInput, columnInput];

        //    for (long i = 0; i < columnInput; i++)
        //    {
        //        for (long j = 0; j < rowInput; j++)
        //        {
        //            Console.WriteLine("Введите [{0},{1}] элемент матрицы", i + 1, j + 1);
        //            matrixInput[i, j] = Convert.ToDouble(Console.ReadLine());
        //        }
        //    }

        //    return matrixInput;
        //}

        public double[,] GetEmpty(long rowEmpty, long columnEmpty)
        {
            double[,] emptyMatrix = new double[rowEmpty, columnEmpty];
            for (long i = 0; i < columnEmpty; i++)
            {
                for (long j = 0; j < rowEmpty; j++)
                {
                    emptyMatrix[i, j] = 0;
                }
            }

            return emptyMatrix;
        }

        /// <summary>
        /// Matrix rows.
        /// </summary>
        /// <returns>
        /// Counting the number of rows in a matrix.
        /// </returns>
        public long RowsCount(double[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }
        /// <summary>
        /// Matrix columns.
        /// </summary>
        /// <returns>
        /// Counting the number of columns in a matrix.
        /// </returns>
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
            for (long i = 0; i < ColumnsCount(matrix); i++)
            {
                for (long j = 0; j < RowsCount(matrix); j++)
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
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception($"You must supply an argument{RowsCount(matrix1)}");
            }
        }
        /// <summary>
        /// Difference.
        /// </summary>
        /// <returns>
        /// Difference of two matrices.
        /// </returns>
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
        /// <summary>
        /// k*matrix.
        /// </summary>
        /// <returns>
        /// Multiplication of a matrix by a constant.
        /// </returns>
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
        /// <summary>
        /// Matrix*matrix.
        /// </summary>
        /// <returns>
        /// Matrix multiplication.
        /// </returns>
        public double[,] MultiplicationMatrix(double[,] matrix1, double[,] matrix2)
        {
            long mulMatrixRow = RowsCount(matrix1);
            long mulMatrixCol = ColumnsCount(matrix2);
            //if (matrix1.ColumnsCount() != matrix2.RowsCount())
            //{
            //    throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            //}
            double[,] mulMatrix = new double[mulMatrixRow, mulMatrixCol];
            for (long i = 0; i < mulMatrixRow; i++)
            {
                for (long j = 0; j < mulMatrixCol; j++)
                {
                    mulMatrix[i, j] = 0;

                    for (long k = 0; k < mulMatrixRow; k++)
                    {
                        mulMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return mulMatrix;
        }
        /// <summary>
        /// Matrix equality.
        /// </summary>
        /// <returns>
        /// Matrix equality check.
        /// </returns>
        public bool EqualMatrix(double[,] matrix1, double[,] matrix2) 
        {
            if (matrix1.Length != matrix2.Length)
                return false;
            for (long i = 0; i < ColumnsCount(matrix1); i++)
            {
                for (long j = 0; j < RowsCount(matrix1); j++)
                {
                    if (matrix1[i, j] - matrix2[i, j] > 0.001)
                        return false;
                }
            }
            return true;
        }
    }
}

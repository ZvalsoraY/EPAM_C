using System;
using System.Threading.Tasks;

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
            for (long i = 0; i < rowEmpty; i++)
            {
                for (long j = 0; j < columnEmpty; j++)
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
        /// Matrix as a string.
        /// </summary>
        /// <returns>
        /// Matrix to string.
        /// </returns>
        public string MatrixAsString(double[,] matrix)
        {
            string s = "";
            long matrixRow = RowsCount(matrix);
            long matrixCol = ColumnsCount(matrix);
            for (long i = 0; i < matrixRow; i++)
            {
                for (long j = 0; j < matrixCol; j++)
                {
                    s += matrix[i, j].ToString("F3").PadLeft(8) + " ";
                }
                s += Environment.NewLine;
            }
            return s;
        }
        /// <summary>
        /// Print matrix.
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
            long matrix1Row = RowsCount(matrix1);
            long matrix1Col = ColumnsCount(matrix1);
            long matrix2Row = RowsCount(matrix2);
            long matrix2Col = ColumnsCount(matrix2);
            double[,] sumMatrix = new double[matrix1Row, matrix1Col];
            //double[,] sumMatrix = new double[matrix1Col, matrix1Row];
            if (matrix1Row != matrix2Row || matrix1Col != matrix2Col)
            {         
                throw new MatrixException($"The number of rows and columns of the first matrix {matrix1Row}, {matrix1Col}" +
                    $" and the second {matrix2Row}, {matrix2Col}",
                    matrix1Row, matrix1Col, matrix2Row, matrix2Col);
            }
            else
            for (long i = 0; i < matrix1Row; i++)
            {
                for (long j = 0; j < matrix1Col; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return sumMatrix;
        }
        /// <summary>
        /// Difference.
        /// </summary>
        /// <returns>
        /// Difference of two matrices.
        /// </returns>
        public double[,] SubMatrix(double[,] matrix1, double[,] matrix2)
        {
            long matrix1Row = RowsCount(matrix1); long matrix1Col = ColumnsCount(matrix1);
            long matrix2Row = RowsCount(matrix2); long matrix2Col = ColumnsCount(matrix2);
            double[,] subMatrix = new double[matrix1Row, matrix1Col];
            if (matrix1Row != matrix2Row || matrix1Col != matrix2Col)
            {
                throw new MatrixException($"The number of rows and columns of the first matrix {matrix1Row}, {matrix1Col}" +
                    $" and the second {matrix2Row}, {matrix2Col}",
                    matrix1Row, matrix1Col, matrix2Row, matrix2Col);
            }
            else
                for (long i = 0; i < matrix1Row; i++)
                {
                    for (long j = 0; j < matrix1Col; j++)
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
            long matrixRow = RowsCount(matrix);
            long matrixCol = ColumnsCount(matrix);
            for (long i = 0; i < matrixRow; i++)
            {
                for (long j = 0; j < matrixCol; j++)
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
            long mulMatrixCol1 = ColumnsCount(matrix1); long mulMatrixRow1 = RowsCount(matrix1);
            long mulMatrixCol2 = ColumnsCount(matrix2); long mulMatrixRow2 = RowsCount(matrix2);
            if (mulMatrixCol1 != mulMatrixRow2)
            {
                throw new Exception("Non-conformable matrices in MultiplicationMatrix.");
            }
            double[,] mulMatrix = new double[mulMatrixRow1, mulMatrixCol2];
            Parallel.For(0, mulMatrixRow1, i =>
            {
                for (long j = 0; j < mulMatrixCol2; ++j)
                    for (long k = 0; k < mulMatrixRow1; ++k)
                        mulMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
            );
            return mulMatrix;
        }

        
        /// <summary>
        /// Matrix equality.
        /// </summary>
        /// <returns>
        /// Matrix equality check.
        /// </returns>
        public bool EqualMatrix(double[,] matrix1, double[,] matrix2, double epsilon = 0.001) 
        {
            long matrix1Row = RowsCount(matrix1); long matrix1Col = ColumnsCount(matrix1);
            long matrix2Row = RowsCount(matrix2); long matrix2Col = ColumnsCount(matrix2);
            if (matrix1Row != matrix2Row || matrix1Col != matrix2Col)
            {
                return false;
            }

            for (long i = 0; i < matrix1Row; i++)
            {
                for (long j = 0; j < matrix1Col; j++)
                {
                    if (matrix1[i, j] - matrix2[i, j] > epsilon)
                        return false;
                }
            }
            return true;
        }
        
    }
}

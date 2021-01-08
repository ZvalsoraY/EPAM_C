using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_07;

namespace Task_07.test
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void AddMatrixTestPos()
        {
            double[,] matrix1 = { { 1 } }; 
            double[,] matrix2 = { { 1 } };
            double[,] expectedMatrix = { { 2 } };
            //double[,] subMatrix = new double[subMatrixRow, subMatrixCol];
            Matrix testAddMatrixTest = new Matrix(1,1, matrix1);
            var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
            //Assert.AreEqual(expectedMatrix, testAddMatrixTest.AddMatrix(matrix1, matrix2),  "correct");
            //Assert.AreEqual(expectedMatrix, resultMatrix);
            CollectionAssert.AreEqual(expectedMatrix, resultMatrix);
        }
        [TestMethod]
        public void AddMatrixTestPos2()
        {
            double[,] matrix1 = { { 1, 1, 1 } };
            double[,] matrix2 = { { 1, 1, 1 } };
            double[,] expectedMatrix = { { 2, 2, 2 } };
            Matrix testAddMatrixTest = new Matrix(1, 1, matrix1);
            var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expectedMatrix, resultMatrix);
        }
        [TestMethod]
        public void AddMatrixTestPos3()
        {
            double[,] matrix1 = { { 1 }, { 1 }, { 1 } };
            double[,] matrix2 = { { 1 }, { 1 }, { 1 } };
            double[,] expectedMatrix = { { 2 }, { 2 }, { 2 } };
            Matrix testAddMatrixTest = new Matrix(1, 1, matrix1);
            var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expectedMatrix, resultMatrix);
        }
        //[TestMethod]
        //[ExpectedException(typeof(MatrixException))]
        //public void AddMatrixTestNeg()
        //{
        //    double[,] matrix1 = { { 1 }, { 1 }, { 1 } };
        //    double[,] matrix2 = { { 1 }, { 1 } };
        //    double[,] expectedMatrix = { { 2 }, { 2 }, { 2 } };
        //    Matrix testAddMatrixTest = new Matrix(1, 1, matrix1);
        //    var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
        //}
        [TestMethod]
        [ExpectedException(typeof(MatrixException))]
        public void AddMatrixTestNeg()
        {
            try
            {
                double[,] matrix1 = { { 1 }, { 1 }, { 1 } };
                double[,] matrix2 = { { 1 }, { 1 } };
                double[,] expectedMatrix = { { 2 }, { 2 }, { 2 } };
                Matrix testAddMatrixTest = new Matrix(1, 1, matrix1);
                var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
            }
            catch (MatrixException ex)
            {
                Assert.IsTrue(ex.Message.Contains("The number of rows and columns of the first matrix 3, 1 and the second 2, 1"));
                throw;
            }
        }

        [TestMethod]
        public void MultiplicationMatrixTestPos()
        {
            double[,] matrix1 = { { 1, 1, 1 } };
            double[,] matrix2 = { { 1 }, { 1 }, { 1 } };
            double[,] expectedMatrix = { { 3 } };
            Matrix testMultiplicationMatrixTest = new Matrix(1, 1, matrix1);
            var resultMatrix = testMultiplicationMatrixTest.MultiplicationMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expectedMatrix, resultMatrix);
        }
        [TestMethod]
        public void MultiplicationMatrixTestPos1()
        {
            double[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6} };
            double[,] matrix2 = { { 7, 8, 9, 10 }, { 11, 12, 13, 14 }, { 15, 16, 17, 18 } };
            double[,] expectedMatrix = { { 74, 80, 86, 92}, { 173, 188, 203, 218} };
            Matrix testMultiplicationMatrixTest = new Matrix(1, 1, matrix1);
            var resultMatrix = testMultiplicationMatrixTest.MultiplicationMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expectedMatrix, resultMatrix);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MultiplicationMatrixTestNeg()
        {
            try
            {
                double[,] matrix1 = { { 1 }, { 1 }, { 1 } };
                double[,] matrix2 = { { 1 }, { 1 } };
                double[,] expectedMatrix = { { 2 }, { 2 }, { 2 } };
                Matrix testMultiplicationMatrixTest = new Matrix(1, 1, matrix1);
                var resultMatrix = testMultiplicationMatrixTest.MultiplicationMatrix(matrix1, matrix2);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Non-conformable matrices in MultiplicationMatrix."));
                throw;
            }
        }
        [TestMethod]
        public void EqualMatrixTestPos()
        {
            double[,] matrix1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            double[,] matrix2 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            
            Matrix testMultiplicationMatrixTest = new Matrix(1, 1, matrix1);
            var resultEqualTest = testMultiplicationMatrixTest.EqualMatrix(matrix1, matrix2);
            Assert.IsTrue(resultEqualTest);
            //CollectionAssert.AreEqual(true,)
            //CollectionAssert.AreEqual(true, result);
        }
        [TestMethod]
        public void EqualMatrixTestNeg()
        {
            double[,] matrix1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            double[,] matrix2 = { { 1, 1, 1 }, { 1, 2, 1 }, { 1, 1, 1 } };

            Matrix testMultiplicationMatrixTest = new Matrix(1, 1, matrix1);
            var resultEqualTest = testMultiplicationMatrixTest.EqualMatrix(matrix1, matrix2);
            Assert.IsFalse(resultEqualTest);
            //CollectionAssert.AreEqual(true,)
            //CollectionAssert.AreEqual(true, result);
        }
    }
}

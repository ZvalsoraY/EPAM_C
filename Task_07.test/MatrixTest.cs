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
        [TestMethod]
        [ExpectedException(typeof(MatrixException))]
        public void AddMatrixTestNeg()
        {
            double[,] matrix1 = { { 1 }, { 1 }, { 1 } };
            double[,] matrix2 = { { 1 }, { 1 } };
            double[,] expectedMatrix = { { 2 }, { 2 }, { 2 } };
            Matrix testAddMatrixTest = new Matrix(1, 1, matrix1);
            var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
        }
        //[TestMethod()]
        ////[ExpectedException(typeof(ArgumentException),
        // //   "�� ���������� ������������ � ��������� �����������")]
        ////[ExpectedExceptionWithMessage(typeof(ArgumentOutOfRangeException), "port", true)]
        //public void AddMatrixTestNeg()
        //{
        //    double[,] matrix1 = { { 1 }, { 1 }, { 1 } };
        //    double[,] matrix2 = { { 1, 2 } };
        //    double[,] expectedMatrix = { { 2 } };
        //    Matrix testAddMatrixTest = new Matrix(1, 1, matrix1);
        //    var resultMatrix = testAddMatrixTest.AddMatrix(matrix1, matrix2);
        //    CollectionAssert.AreEqual(true, resultMatrix);
        //    //CollectionAssert.AreEqual(expectedMatrix, resultMatrix);
        //}


        //[TestMethod()]
        //public void PossibleTriangleTest()
        //{
        //    double a = 3;
        //    double b = 4;
        //    double c = 5;
        //    Triangle triangle = new Triangle(a, b, c);
        //    Assert.IsTrue(triangle.PossibleTriangle(a, b, c));
        //}

        ////private Exception exception;
        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentException),
        //    "�� ���������� ������������ � ��������� �����������")]
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_07;

namespace Task_07.test
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void AddMatrixTest()
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
    }
}

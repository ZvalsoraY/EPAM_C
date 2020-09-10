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
            Assert.AreEqual(AddMatrix(matrix1, matrix2), vector.Length(), 0.001, "correct");
        }
    }
}

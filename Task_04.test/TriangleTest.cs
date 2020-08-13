using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_04;
namespace Task_04.test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod()]
        public void PossibleTriangleTest()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);

            //// Act
            //var 
            //account.Debit(debitAmount);

            //// Assert
            //double actual = account.Balance;
            //Assert.AreEqual(true, triangle.PossibleTriangle(a, b, c), "correct");
            Assert.IsTrue(triangle.PossibleTriangle(a, b, c));

        }
        [TestMethod()]
        public void PerimeterTriangleTest()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);

            //// Act
            //account.Debit(debitAmount);

            //// Assert
            //double actual = account.Balance;
            Assert.AreEqual(a + b + c, triangle.PerimeterTriangle(a, b, c), 0.001, "correct");

            //Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod()]
        public void SquareTriangleTest()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(6, triangle.SquareTriangle(a, b, c), 0.001, "correct");
        }
    }
}

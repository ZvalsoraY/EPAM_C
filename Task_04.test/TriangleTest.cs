using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_04;
namespace Task_04.test
{
    [TestClass]
    public class TriangleTest
    {
        

        [TestMethod()]
        public void PossibleTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.IsTrue(triangle.PossibleTriangle(a, b, c));
        }

        //private Exception exception;
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
    "Не существует треугольника с заданными параметрами")]
        public void PossibleTriangleTestZero()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Triangle triangle = new Triangle(a, b, c);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
    "Не существует треугольника с заданными параметрами")]
        public void PossibleTriangleTestGreatSide()
        {
            double a = 100;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
        }
        [TestMethod()]
        public void PerimeterTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(a + b + c, triangle.PerimeterTriangle(a, b, c), 0.001, "correct");
        }
        [TestMethod()]
        public void SquareTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(6, triangle.SquareTriangle(a, b, c), 0.001, "correct");
        }
    }
}

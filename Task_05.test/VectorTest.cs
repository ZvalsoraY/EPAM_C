using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using Task_05;

namespace Task_05.test
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void LengthVectorTest()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            Vector vector = new Vector(x, y, z);
            Assert.AreEqual(Math.Sqrt(x * x + y * y + z * z), vector.Length(), 0.001, "correct");
        }
        [TestMethod]
        public void SummVectorTest()
        {
            Vector vector1 = new Vector(3, 4, 5);
            Vector vector2 = new Vector(-3, -4, -5);
            Vector expectedVector = new Vector(0, 0, 0);
            Assert.AreEqual(true, (vector1 + vector2).Equals(expectedVector));
            //vector1.Equals(vector2);
            //Assert.AreEqual(expectedVector.ToString(), (vector1 + vector2).ToString());
            //Assert.AreEqual(expectedVector, vector1 - vector2);
            //CollectionAssert.AreEqual((System.Collections.ICollection)expectedVector, (System.Collections.ICollection)(vector1 + vector2));
            //CollectionAssert.AreEqual((System.Collections.ICollection) expectedVector, (System.Collections.ICollection) (vector1 + vector2));
            //CollectionAssert.Equals((ICollection)expectedVector, (ICollection)(vector1 + vector2));
            //CollectionAssert.AreEqual(expectedVector, (vector1 + vector2));
            //Assert.That(expectedVector, Is.EqualTo(vector1 + vector2).AsCollection.Within(1.0E-7));
            //            Assert.AreEqual(vectorRes, vector1 + vector2, "correct");
        }
        [TestMethod]
        public void DifferenceVectorTest()
        {
            Vector vector1 = new Vector(3, 4, 5);
            Vector vector2 = new Vector(3, 4, 5);
            Vector expectedVector = new Vector(0, 0, 0);
            Assert.AreEqual(true, (vector1 - vector2).Equals(expectedVector));
        }
        [TestMethod]
        public void MultiplyVectorTest()
        {
            double x1 = 3;
            double y1 = 4;
            double z1 = 5;
            Vector vector1 = new Vector(x1, y1, z1);
            double x2 = 3;
            double y2 = 4;
            double z2 = 5;
            Vector vector2 = new Vector(x2, y2, z2);
            Assert.AreEqual(x1 * x2 + y1 * y2 + z1 * z2, vector1 * vector2, 0.001, "correct");
        }
        [TestMethod]
        public void ConstMultiplyVectorTest()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            Vector vector = new Vector(x, y, z);
            double n = 3;
            Assert.AreEqual(x * n + y * n + z * n, vector * n, 0.001, "correct");
        }
        [TestMethod]
        public void StringVectorTest()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            Vector vector = new Vector(x, y, z);
            string expectedString = "(3,4,5)";
            Assert.AreEqual(expectedString, vector.ToString(),"correct");
        }

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
    }
}

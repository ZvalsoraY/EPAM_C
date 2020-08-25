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
            //Assert.AreEqual(expectedVector.ToString(), (vector1 + vector2).ToString());
            //Assert.AreEqual(expectedVector, vector1 - vector2);
            //CollectionAssert.AreEqual((System.Collections.ICollection)expectedVector, (System.Collections.ICollection)(vector1 + vector2));
            //CollectionAssert.AreEqual((System.Collections.ICollection) expectedVector, (System.Collections.ICollection) (vector1 + vector2));
            CollectionAssert.AreEqual((ICollection)expectedVector, (ICollection)(vector1 + vector2));
            CollectionAssert.AreEqual(expectedVector, (vector1 + vector2));
            //Assert.That(expectedVector, Is.EqualTo(vector1 + vector2).AsCollection.Within(1.0E-7));
            //            Assert.AreEqual(vectorRes, vector1 + vector2, "correct");
        }
        //public void DifferenceVectorTest()
        //{
        //    Vector vector1 = new Vector(3, 4, 5);
        //    Vector vector2 = new Vector(3, 4, 5);
        //    Vector expectedVector = new Vector(0, 0, 0);
        //    //Assert.AreEqual(expectedVector.ToString(), (vector1 + vector2).ToString());
        //    Assert.AreEqual(expectedVector, vector1 - vector2);
        //    CollectionAssert.AreEqual((System.Collections.ICollection)expectedVector, (System.Collections.ICollection)(vector1 - vector2));
        //    //Assert.That(expectedVector, Is.EqualTo(vector1 + vector2).AsCollection.Within(1.0E-7));
        //    //            Assert.AreEqual(vectorRes, vector1 + vector2, "correct");
        //}
    }
}

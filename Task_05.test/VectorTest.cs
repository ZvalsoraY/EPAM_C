using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    }
}

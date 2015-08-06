using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void Simple1Test()
        {
            Square square = new Square();
            double S = square.SquareCalculate(3, 4, 5);
            Assert.IsNotNull(S);
        }
        [TestMethod]
        public void Simple2Test()
        {
            Square square = new Square(5, 4, 3);
            double S = square.SquareCalculate();
            Assert.IsNotNull(S);
        }
        [TestMethod]
        public void NotTriangleTest()
        {
            Square square = new Square();
            double S = square.SquareCalculate(10, 5, 1);
            Assert.AreEqual(0, S);
        }
    }
}

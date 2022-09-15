namespace Mindbox.Test 
{
    using Figures;
    using NUnit.Framework;
    using System;

    public class TriangleTest 
    {
        [TestCase(5, 3, 4, true)] 
        [TestCase(3, 3, 4, false)]
        public void IsRightTriangleTest(double num1, double num2, double num3, bool res)
        {
            var triangle = new Triangle(num1, num2, num3);
            var result = triangle.IsRightTriangle();
            Assert.AreEqual(res, result);
        }
        
        [TestCase(5, 3, 4, 6)] 
        [TestCase(3, 3, 4, 4.47d)]
        public void СalculateAreaTest(double num1, double num2, double num3, double res)
        {
            var triangle = new Triangle(num1, num2, num3);
            var result = triangle.СalculateArea();
            Assert.True(Math.Abs(res - result) < Constants.RequiredAccuracy);
        }
    }
}

namespace Mindbox.Test 
{
    using Figures;
    using NUnit.Framework;
    using System;

    public class CircleTest 
    {
        [TestCase(3, 28.27d)] 
        [TestCase(1, 3.14d)]
        public void СalculateAreaTest(double rad, double res)
        {
            var circle = new Circle(rad);
            var result = circle.СalculateArea();
            Assert.True(Math.Abs(res - result) < Constants.RequiredAccuracy);
        }
    }
}

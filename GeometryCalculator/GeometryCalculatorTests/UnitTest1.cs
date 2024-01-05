using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using GeometryLibrary;

namespace GeometryLibrary
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double result = GeometryCalculator.CalculateCircleArea(radius);

            Assert.AreEqual(expectedArea, result, 0.0001);

        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double expectedArea = 6;

            double result = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);

            Assert.AreEqual(expectedArea, result, 0.0001);


        }

        [Test]
        public void IsRightAngledTriangle_RightAngledTriangle_ReturnsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            bool result = GeometryCalculator.IsRightAngledTriangle(sideA, sideB, sideC);

            Assert.IsTrue(result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericIntegral;

namespace NumericIntegralUnitTest
{
    [TestClass]
    public class ClassicMethodTestSuite
    {
        private static double TestFunc(double x)
        {
            return x * Math.Sin(2 * x - 1);
        }
        [TestMethod]
        [DataRow(1.0, 2.0, 50, 1.0851, 0.01)]
        [DataRow(1.0, 2.0, 300, 1.0851, 0.001)]
        public void ShouldSuccessCalculateIntegralViaLeftRectMethod(double a, double b, int n, double expectedResult, double eps)
        {
            double actualResult = Integrals.LeftRect(a, b, n, TestFunc);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult) <= eps);
        }

        [TestMethod]
        [DataRow(1.0, 2.0, 50, 1.0851, 0.01)]
        [DataRow(1.0, 2.0, 300, 1.0851, 0.001)]
        public void ShouldSuccessCalculateIntegralViaRightRectMethod(double a, double b, int n, double expectedResult, double eps)
        {
            double actualResult = Integrals.RightRect(a, b, n, TestFunc);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult) <= eps);
        }

        [TestMethod]
        [DataRow(1.0, 2.0, 20, 1.0851, 0.01)]
        [DataRow(1.0, 2.0, 50, 1.0851, 0.001)]
        public void ShouldSuccessCalculateIntegralViaMidRectMethod(double a, double b, int n, double expectedResult, double eps)
        {
            double actualResult = Integrals.MidRect(a, b, n, TestFunc);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult) <= eps);
        }
    }
}

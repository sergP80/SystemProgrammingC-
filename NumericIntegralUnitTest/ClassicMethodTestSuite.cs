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
            IntegrateOptions options = new IntegrateOptions()
            {
                StartX = a,
                EndX = b,
                Steps = n,
                Function = TestFunc
            };
            double actualResult = Integrals.LeftRect(options);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult) <= eps);
        }


        [TestMethod]
        [DataRow(1.0, 2.0, 50, 1.0851, 5)]
        [DataRow(1.0, 2.0, 300, 1.0851, 1)]
        public void ShouldSuccessCalculateIntegralViaLeftRectMethodRelative(double a, double b, int n, double expectedResult, int eps)
        {
            IntegrateOptions options = new IntegrateOptions()
            {
                StartX = a,
                EndX = b,
                Steps = n,
                Function = TestFunc
            };
            double actualResult = Integrals.LeftRect(options);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult)/Math.Abs(expectedResult)*100 <= eps);
        }

        [TestMethod]
        [DataRow(1.0, 2.0, 50, 1.0851, 0.01)]
        [DataRow(1.0, 2.0, 300, 1.0851, 0.001)]
        public void ShouldSuccessCalculateIntegralViaRightRectMethod(double a, double b, int n, double expectedResult, double eps)
        {
            IntegrateOptions options = new IntegrateOptions()
            {
                StartX = a,
                EndX = b,
                Steps = n,
                Function = TestFunc
            };
            double actualResult = Integrals.RightRect(options);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult) <= eps);
        }

        [TestMethod]
        [DataRow(1.0, 2.0, 20, 1.0851, 0.01)]
        [DataRow(1.0, 2.0, 50, 1.0851, 0.001)]
        public void ShouldSuccessCalculateIntegralViaMidRectMethod(double a, double b, int n, double expectedResult, double eps)
        {
            IntegrateOptions options = new IntegrateOptions()
            {
                StartX = a,
                EndX = b,
                Steps = n,
                Function = TestFunc
            };
            double actualResult = Integrals.MidRect(options);
            Assert.IsTrue(Math.Abs(expectedResult - actualResult) <= eps);
        }
    }
}
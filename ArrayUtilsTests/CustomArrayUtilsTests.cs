using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUtils.Tests
{
    [TestClass()]
    public class CustomArrayUtilsTests
    {
        [TestMethod()]
        [DataRow(new double[] { -1.2, 2.0, 3.0, -1.1}, 0.675, 0.0001)]
        public void ProcessArrayTest(double[] data, double expectedAvg, double eps)
        {
            CustomArrayUtils.ProcessArray(data, out double min, out double max, out double avg);
            Array.Sort(data);
            Assert.IsTrue(Math.Abs(expectedAvg - avg) <= eps);
            Assert.IsTrue(Math.Abs(data[0] - min) <= eps);
            Assert.IsTrue(Math.Abs(data[data.Length - 1] - max) <= eps);
        }
    }
}
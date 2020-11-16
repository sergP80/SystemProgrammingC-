using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumericIntegral
{
    public class IntegrateOptions
    {
        public double StartX { get; set; }
        public double EndX { get; set; }
        public int Steps { get; set; }

        private double tolerance = 1e-3;
        public double Tolerance
        {
            get
            {
                return tolerance;
            }

            set
            {
                if (value < 0 || value > 1)
                {
                    throw new InvalidOperationException("Tolerance should be between 0 and 1");
                }
            }
        }
        public Func<double, double> Function { get; set; }

        public double Step
        {
            get
            {
                return (EndX - StartX) / Steps;
            }
        }

        public double CountedSteps { get; internal set; } = 0;

    }

    public delegate double IntegralMethod(IntegrateOptions options, Func<double, int, bool> cancelProgress);
    public static class Integrals
    {
        private static bool isTolerance(double x, double y, double eps)
        {
            return Math.Abs(x - y) <= eps;
        }
        public static double LeftRect(IntegrateOptions options, Func<double, int, bool> cancelProgress = null)
        {
            double result = 0;

            bool cancel = false;
            for (int i = 0; i < options.Steps && !cancel; ++i)
            {
                result += options.Function(options.StartX + i * options.Step);
                if (cancelProgress != null)
                {
                    cancel = cancelProgress(result * options.Step, (i + 1)*100/ options.Steps);
                }
                Thread.Sleep(10);
                options.CountedSteps = i + 1;
            }
            return result* options.Step;
        }

        public static double RightRect(IntegrateOptions options, Func<double, int, bool> cancelProgress = null)
        {
            double result = 0;

            bool cancel = false;
            for (int i = 1; i <= options.Steps && !cancel; ++i)
            {
                result += options.Function(options.StartX + i * options.Step);
                if (cancelProgress != null)
                {
                    cancel = cancelProgress(result * options.Step, i* 100 / options.Steps);
                }
                Thread.Sleep(10);
                options.CountedSteps = i;
            }
            return result * options.Step;
        }

        public static double MidRect(IntegrateOptions options, Func<double, int, bool> cancelProgress = null)
        {
            double result = 0;

            bool cancel = false;
            for (int i = 0; i < options.Steps && !cancel; ++i)
            {
                result += options.Function(options.StartX + (i+0.5) * options.Step);
                if (cancelProgress != null)
                {
                    cancel = cancelProgress(result * options.Step, (i + 1) * 100 / options.Steps);
                }
                Thread.Sleep(10);
                options.CountedSteps = i + 1;
            }
            return result * options.Step;
        }
    }
}
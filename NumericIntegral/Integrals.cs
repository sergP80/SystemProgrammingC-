using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumericIntegral
{
    public class IntegrateOptions: INotifyPropertyChanged
    {
        private double startX;
        public double StartX
        { 
            get
            {
                return this.startX;
            }
            set
            {
                this.startX = value;
                this.NotifyChanged("StartX");
            }
        }

        private double endX;
        public double EndX 
        { 
            get
            {
                return this.endX;
            }
            set
            {
                this.endX = value;
                this.NotifyChanged("EndX");
            }
        }

        private int steps;
        public int Steps
        { 
            get
            {
                return this.steps;
            }
            set
            {
                this.steps = value;
                this.NotifyChanged("Steps");
            }
        }

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
                NotifyChanged("Tolerance");
            }
        }

        private Func<double, double> function;
        public Func<double, double> Function 
        { 
            get
            {
                return this.function;
            }
            set
            {
                this.function = value;
                this.NotifyChanged("Function");
            }
        }

        public double Step
        {
            get
            {
                return (EndX - StartX) / Steps;
            }
        }

        public double CountedSteps { get; internal set; } = 0;

        public bool IsValid
        {
            get
            {
                return this.StartX < this.EndX
                       && this.Steps > 0
                       && this.Function != null;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public override string ToString()
        {
            return string.Format("Options[start X: {0}, end X: {1}, step count: {2}, step size: {3}, tol: {4}]", StartX, EndX, Steps, Step, Tolerance);
        }
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
            return result * options.Step;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericIntegral
{
    
    public delegate double IntegralMethod(double a, double b, int n, Func<double, double> func);
    
    public static class Integrals
    {
        public static double LeftRect(double a, double b, int n, Func<double, double> func)
        {
            double result = 0, h = (b - a) / n;

            for (int i = 0; i < n; ++i)
            {
                result += func(a + i * h);
            }
            return result * h;
        }

        public static double RightRect(double a, double b, int n, Func<double, double> func)
        {
            double result = 0, h = (b - a) / n;

            for (int i = 1; i <= n; ++i)
            {
                result += func(a + i * h);
            }
            return result * h;
        }

        public static double MidRect(double a, double b, int n, Func<double, double> func)
        {
            double result = 0, h = (b - a) / n;

            for (int i = 0; i < n; ++i)
            {
                result += func(a + (i + 0.5) * h);
            }
            return result * h;
        }
    }
}

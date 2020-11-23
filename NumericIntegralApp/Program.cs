using NumericIntegral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericIntegralApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = -1, b = 0.9;
            int n = 100;

            IntegrateOptions options = new IntegrateOptions()
            {
                StartX = a,
                EndX = b,
                Steps = n,
                Function = x => 20 * x - 2.5 / (x - 1)
            };
            double S = Integrals.MidRect(options);

            Console.WriteLine("Result {0:#.###E+00}", S);
        }
    }
}

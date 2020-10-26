using System;
using ArrayUtils;

namespace ArraysApp
{
    class Program
    {
        static double Func2(double x1, double x2)
        {
            return Math.Abs(Math.Cos(Math.Exp(x2 / x1)))/(4 + x2);
        }

        static void Main(string[] args)
        {
            double startX = 1, dx = 0.5;
            const int size = 10;
            double[] arr = CustomArrayUtils.CreateArrayFromTemplate(startX, dx, size, x => Func2(x * 2.76, x * 0.5));
            CustomArrayUtils.PrintArray(arr);
            
            CustomArrayUtils.ProcessArray(arr, out double min, out double max, out double avg);
            
            Console.WriteLine("Min={0:#0.####}, Max={1:#0.####}, Avg={2:#0.####}", min, max, avg);

            int count = CustomArrayUtils.PostProcessArray(arr, x => x >= 0.9 * avg && x <= 1.1 * avg);
            Console.WriteLine("R={0}", count);
            
        }
    }
}
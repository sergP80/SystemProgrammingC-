using System;

namespace ArrayUtils
{
    public static class CustomArrayUtils
    {
        public static double[] CreateArrayFromTemplate(double startX, double dx, int size, Func<double, double> func)
        {
            double[] data = new double[size];
            double x = startX;
            for (int i = 0; i < size; ++i)
            {
                data[i] = func(x);
                x += dx;
            }
            return data;
        }

        public static void PrintArray(double[] data)
        {
            for (int i = data.GetLowerBound(0); i <= data.GetUpperBound(0); ++i)
            {
                Console.WriteLine("arr[{0}]={1:#0.####}", i, data[i]);
            }
        }

        public static void ProcessArray(double[] data, out double aMin, out double aMax, out double aAvg)
        {
            double S = data[0];
            aMin = aMax = S;
            for (int i = data.GetLowerBound(0) + 1; i <= data.GetUpperBound(0); ++i)
            {
                S += data[i];
                
                if (aMin > data[i])
                {
                    aMin = data[i];
                }

                if (aMax < data[i])
                {
                    aMax = data[i];
                }
            }

            aAvg = S / data.Length;
        }

        public static int PostProcessArray(double[] data, Predicate<double> pred)
        {
            int count = 0;
            for (int i = data.GetLowerBound(0); i <= data.GetUpperBound(0); ++i)
            {
                if (pred(data[i]))
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
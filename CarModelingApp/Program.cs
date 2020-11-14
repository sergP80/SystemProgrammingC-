using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityClassLib;

namespace CarModelingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerVenichle venichle1 = new PassengerVenichle() 
            {
                Weight = double.Parse(Console.ReadLine())
            };

            Console.WriteLine(venichle1);

            venichle1.HasLoadTank = bool.Parse(Console.ReadLine());
        }
    }
}

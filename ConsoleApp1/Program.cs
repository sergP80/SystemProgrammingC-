using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector2DLib;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int x1 = 10;
            int x2 = -5;
            Point p1 = new Point(x1, x2);
            Console.WriteLine(p1);
            Point p2 = new Point(x1-10, x2 + 1);            
            Console.WriteLine(p2);
            Vector2D v1 = new Vector2D(p1, p2);
            Console.WriteLine(v1);
        }
    }
}

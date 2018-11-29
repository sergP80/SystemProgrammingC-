using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2DLib
{
    public class Point {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }

        public override bool Equals(object obj)
        {
            if (typeof(Point) != obj.GetType())
            {
                return false;
            }
            Point otherPoint = (Point)obj;
            return this.X == otherPoint.X && this.Y == otherPoint.Y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

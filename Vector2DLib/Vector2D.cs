using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2DLib
{
    public class Vector2D
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public double X
        {
            get
            {
                return EndPoint.X - StartPoint.X;
            }
        }

        public double Y
        {
            get
            {
                return EndPoint.Y - StartPoint.Y;
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public double Angle
        {
            get
            {
                return Math.Atan2(Y , X);
            }
        }

        public Vector2D()
        {
        }

        public Vector2D(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}] L:{2:###.###}, {3:###.###}",
                StartPoint, EndPoint, Length, Angle);
        }

        public override bool Equals(object obj)
        {

            if (typeof(Vector2D) != obj.GetType())
            {
                return false;
            }
            Vector2D otherVector = (Vector2D)obj;
            return this.X == otherVector.X && this.Y == otherVector.Y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

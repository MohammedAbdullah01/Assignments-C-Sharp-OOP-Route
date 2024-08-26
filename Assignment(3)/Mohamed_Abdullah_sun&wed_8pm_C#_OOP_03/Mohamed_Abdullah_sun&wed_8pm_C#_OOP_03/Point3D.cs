using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Abdullah_sun_wed_8pm_C__OOP_03
{
    internal class Point3D : ICloneable , IComparable<Point3D>
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int X) : this(X, 0, 0) { }

        public Point3D(int X, int Y) : this(X ,Y , 0){}

        public Point3D(int X , int Y , int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }



        public static bool operator ==(Point3D point1, Point3D point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y && point1.Z == point2.Z;
        }

        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return point1.X != point2.X || point1.Y != point2.Y && point1.Z != point2.Z;

        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Point3D point) 
                return X == point.X &&  Y == point.Y && Z == point.Z;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public object Clone()
        {
            Point3D NewPoint = new Point3D(X, Y, Z );
            return NewPoint;
        }

        public int CompareTo(Point3D? other)
        {
            int result = X.CompareTo(other?.X);
            if (result == 0)
            {
                result = Y.CompareTo(other?.Y);
                if (result == 0)
                {
                    result = Z.CompareTo(other?.Z);
                }
            }
            return result;
        }


        public override string ToString()
        {
            return $"({X}, {Y} , {Z})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic05.Project1
{
    internal class Point3D : IComparable , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Z { get; set; }      


        public Point3D() 
        {
            
        }
        public Point3D(int _x)
        {
            X = _x;
            Y = 0;
            Z = 0;
        }
        public Point3D(int _x, int _y) : this(_x)
        {
            Y = _y;
        }
        public Point3D(int _x ,int _y , int _z) : this(_x, _y)
        {
            Z = _z;
        }
        public override string ToString()
        {
            return $"Point Coordinates :({X},{Y},{Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D point3D = (Point3D)obj;
            if(this.X.CompareTo(point3D.X) == 0)
              return  this.Y.CompareTo(point3D.Y);
            else
               return this.X.CompareTo(point3D.X);
        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z,
            };
        }

        

        public static bool operator == (Point3D left, Point3D right)
        {
           return ((left?.X == right?.X) && (left?.Y == right?.Y) && (left?.Z == right?.Z));
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return ((left?.X != right?.X) || (left?.Y != right?.Y) || (left?.Z != right?.Z));
        }

    }
}

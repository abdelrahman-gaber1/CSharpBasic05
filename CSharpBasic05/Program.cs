using CSharpBasic05.Project1;
using CSharpBasic05.Project2;
using CSharpBasic05.ProjectThree;
using System.Collections.Immutable;

namespace CSharpBasic05
{
    internal class Program
    {
        static void Main()
        {
            #region ProjectOne
            //bool s = int.TryParse(Console.ReadLine(), out int x1);
            //Point3D p1 = new Point3D()
            //{ 
            //    X =x1,
            //    Y = int.Parse(Console.ReadLine()),
            //    Z = Convert.ToInt32(Console.ReadLine()),

            //};

            //bool ss = int.TryParse(Console.ReadLine(), out int x2);
            //Point3D p2 = new Point3D()
            //{
            //    X = x2,
            //    Y = int.Parse(Console.ReadLine()),
            //    Z = Convert.ToInt32(Console.ReadLine()),

            //};

            
            
            //if (p1 == p2)  // Does it work properly?  NO Because it compare addresses
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");


            //Point3D[] point3Ds =
            //{
            //    new Point3D(5 , 10 , 20),
            //    new Point3D (5 , 8 , 7),
            //    new Point3D (4 , 7 , 2),
            //    new Point3D (7 , 2 , 1),
            //};

            //Array.Sort(point3Ds);

            //foreach (Point3D p in point3Ds)
            //{
            //    Console.WriteLine(p.ToString());
            //}


            //Point3D p3 = new Point3D();
            //p3 =(Point3D)p1.Clone();
            //Console.WriteLine(p3);
            #endregion

            #region ProjectTwo

            Console.WriteLine(BasicMath.Add(41,4));
            Console.WriteLine(BasicMath.Subtract(7,4));
            Console.WriteLine(BasicMath.Divide(40,4));
            Console.WriteLine(BasicMath.Multiply(5,4));

            #endregion

            #region ProjectThree
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            #endregion
        }
    }
}

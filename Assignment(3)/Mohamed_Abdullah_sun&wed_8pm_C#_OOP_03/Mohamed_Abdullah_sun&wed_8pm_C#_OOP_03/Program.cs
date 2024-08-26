using System.Drawing;
using System.Reflection;

namespace Mohamed_Abdullah_sun_wed_8pm_C__OOP_03
{
    internal class Program
    {

        #region Function EnterPointFromUser From Assignment => First Project
        static Point3D EnterPointFromUser()
        {
            Console.WriteLine("Enter Please Points:");
            Console.Write("Enter Point: ");
            string InputPointX = Console.ReadLine() ?? "";
            Console.Write("Enter Point: ");
            string InputPointY = Console.ReadLine() ?? "";

            if (int.TryParse(InputPointX, out int pointX) && int.TryParse(InputPointY, out int pointY))
            {
                return new Point3D(pointX, pointY);

            }
            return new Point3D();
        }
        #endregion
        static void Main(string[] args)
        {
            #region First Project
            //Point3D point1 = EnterPointFromUser();

            //Point3D point2 = EnterPointFromUser();

            //Point3D[] points = 
            //{
            //    point1,
            //    point2
            //};

            //Array.Sort(points);

            //Console.WriteLine("Sorted points:");

            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //} 
            #endregion


            #region Second Project
            //IShape[] shape = 
            //{
            //    new Circle(5),
            //    new Rectangle(4, 6),
            //};

            //foreach (IShape item in shape)
            //{
            //    item.DisplayShapeInfo();
            //} 
            #endregion


            #region Third Project

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); // Output: Hours: 1, Minutes: 10, Seconds: 15

            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString()); // Output: Hours: 1, Minutes: 0, Seconds: 0

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString()); // Output: Hours: 2, Minutes: 10, Seconds: 0

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString()); // Output: Minutes: 11, Seconds: 6

            // Test Addition
            D3 = D1 + D2;
            Console.WriteLine(D3.ToString()); // Output: Hours: 3, Minutes: 10, Seconds: 0

            D3 = D1 + 7800;
            Console.WriteLine(D3.ToString()); // Output: Hours: 3, Minutes: 10, Seconds: 0

            D3 = 666 + D3;
            Console.WriteLine(D3.ToString()); // Output: Hours: 3, Minutes: 21, Seconds: 6

            // Test Increment
            D3 = ++D1;
            Console.WriteLine(D3.ToString()); // Output: Hours: 1, Minutes: 1, Seconds: 0

            // Test Decrement
            D3 = --D2;
            Console.WriteLine(D3.ToString()); // Output: Hours: 2, Minutes: 9, Seconds: 0

            // Test Subtraction
            D1 = D1 - D2;
            Console.WriteLine(D1.ToString()); // Output: Seconds: 0

            // Test Comparisons
            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }

            // Test Implicit Conversion to bool
            if (D1)
            {
                Console.WriteLine("D1 is non-zero");
            }

            // Test Explicit Conversion to DateTime
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString("HH:mm:ss")); // Output 00:00:00

            #endregion





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Constructor
{
    [Flags]
    enum UserWrights
    {
        CanRead = 1,
        CanWrite = 2,
        CanReadWrite = 3,
        CanDelete = 4,
        CanUpdate = 8,
    }

    struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 5;
            point.Y = 6;
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Point point2 = new Point(10, 20);
            //point2.X = 8;
            //point2.Y = 10;
            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);


            Console.ReadKey();
        }
    }
}

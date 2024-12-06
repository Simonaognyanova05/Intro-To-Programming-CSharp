using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
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

        public void MovePoint(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 5;
            point.Y = 6;
            point.MovePoint(-5, 10);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Point point2 = new Point(10, 20);
            point2.MovePoint(-5, -20);
            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);


            Console.ReadKey();
        }
    }
}

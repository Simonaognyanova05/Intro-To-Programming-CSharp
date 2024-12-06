using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
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

        public int _X
        {
            get { return X; }
        }

        public int _Y
        {
            get { return Y; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.MovePoint(-5, 10);
            Console.WriteLine(point._X);
            Console.WriteLine(point._Y);

            Point point2 = new Point(10, 20);
            point2.MovePoint(-5, -20);
            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);


            Console.ReadKey();
        }
    }
}

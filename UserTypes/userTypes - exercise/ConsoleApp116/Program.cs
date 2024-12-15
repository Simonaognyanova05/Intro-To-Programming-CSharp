using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp116
{
    [Flags]
    enum UserWrights
    { 
       CanRead = 1,
       CanWrite = 2,
       CanReadWrite = 3,
       CanDelete = 4,
       CanMove = 8
    
    }

    struct Point
    {
        private int x;
        private int y;

        public void MovePoint(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
           

        }

        public int Y
        {
            get { return y; }
        }

    }


    class PointClass
    {
        private int x;
        private int y;

        public void MovePoint(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }


        }

        public int Y
        {
            get { return y; }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

                       
            PointClass p1 = new PointClass(0, 0);
            Point p2 = new Point(0, 0);
            p1.MovePoint(5, 8);
            MovePointStruct(p2);
            MovePointClass(p1);

            Console.WriteLine($"p1 x={p1.X}, y={p1.Y}");
            Console.WriteLine($"p2 x={p2.X}, y={p2.Y}");


            p1.MovePoint(3, 7);
            p2.MovePoint(-10, 3);
           


            Console.WriteLine($"p1 x={p1.X}, y={p1.Y}");
            Console.WriteLine($"p2 x={p2.X}, y={p2.Y}");



            UserWrights user1 = UserWrights.CanRead;
            UserWrights user2 = UserWrights.CanRead | UserWrights.CanWrite
                | UserWrights.CanDelete;
            Console.WriteLine(user1);
            Console.WriteLine(user2);

            if((user2 & UserWrights.CanReadWrite) == UserWrights.CanReadWrite)
                Console.WriteLine("User can read and write");
            else
                Console.WriteLine("User can NOT read and write");


            Console.ReadKey();
        }

        static void MovePointStruct(Point p)
        {
            p.MovePoint(5, 5);
        }

        static void MovePointClass(PointClass p)
        {
            p.MovePoint(5, 5);
        }
    }
}

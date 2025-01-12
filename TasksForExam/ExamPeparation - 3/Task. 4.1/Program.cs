using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._4._1
{
    internal class Program
    {
        static long IterRowFromLector(int n)
        {
            long a1 = 2;
            long a2 = 4;
            long a3 = 6;

            switch (n)
            {
                case 1: return a1;
                    case 2: return a2;
                        case 3: return a3;
                default:
                    {
                        long a = 0;
                        for(int i = 4; i <= n; i++)
                        {
                            a = 3 * a1 + 4 * a2 - 7 * a3;
                            a1 = a2;
                            a2 = a3;
                            a3 = a;
                        }
                        return a;
                    }

            }
        }

        static long IterRow(int n)
        {
            long a1 = 2;
            long a2 = 4;
            long a3 = 6;

            if(n == 1)
            {
                return a1;
            }
            else if(n == 2)
            {
                return a2;
            }
            else if(n == 3)
            {
                return a3;
            }
            else
            {
                long a = 0;
                for(int i = 4; i <= n; i++)
                {
                    a = 3 * a1 + 4 * a2 - 7 * a3;
                    a1 = a2;
                    a2 = a3;
                    a3 = a;
                };

                return a;
            }
        }

        static int RecRow(int n)
        {
            int a1 = 2;
            int a2 = 4;
            int a3 = 6;

            if (n == 1)
            {
                return a1;
            }
            else if( n == 2)
            {
                return a2;
            }
            else if(n == 3)
            {
                return a3;
            }
            else
            {
                return 3 * RecRow(n - 3) + 4 * RecRow(n - 2) - 7 * RecRow(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IterRowFromLector(10));
            Console.WriteLine(IterRow(10));
            Console.WriteLine(RecRow(10));
        }
    }
}

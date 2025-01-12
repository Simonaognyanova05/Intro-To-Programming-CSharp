using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._4._1
{
    internal class Program
    {
        static long IterRow(int n)
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
        static void Main(string[] args)
        {
            Console.WriteLine(IterRow(2));
        }
    }
}

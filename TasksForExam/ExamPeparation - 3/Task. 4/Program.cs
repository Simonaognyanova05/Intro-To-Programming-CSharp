using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._4
{
    internal class Program
    {
        static int findNElement(int a, int n)
        {
            int ai = 0;
            for (int i = 1; i <= n; i++)
            {
                ai = 3 * ai - 3 + 4 * ai - 2 - 7 * ai - 1;
            }

            return ai;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(findNElement(a, n));
        }
    }
}

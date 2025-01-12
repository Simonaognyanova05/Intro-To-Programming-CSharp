using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._5
{
    internal class Program
    {
        static int SumOfNums(int n)
        {

            if(n == 0)
            {
                return 0;
            }

            return n + SumOfNums(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNums(3));
        }
    }
}

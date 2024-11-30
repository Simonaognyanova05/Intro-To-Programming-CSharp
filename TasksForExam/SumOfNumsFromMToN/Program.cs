using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumsFromMToN
{
    internal class Program
    {
        static int FindSum(int m, int n)
        {
            if(m == n)
            {
                return m;
            }

            int sum = m + FindSum(m + 1, n - 1) + n;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Въведете n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = FindSum(m, n);
            Console.WriteLine($"Сумата е {sum}");
        }
    }
}

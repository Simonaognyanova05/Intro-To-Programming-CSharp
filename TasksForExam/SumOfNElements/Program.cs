using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNElements
{
    internal class Program
    {
        static int SumOfNElements(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            int sum = n + SumOfNElements(n - 1);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = SumOfNElements(n);
            Console.WriteLine($"Сумата на елементите: {sum}");
        }
    }
}

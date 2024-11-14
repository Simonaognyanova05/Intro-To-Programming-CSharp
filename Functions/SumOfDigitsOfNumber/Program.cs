using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsOfNumber
{
    internal class Program
    {
        static int SumOfDigitsOgNumber(int number)
        {
            if(number == 0)
            {
                return 0;
            }

            return (number % 10) + SumOfDigitsOgNumber(number / 10);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfDigitsOgNumber(number);

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}

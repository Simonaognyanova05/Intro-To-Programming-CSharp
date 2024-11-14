using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecoursive
{
    internal class Program
    {
        static int FactorialRecoursive(int number)
        {
            if (number <= 1) return 1;

            return number * FactorialRecoursive(--number);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial = FactorialRecoursive(number);

            Console.WriteLine(factorial);
            Console.ReadKey();  

        }
    }
}

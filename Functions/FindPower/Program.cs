using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPower
{
    internal class Program
    {
        static double FindPower(double a)
        {
            double power = a * a * a;
            return power;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a} to the power of three is {FindPower(a)}");
            Console.ReadKey();  
        }
    }
}

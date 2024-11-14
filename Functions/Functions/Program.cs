using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static double SumOfNumbers(double a, double b) 
        {
            double sum = a + b;
            return sum; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of {a} and {b} is {SumOfNumbers(a, b)}.");
            Console.ReadKey();
        }
    }
}

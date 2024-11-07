using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start of interval: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the end of interval: ");
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = a; i <= b; i++) 
            { 
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);
        }
    }
}

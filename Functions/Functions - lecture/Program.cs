using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n; 
            bool isInteger = int.TryParse(line, out n);
            if(isInteger)
                Console.WriteLine($"Valid integer value {n}");
            else
            {
                Console.WriteLine($"Invalid integer value {line} {n}");
            }


            Console.ReadKey();
             n = InputPositiveInteger("Enter an integer value > 0 (km.)");
            int m = InputInteger("Enter another integer value (km.)");

            Console.WriteLine("Before swap");
            Console.WriteLine($"n={n}");
            Console.WriteLine($"m={m}");

            /*Swap(ref n, ref m);
            Console.WriteLine("Aftrer swap");
            Console.WriteLine($"n={n}");
            Console.WriteLine($"m={m}");*/
            int res;
            int rem;
            bool ok = Division(n, m, out res, out rem);
            if (ok == true)
            {
                Console.WriteLine($"Result = {res}");
                Console.WriteLine($"Reminder = {rem}");
            }
            else
                Console.WriteLine("Invalid arguments - Division by 0");



            Console.ReadKey();
        }
        private static bool Division(int a, int b,
            out int result, out int reminder)
        {
            if(b == 0)
            {
                result = 0;
                reminder = 0;
                return false;
            }
            
            result = a / b;
            reminder = a % b;
            return true;
        }

        private static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        private static int InputInteger(string message)
        {
            Console.WriteLine(message);
            string line = Console.ReadLine();
            int n = int.Parse(line);
            return n;
        }

        private static int InputPositiveInteger(string message)
        {
            int n;
            do
            {
               n = InputInteger(message);
            } while (n <= 0);
            return n;

        }


    }
}

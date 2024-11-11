using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Term
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Въведете стойност за n: ");
            int n = int.Parse(Console.ReadLine());

            int resIterative = IterativeMethod(n);
            Console.WriteLine("Резултат от итеративен метод: " + resIterative);

            int resRecursive = RecursiveMethod(n);
            Console.WriteLine("Резултат от рекурсивен метод: " + resRecursive);

            Console.ReadLine();
        }

        static int IterativeMethod(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            if (n == 2)
            {
                return 4;
            }
            if (n == 3)
            {
                return 6;
            }

            int a1 = 2, a2 = 4, a3 = 6;
            int current = 0;

            for (int i = 4; i <= n; i++)
            {
                current = 3 * a1 + 4 * a2 - 7 * a3;
                a1 = a2;
                a2 = a3;
                a3 = current;
            }

            return current;
        }

        static int RecursiveMethod(int n)
        {
            if (n == 1) 
            {
                return 2;
            };
            if (n == 2)
            {
                return 4;
            };
            if (n == 3)
            {
                return 6;
            }

            return 3 * RecursiveMethod(n - 3) + 4 * RecursiveMethod(n - 2) - 7 * RecursiveMethod(n - 1);
        }
    }
}

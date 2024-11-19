using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           



            Console.WriteLine("Enter n >= 1");
            uint n = uint.Parse(Console.ReadLine());
            ulong result;

            //Извикване на итеративния вариант на Фактуриел функцията
            result = IterFactorial(n);
            Console.WriteLine($"Iterative {n}! = {result}");

            //Извикване на рекурсивният вариант на Фактуриел функцията
            result = Factorial(n);
            Console.WriteLine($"Recursive {n}! = {result}");

            //Извикване на рекурсивният вариант на Фибуначи функцията
            Console.WriteLine("Enter k >= 1");
            int k = int.Parse(Console.ReadLine());
            int res = RFib(k);
            Console.WriteLine($"Fib ({k}) = {res}");

            //Извикване на рекурсивният вариант за намиране на n-ти член на редица
            res = RecRow(7);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        /*Рекурсивна функция за намиране на n-ти член на редица, 
         * в която първите три члена са съответно 2, 4 и 6,
         * а всеки следващ се определя по следния начин
         * Аn = 3*A(n-1) + 4*A(n-2) - 7*A(n-3) */
        
        static int RecRow(int n)
        {

            if (n <= 1)
                return 2;
            if (n == 2)
                return 4;
            if (n == 3)
                return 6;

            

            return 3 * RecRow(n - 1) + 4 * RecRow(n - 2) - 7 * RecRow(n - 3);
        }


        //Рекурсивна ф-ция за намиране на n-ти член на редицата на Фибуначи
        static int RFib(int n)
        {
            if (n <= 2)
                return 1;
            return RFib(n - 1) + RFib(n - 2);
        }

        //Итеративна функция за намиране на n!
        static ulong IterFactorial(uint n)
        {
            ulong result = 1;
            for (uint i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        //Рекурсивна ф-ция за намиране на n!
        static ulong Factorial(uint n)
        {             
            if (n <= 1)
                return 1;

            return n * Factorial(n-1);
        }
    }
}

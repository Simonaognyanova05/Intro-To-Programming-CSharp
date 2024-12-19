using System;
using System.Text;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Въведете x:");
            int x = int.Parse(Console.ReadLine());  

            if(x % 2 == 0)
            {
                Console.WriteLine("Резултат от четната функция: " + EvenFunction(x)); 
            }
            else
            {
                Console.WriteLine("Резултат от нечетната функция: " + OddFunction(x));
            }
        }

        static int EvenFunction(int x)
        {
            int result = x / 2;
            int br = 0;

            while (result != 0)
            {
                result = result / 2;
                br++;
            }

            return br;
        }

        static int OddFunction(int x)
        {
            int result = (x * 3) + 1;
            int br = 0;

            while (result != 0) 
            {
                result = (result * 3) + 1;

                br++;
            }

            return br;
        }
    }
}

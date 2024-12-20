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

            Console.WriteLine("Резултат: " + Iterative(x));
        }

        static int Iterative(int x)
        {
            int br = 0;
            while(x != 1)
            {
                if(x % 2 == 0)
                {
                    x = x / 2;
                    br++;
                }
                else
                {
                    x = x * 3 + 1;
                    br++;
                }
            }
            return br;  
        }
    }
}

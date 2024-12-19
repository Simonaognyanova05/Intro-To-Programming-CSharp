using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Recoursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Въведете x: ");
            int x = int.Parse(Console.ReadLine());

            int result = Recursive(x);
            Console.WriteLine("Резултат: " + result);
        }

        static int Recursive(int x)
        {
            if(x % 2 == 0)
            {
                if (x == 1)
                {
                    return 0;
                }

                return 1 + Recursive(x / 2);
            }
            else
            {
                if (x == 1)
                {
                    return 0;
                }

                return 1 + Recursive(x * 3 + 1);
                
            }
        }
    }
}

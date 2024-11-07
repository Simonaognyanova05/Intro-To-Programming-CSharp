using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i < 20)
            {
                i++;
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}

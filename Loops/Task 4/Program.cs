using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int br = 0;
            double sum = 0;
            while (i < 20)
            {
                i++;
                if (i % 3 == 0)
                {
                    br++;
                    sum += i;
                }
            }

            Console.WriteLine(sum / br);

        }
    }
}

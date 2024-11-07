using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("Value of i: " + i);
                i++;
            }
            while (i <= 20);

        }
    }
}

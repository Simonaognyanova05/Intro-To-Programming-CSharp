using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld72
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Отпечатване на екрана на стрингова стойност
            Console.WriteLine("Hello world");
            
            //Въвеждане и отпечатване на стрингова стойност на стандартни вход/изход (конзола)
            Console.WriteLine("Въведете името си");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            
            
            //Сравнение на точността на типовете за работа със стойности с плаваща запетая
            float f = 1f / 3;
            Console.WriteLine(f);
            double d = 1.0 / 3;
            Console.WriteLine(d);
            decimal dc = 1M / 3;
            Console.WriteLine(dc);
            
            Console.ReadLine();
        }
    }
}

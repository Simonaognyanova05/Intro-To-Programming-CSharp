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
            string word;
            bool isStop = false;

            while (true)
            {
                word = Console.ReadLine();
                if(word == "stop")
                {
                    isStop = true;
                }
                if (isStop)
                {
                    continue;
                }
                Console.WriteLine("The output is: " + word);
            }
        }
    }
}

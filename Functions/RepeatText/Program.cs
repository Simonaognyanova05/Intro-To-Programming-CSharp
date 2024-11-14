using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatText
{
    internal class Program
    {
        static string RepeatText(int num, string text) 
        {
            string result = "";
            for (int i = 0; i < num; i++) 
            {
                result += text;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            Console.Write("Enter a num: ");
            int num = int.Parse(Console.ReadLine());

            string result = RepeatText(num, text);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

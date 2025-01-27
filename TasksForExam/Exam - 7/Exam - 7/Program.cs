using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___7
{
    internal class Program
    {
        static int[] ReadArrayFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] elements = lines[0].Split(',');
            int[] result = new int[elements.Length];

            for(int i = 0; i < elements.Length; i++)
            {
                result[i] = int.Parse(elements[i]);
            }

            return result;
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\simon\\source\\repos\\Exam - 7\\Exam - 7\\array.txt";

            Console.WriteLine(string.Join(" ", ReadArrayFromFile(path)));
        }
    }
}

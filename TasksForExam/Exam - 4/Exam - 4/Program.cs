using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___4
{
    internal class Program
    {
        static int[] ReadArrayFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] array = lines[0].Split('\t');

            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = int.Parse(array[i]);  
            }

            return newArray;
        }

        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            Console.WriteLine(string.Join(" ", ReadArrayFromFile(path)));
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    internal class Program
    {
        static double[] ReadArrayFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            string[] array = lines[0].Split('\t');

            double[] nums = new double[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                nums[i] = double.Parse(array[i]);   
            }

            return nums;
        }
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            double[] array = ReadArrayFromFile(path);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}

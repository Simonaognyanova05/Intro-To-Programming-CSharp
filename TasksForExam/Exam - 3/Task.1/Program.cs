using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Task._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Input file name:");
            string fileName = Console.ReadLine();

            int[] numbers = ReadArrayFromFile(fileName);
            Console.WriteLine("Old result: " + string.Join(" ", numbers));

            int[] reversed = ReverseInplace(numbers);
            Console.WriteLine("New Result: " + string.Join(" ", reversed));

        }

        static int[] ReadArrayFromFile(string fileName)
        { 
            string fileContent = File.ReadAllText(fileName);
            string[] parts = fileContent.Split(new char[] { '\t' });

            int[] numbers = parts.Select(int.Parse).ToArray();
            return numbers;
        }

        static int[] ReverseInplace(int[] array) 
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            };

            return array;
        }   
    }
}

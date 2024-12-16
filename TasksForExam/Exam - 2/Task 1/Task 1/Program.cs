using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Въведете името на файла: ");
            string fileName = Console.ReadLine();

           
            int[] numbers = ReadArrayFromFile(fileName);
            Console.WriteLine("Прочетен масив: ");
            Console.WriteLine(string.Join(", ", numbers));

            bool isSorted = IsSorted(numbers);
            Console.WriteLine(isSorted);

            int countTriplets = CountTriplets(numbers);
            Console.WriteLine(countTriplets);
        }

        static int CountTriplets(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[j] && arr[j] == arr[k])
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }



        static int[] ReadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файлът не съществува");
            }

            string fileContent = File.ReadAllText(fileName);
            string[] parts = fileContent.Split(new char[] { '\t' });

            int[] numbers = parts.Select(int.Parse).ToArray();

            return numbers;
        }

        static bool IsSorted(int[] numbers)
       {
            bool isSorted = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    isSorted = false;
                }
                else
                {
                    isSorted = true;
                }
            }
            return isSorted;
       }
    }
}

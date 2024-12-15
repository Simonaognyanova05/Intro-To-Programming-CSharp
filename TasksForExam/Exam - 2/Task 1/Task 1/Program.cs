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

            try
            {
                int[] numbers = ReadArrayFromFile(fileName);
                Console.WriteLine("Прочетен масив: ");
                Console.WriteLine(string.Join(", ", numbers));
            }
            catch
            {
                Console.WriteLine("Файлът не е намерен!");    
            }
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

    }
}

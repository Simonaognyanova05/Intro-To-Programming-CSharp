using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periods__commas_and_numbers
{
    internal class Program
    {
        static string FindPointsAndCommas(string text)
        {

            int points = 0;
            int commas = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    points++;
                }
                if (text[i] == ',')
                {
                    commas++;
                }
            }
            return $"Брой точки: {points}, брой запетаи: {commas}";
        }

        static int FindNums(string text)
        {
            int numbers = 0;
            bool inNumber = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    if (!inNumber)
                    {
                        inNumber = true;
                        numbers++;
                    }
                }
                else
                {
                    inNumber = false;
                }
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            string text = Console.ReadLine();

            Console.WriteLine(FindPointsAndCommas(text));
            Console.WriteLine("Брой числа в текста: " + FindNums(text));

        }
    }
}

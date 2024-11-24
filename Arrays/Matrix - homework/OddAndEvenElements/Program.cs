using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;  
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Брой редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Брой колони: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];    
            for (int i = 0; i < rows; i++) 
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"Въведете елемент [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + 1) % 2 != 0 && matrix[i, j] % 2 == 0)
                    {
                        evenSum += matrix[i, j];
                    }

                    if ((j + 1) % 2 == 0 && matrix[i, j] % 2 != 0)
                    {
                        oddSum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумата от четните по стойност елементи, намиращи се на нечетни редове: {evenSum}");
            Console.WriteLine($"Сумата от нечетните по стойност елементи, намиращи се на четни стълбове: {oddSum}");
        }
    }
}

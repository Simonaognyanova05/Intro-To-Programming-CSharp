using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix___homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Брой редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Брой колони: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"Въведете елемент [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

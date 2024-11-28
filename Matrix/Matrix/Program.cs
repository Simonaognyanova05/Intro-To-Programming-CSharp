using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine($"Enter value for [{row}, {col}]");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void OutputMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter row number: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter column number: ");
            int col = int.Parse(Console.ReadLine());

            int[,] m = new int[rows, col];

            InputMatrix(m);
            OutputMatrix(m);
            Console.ReadKey();
        }
    }
}

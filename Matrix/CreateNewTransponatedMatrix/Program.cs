using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNewTransponatedMatrix
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
        static void OutputTMatrix(int[,] matrix)
        {
            Console.WriteLine("Transponated Matrix");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] TransponatedMatrix(int[,] matrix)
        {
            int tRows = matrix.GetLength(1);
            int tCols = matrix.GetLength(0);
            int[,] tMatrix = new int[tRows, tCols];

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    tMatrix[col, row] = matrix[row, col];
                }
                Console.WriteLine();
            }
            return tMatrix;
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
            OutputTMatrix(m);

            int[,] tm = TransponatedMatrix(m);

            OutputMatrix(tm);
            Console.ReadKey();
        }
    }
}

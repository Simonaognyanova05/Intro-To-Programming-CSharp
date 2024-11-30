using System;

namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the matrix (N): ");
            int n = int.Parse(Console.ReadLine()!);

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                Console.Write($"Enter row {row + 1}: ");
                string input = Console.ReadLine()!;
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            Console.Write("Enter the symbol to search for: ");
            char symbol = char.Parse(Console.ReadLine()!);

            if (FindSymbol(matrix, symbol, out int foundRow, out int foundCol))
            {
                Console.WriteLine($"({foundRow}, {foundCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }

        private static bool FindSymbol(char[,] matrix, char symbol, out int row, out int col)
        {
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        return true;
                    }
                }
            }

            row = -1;
            col = -1;
            return false;
        }
    }
}
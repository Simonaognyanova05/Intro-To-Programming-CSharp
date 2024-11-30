using System;

namespace VprUpr9
{
    internal class Program
    {
        private static int SumElementsInMatrix(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }

        private static int[,] ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"Enter element[{row}, {col}]: ");
                    matrix[row, col] = int.Parse(Console.ReadLine()!);
                }
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the number of cols: ");
            int cols = int.Parse(Console.ReadLine()!);
            int[,] matrix = new int[rows, cols];

            Console.WriteLine($"The rows of the matrix are: {matrix.GetLength(0)}");
            Console.WriteLine($"The cols of the matrix are: {matrix.GetLength(1)}");
            Console.WriteLine($"The sum of the elements in the matrix is: {SumElementsInMatrix(ReadMatrix(matrix))}.");
        }
    }
}

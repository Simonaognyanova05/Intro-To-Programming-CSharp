using System.Buffers;

namespace SumColsInMatrix
{
    internal class Program
    {
        private static int[] SumMatrixCols(int[,] matrix)
        {
            int[] sumCols = new int[matrix.GetLength(1)];

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currentSum += matrix[row, col];
                }

                sumCols[col] = currentSum;
            }

            return sumCols;
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

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Sum of column {i}: {arr[i]}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the number of cols: ");
            int cols = int.Parse(Console.ReadLine()!);
            int[,] matrix = new int[rows, cols];

            PrintArray(SumMatrixCols(ReadMatrix(matrix)));
        }
    }
}

using System;
using System.Linq;

namespace MatrixOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine()!);
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()!
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                matrix[row] = new int[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = int.Parse(input[col]);
                }
            }

            while (true)
            {
                string command = Console.ReadLine()!;
                if (command == "END") break;

                string[] parts = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row < 0 || 
                    row >= matrix.Length || 
                    col < 0 || 
                    col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (action == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }

            foreach (var row in matrix)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write(row[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

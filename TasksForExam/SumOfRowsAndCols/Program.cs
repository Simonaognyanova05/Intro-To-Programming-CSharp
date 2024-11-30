using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfRowsAndCols
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;  j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Въведете елемент [{i}, {j}]: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int[] SumOfRows(int[,] matrix)
        {
            int[] sumOfRows = new int[matrix.GetLength(0)];
            int sum = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    sumOfRows[i] = sum;
                }
                sum = 0; 
            }

            return sumOfRows;
        }

        static int[] SumOfCols(int[,] matrix)
        {
            int[] columnSums = new int[matrix.GetLength(1)];

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    columnSums[col] += matrix[row, col];
                }
            }

            return columnSums;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете брой редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Въведете брой колони: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            InputMatrix(matrix);

            int[] sumRows = SumOfRows(matrix);
            Console.Write("Сума от редовете: ");
            foreach (int sum in sumRows) 
            {
                Console.Write(sum + " ");
            }
            Console.WriteLine();

            int[] sumCols = SumOfCols(matrix);
            Console.Write("Сума от колоните: ");
            foreach (int sum1 in sumCols)
            {
                Console.Write(sum1 + " ");
            }

            Console.ReadKey();
        }
    }
}

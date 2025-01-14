using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    internal class Program
    {
        static int[,] ReadTriangleMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Console.WriteLine($"Въведете елементите на горната триъгълна матрица, разделени с интервал (само над главния диагонал):");

            for (int i = 0; i < n; i++)
            {
                string[] rowElements = Console.ReadLine().Split(' ');

                for (int j = i; j < n; j++)
                {
                    matrix[i, j] = int.Parse(rowElements[j - i]);
                }
            }

            return matrix;
        }

        static int[] GetColumnsMax(int[,] matrix)
        {
            int cols = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            int[] columnMaxes = new int[cols]; 

            for (int col = 0; col < cols; col++)
            {
                int columnMax = matrix[0, col];
                for (int row = 1; row < rows; row++)
                {
                    if (matrix[row, col] > columnMax)
                    {
                        columnMax = matrix[row, col]; 
                    }
                }

                columnMaxes[col] = columnMax; 
            }

            return columnMaxes; 
        }

        static void GetMinMax(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = ReadTriangleMatrix(n);
            PrintMatrix(matrix);

            int[] array = GetColumnsMax(matrix);
            Console.WriteLine(string.Join(" ", array));
            GetMinMax(array, out int min, out int max);

            Console.WriteLine($"Min: {min}, Max: {max}");   
        }
    }
}

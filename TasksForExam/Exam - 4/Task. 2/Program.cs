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
        }
    }
}

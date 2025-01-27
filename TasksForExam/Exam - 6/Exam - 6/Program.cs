using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___6
{
    class Program
    {
        static void ReadTriangleMatrix(int[,] matrix, int N)
        {
            Console.WriteLine("Въведете елементите на горната триъгълна матрица:");

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++) 
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int[] GetColumnsMax(int[,] matrix, int N)
        {
            int[] columnMax = new int[N];

            for (int j = 0; j < N; j++)
            {
                int max = matrix[0, j];

                for (int i = 1; i < N; i++) 
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }

                columnMax[j] = max;
            }

            return columnMax;
        }

        static void GetMinMax(int[] columnMax, out int min, out int max)
        {
            min = columnMax[0];
            max = columnMax[0];

            foreach (int value in columnMax)
            {
                if (value < min)
                    min = value;
                if (value > max)
                    max = value;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведете размера на матрицата (N): ");
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            ReadTriangleMatrix(matrix, N);

            int[] columnMax = GetColumnsMax(matrix, N);

            Console.WriteLine("Максималните стойности по стълбове:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Стълб {i}: {columnMax[i]}");
            }

            GetMinMax(columnMax, out int min, out int max);

            Console.WriteLine($"Минимална стойност: {min}");
            Console.WriteLine($"Максимална стойност: {max}");

            PrintMatrix(matrix);
        }
    }
}

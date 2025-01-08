using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation___2
{
    internal class Program
    {
        static void PrintMatrix(decimal[,] matrix)
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
            string filePath = "C:\\Users\\simon\\source\\repos\\ExamPreparation - 2\\ExamPreparation - 2\\matrix.txt";

            decimal[,] matrix;

            using (var f = File.OpenText(filePath))
            {
                int rows = int.Parse(f.ReadLine());
                int cols = int.Parse(f.ReadLine());

                matrix = new decimal[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    var elements = f.ReadLine().Split('\t');
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = decimal.Parse(elements[j]);
                    }
                }

            }
            PrintMatrix(matrix);
        }
    }
}

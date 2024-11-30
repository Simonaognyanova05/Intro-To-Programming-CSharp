using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForExam
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Въведете елемент [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void CheckIfMatrixAreEqual(int[,] matrix1, int[,] matrix2)
        {
            bool isEqual = false;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                    }
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Матриците са еднакви!");
            }
            else
            {
                Console.WriteLine("Матриците не са еднакви!");
            }
        }
        static void Main(string[] args)
        { 
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете брой редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Въведете брой колони: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            Console.WriteLine("Първа матрица");
            InputMatrix(matrix1);

            int[,] matrix2 = new int[rows, cols];
            Console.WriteLine("Втора матрица");
            InputMatrix(matrix2);

            CheckIfMatrixAreEqual(matrix1, matrix2);
        }
    }
}

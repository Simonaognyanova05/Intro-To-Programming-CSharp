using System;
using System.Text;

class Program
{
    static void PrintAboveDiagonal(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col > row)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Въведете размера на квадратната матрица: ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];

        Console.WriteLine("Въведете елементите на матрицата (по редове):");
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write($"Елемент [{row + 1}, {col + 1}]: ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Елементите над главния диагонал са:");
        PrintAboveDiagonal(matrix);
    }
}

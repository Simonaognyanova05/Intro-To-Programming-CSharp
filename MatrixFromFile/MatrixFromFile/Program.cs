using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("File name:");
        string fileName = Console.ReadLine();

        try
        {
            decimal[,] matrix = ReadMatrixFromFile(fileName);

            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);

            Console.WriteLine("Is single: " + CheckIdentity(matrix));

            Console.WriteLine("Нegative elements of the secondary diagonal: " + SumNegativeOnAntiDiagonal(matrix));

            NormalizeRows(matrix);
            Console.WriteLine("Normalized matrix:");
            PrintMatrix(matrix);

            SortMatrix(matrix);
            Console.WriteLine("Sorted matrix:");
            PrintMatrix(matrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erroe: {ex.Message}");
        }
    }

    static decimal[,] ReadMatrixFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException("File not found.");
        }

        string[] lines = File.ReadAllLines(fileName);
        int rows = int.Parse(lines[0]);
        int cols = int.Parse(lines[1]);

        decimal[,] matrix = new decimal[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            decimal[] row = lines[i + 2].Split(' ').Select(decimal.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        return matrix;
    }

    static void PrintMatrix(decimal[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool CheckIdentity(decimal[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j && matrix[i, j] != 1)
                {
                    return false;
                }
                else if (i != j && matrix[i, j] != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static decimal SumNegativeOnAntiDiagonal(decimal[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            throw new InvalidOperationException("The matrix is ​​not square.");
        }

        decimal sum = 0;
        for (int i = 0; i < rows; i++)
        {
            int antiDiagonalIndex = cols - i - 1;
            if (matrix[i, antiDiagonalIndex] < 0)
            {
                sum += matrix[i, antiDiagonalIndex];
            }
        }

        return sum;
    }

    static void NormalizeRows(decimal[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            decimal sumOfSquares = 0;

            for (int j = 0; j < cols; j++)
            {
                sumOfSquares += matrix[i, j] * matrix[i, j];
            }

            decimal norm = (decimal)Math.Sqrt((double)sumOfSquares);

            if (norm > 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] /= norm;
                }
            }
        }
    }

    static void SortMatrix(decimal[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            decimal[] column = new decimal[rows];
            for (int i = 0; i < rows; i++)
            {
                column[i] = matrix[i, j];
            }

            if (j % 2 == 0) 
            {
                Array.Sort(column);
            }
            else
            {
                Array.Sort(column);
                Array.Reverse(column);
            }

            for (int i = 0; i < rows; i++)
            {
                matrix[i, j] = column[i];
            }
        }
    }
}

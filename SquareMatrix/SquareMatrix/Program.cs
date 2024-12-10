using System;
using System.IO;

class MatrixApp
{
    static void InitializeMatrixFromFile(string filePath, int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = -1;
            }
        }

        try
        {
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('\t');
                int row = int.Parse(parts[0]);
                int col = int.Parse(parts[1]);
                int value = int.Parse(parts[2]);
                matrix[row, col] = value;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Incorrect file format.");
        }
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static (int evenSum, int oddSum) CalculateSums(int[,] matrix, int n)
    {
        int evenSum = 0, oddSum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] % 2 == 0)
                    evenSum += matrix[i, j];
                else
                    oddSum += matrix[i, j];
            }
        }
        return (evenSum, oddSum);
    }

    static (int evenRowSum, int oddColSum) CalculateRowAndColumnSums(int[,] matrix, int n)
    {
        int evenRowSum = 0, oddColSum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i % 2 == 0)
                    evenRowSum += matrix[i, j];
                if (j % 2 != 0)
                    oddColSum += matrix[i, j];
            }
        }
        return (evenRowSum, oddColSum);
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter the size of the matrix (N): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("N must be a positive integer.");
                return;
            }

            Console.Write("Enter the path to the file: ");
            string filePath = Console.ReadLine();

            int[,] matrix = new int[n, n];

            InitializeMatrixFromFile(filePath, n, matrix);

            Console.WriteLine("\nMatrix:");
            PrintMatrix(matrix, n);

            var (evenSum, oddSum) = CalculateSums(matrix, n);
            Console.WriteLine($"\nSum of even elements: {evenSum}");
            Console.WriteLine($"Sum of odd elements: {oddSum}");

            var (evenRowSum, oddColSum) = CalculateRowAndColumnSums(matrix, n);
            Console.WriteLine($"\nSum of elements in even rows: {evenRowSum}");
            Console.WriteLine($"Sum of elements in odd columns: {oddColSum}");

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}

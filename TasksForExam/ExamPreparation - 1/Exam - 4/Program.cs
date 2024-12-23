using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        string filePath = "C:\\Users\\simon\\source\\repos\\Exam - 4\\Exam - 4\\matrix.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файлът не съществува.");
            return;
        }

        try
        {
            int[,] matrix = ReadMatrixFromFile(filePath);

            Console.WriteLine("Прочетената матрица:");
            PrintMatrix(matrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Възникна грешка при четенето на файла: {ex.Message}");
        }
    }

    static int[,] ReadMatrixFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);

        string[] dimensions = lines[0].Split(' ');
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string[] elements = lines[i + 1].Split(' ');

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(elements[j]);
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
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
}

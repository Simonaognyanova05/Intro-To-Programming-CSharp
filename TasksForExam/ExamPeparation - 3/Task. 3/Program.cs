using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._3
{
    internal class Program
    {

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

        static int[,] ReadSecondMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] rowsCols = lines[0].Split(' ');

            int rows = int.Parse(rowsCols[0]);
            int cols = int.Parse(rowsCols[1]);

            int[,] matrix = new int[rows, cols];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = -1;
                }
            }

            for(int i = 1; i < lines.Length; i++)
            {
                string[] elements = lines[i].Split(' ');
                int rowIndex = int.Parse(elements[0]);  
                int colIndex = int.Parse(elements[1]);
                int value = int.Parse(elements[2]);
                matrix[rowIndex, colIndex] = value;
       
            }
            return matrix;
        }
       
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\simon\\OneDrive\\Desktop\\Intro-To-Programming-CSharp\\TasksForExam\\ExamPeparation - 3\\ExamPeparation - 3\\matrix2.txt";

            int[,] secondMAtrix = ReadSecondMatrix(filePath);
            PrintMatrix(secondMAtrix);
        }
    }
}

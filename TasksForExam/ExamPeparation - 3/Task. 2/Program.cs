using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    internal class Program
    {
        static int[,] ReadMatrix(string pathName)
        {
            if (!File.Exists(pathName))
            {
                throw new Exception("File does not exists!");
            }
            string[] lines = File.ReadAllLines(pathName);
            string[] rowValues = (lines[0].Split('\t'));

            int rows = lines.Length;
            int cols = rowValues.Length;

            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] elements = lines[i].Split('\t');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]);
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

        static void SaveMatrix(int[,] matrix, string path)
        {
            string[] lines = new string[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string row = matrix[i, 0].ToString();
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    row = row + '\t' + matrix[i, j].ToString();
                }
                lines[i] = row;
            }
            File.WriteAllLines(path, lines);
        }
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\simon\\OneDrive\\Desktop\\Intro-To-Programming-CSharp\\TasksForExam\\ExamPeparation - 3\\ExamPeparation - 3\\newMatrix.txt";

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] newMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            SaveMatrix(newMatrix, filePath);
            int[,] matrix = ReadMatrix(filePath);
            PrintMatrix(matrix);
        }
    }
}

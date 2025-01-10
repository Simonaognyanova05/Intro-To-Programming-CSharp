using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPeparation___3
{
    internal class Program
    {
        static int[,] ReadMatrix(string pathName)
        {
            string[] lines = File.ReadAllLines(pathName);
            string[] rowValues = (lines[0].Split('\t'));

            int rows = lines.Length;
            int cols = rowValues.Length;

            int[,] matrix = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                string[] elements = lines[i].Split('\t');
                for(int j = 0; j < cols; j++)
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
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\simon\\OneDrive\\Desktop\\Intro-To-Programming-CSharp\\TasksForExam\\ExamPeparation - 3\\ExamPeparation - 3\\matrix.txt";

            int[,] matrix = ReadMatrix(filePath);
            PrintMatrix(matrix);
        }
    }
}

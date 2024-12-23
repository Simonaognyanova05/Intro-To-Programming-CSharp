using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteMatrixIntoFile
{
    internal class Program
    {
        static void WriteMatrix(int[,] matrix, string path)
        {
            string[] lines = new string[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string row = matrix[i, 0].ToString();
                for (int k = 1; k < matrix.GetLength(1); k++)
                {
                    row = row + '\t' + matrix[i, k];
                }
                lines[i] = row;
            }
            File.WriteAllLines(path, lines);
        }
        static void Main(string[] args)
        {
            string pathName = "C:\\Users\\simon\\OneDrive\\Desktop\\Intro-To-Programming-CSharp\\TasksForExam\\ExamPreparation - 1\\Exam - 4\\matrix.txt";
            int[,] matrix = new int[,]
            {
                {2, 3, 4},
                {5, 6, 7}
            };

            WriteMatrix(matrix, pathName);
        }
    }
}

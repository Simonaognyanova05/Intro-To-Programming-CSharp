using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Upr11_2
{
    class Program
    {
        
        static void  ReadTextFile(string fileName)
        {
            if(File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
        }

        static void ReadTextFileByLines(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for(int i = 0; i < lines.Length; i++)
                    Console.WriteLine(lines[i]);
            }
        }

        static void ReadFileAllBytes(string fileName)
        {
            if(File.Exists(fileName))
            {
                byte[] bytes = File.ReadAllBytes(fileName);
                for(int i = 0; i < bytes.Length; i++)
                    Console.WriteLine(bytes[i]);
            }    
        }

        static void SaveTextToFile(string fileName, string[] content)
        {
            File.WriteAllLines(fileName, content);
        }

        static void GenerateRandomNumbersFile(string fileName)
        {
            var r = new Random();
            using(FileStream fs = File.Open(fileName, FileMode.Create, FileAccess.Write))
            {
                for(int i = 0; i < 100000; i++)
                {
                    int randomValue = r.Next();
                    string line = randomValue + Environment.NewLine;
                    byte[] lineBytes = Encoding.UTF8.GetBytes(line);
                    fs.Write(lineBytes, 0, lineBytes.Length);
                }
            }
        }

        static int[,] ReadMatrixFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return null;
            string[] lines = File.ReadAllLines(fileName);
            int rowsCount = lines.Length;
            if (rowsCount == 0)
                return null;
            string firstLine = lines[0];
            string[] parts = firstLine.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int colsCount = parts.Length;
            int[,] matrix = new int[rowsCount, colsCount];
            for(int row = 0; row < rowsCount; row++)
            {
                string[] colElements = lines[row].Split(new char[] { '\t' });
                for(int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = int.Parse(colElements[col]);
                }
            }
            return matrix;
        }


        static int[] ReadRandomNumbersFile(string fileName)
        {
            int[] numbers = new int[100000];
            using(StreamReader sr = File.OpenText(fileName))
            {
                int i = 0;
                while(!sr.EndOfStream)
                {
                   string line = sr.ReadLine();
                   numbers[i] =  int.Parse(line);
                    i++;

                }
            }
            return numbers;

        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // ReadTextFile("F:\\C#\\news.txt");
            // ReadTextFileByLines("F:\\C#\\news.txt");
           // ReadFileAllBytes("F:\\C#\\bigFile.mkv");
            string[] news = new string[] { "Новина от последния час", "Студентският празник се отменя", "Съобщи министърът на образованието" };
            /*SaveTextToFile("F:\\C#\\fakeNews.txt", news);
            byte[] bytes = new byte[10] { 123, 33, 54, 204, 2, 4, 6, 7, 9, 12 };
            File.WriteAllBytes("F:\\C#\\bytes.dat", bytes);*/
            //GenerateRandomNumbersFile("F:\\C#\\numbers.txt");
            /*int[] randomNumbers = ReadRandomNumbersFile("F:\\C#\\numbers.txt");
            for (int i = 0; i < randomNumbers.Length; i++)
                Console.WriteLine(randomNumbers[i]);*/
            int[,] matrix = ReadMatrixFromFile(@"F:\C#\matrix.txt");
            PrintMatrix(matrix);
                    
            Console.ReadKey();
        }
    }
}

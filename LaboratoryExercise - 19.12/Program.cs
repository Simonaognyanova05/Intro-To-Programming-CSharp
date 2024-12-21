using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] matrix = ReadMatrixFromFile("D:\\matrix.txt");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                    Console.Write($"{matrix[i,k]} ");
                Console.WriteLine();
            }
            
            
          

            try
            {
                int[] arr = ReadArrayFromFile("D:\\array1.txt");
                foreach (int i in arr)
                    Console.WriteLine(i);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
        
            Console.ReadKey();
        }

        /*
         * Функция, която прочита матрица от текстови файл,
         * На първия ред от файла са записани размерите на матрицата (брой редове и брой колони, разделени от символа tab)
         * На всеки следващ ред са записани три стойности, разделени отново със символа tab
         * Първата стойност е индекс на ред, втората - индекс на колана, а третата стойност е стойността на елемента, 
         * който са намира на съответните индекси за ред и колона. Всички останали елементи имат стойност 3
         * Функцията връща като резултат създадената матрица
         * Примерно съдържание на файла
            5	4
            1	3	7
            0	0	64
            4	3	8
         */

        static int[,] ReadMatrixFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new Exception("File does not exists");

            string[] lines = File.ReadAllLines(filePath);

            string[] matSizes = lines[0].Split(new char[] { '\t' },
                StringSplitOptions.RemoveEmptyEntries);
            int rowCount = int.Parse(matSizes[0]);
            int colCount = int.Parse(matSizes[1]);

            int[,] matrix = new int[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                    matrix[r, c] = 3;
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string[] lineParts = lines[i].Split(new char[] { '\t' },
                    StringSplitOptions.RemoveEmptyEntries);
                
                int row = int.Parse(lineParts[0]);
                int col = int.Parse(lineParts[1]);
                int val = int.Parse(lineParts[2]);

                matrix[row, col] = val;
            }

            return matrix;

        }

        /*
         * Функция, която прочита от файл едномерен масив от цели числа и го връща като резултат от
         * своето изпълнение. Файлът гарантирано се състои от един ред
         * Примерно съдържание на файла
            12 4 7 89 0 13 54
         */
        static int[] ReadArrayFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new Exception("File does not exists");

            string text = File.ReadAllText(filePath);
            string[] numbers = text.Split(new char[] {' '},
                StringSplitOptions.RemoveEmptyEntries);

            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinElementsWithFunc
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            Console.WriteLine("Enter numbers for matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int[] GetMinNumbers(int[,] matrix) 
        {
            int[] newArr = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min >= matrix[i, j])
                    {
                        min = matrix[i, j];
                        newArr[i] = matrix[i, j];
                    }
                }
            }

            return newArr;
        }

        static void PrintMinNumbers(int[] arr)
        {
            Console.WriteLine("Min numbers");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row number: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter column number: ");
            int col = int.Parse(Console.ReadLine());

            int[,] m = new int[rows, col];

            InputMatrix(m);
          
            int[] newArr = GetMinNumbers(m);

            PrintMinNumbers(newArr);
            Console.ReadKey();
        }
    }
}

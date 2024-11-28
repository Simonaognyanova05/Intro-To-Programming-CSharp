using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinElementsWithoutFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row number: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter column number: ");
            int col = int.Parse(Console.ReadLine());

            int[,] m = new int[rows, col];

            Console.WriteLine("Enter numbers for matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }


            int[] newArr = new int[m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                int min = m[i, 0];
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (min >= m[i, j])
                    {
                        min = m[i, j];
                        newArr[i] = m[i, j];
                    }
                }
            }

            Console.WriteLine("Min numbers");
            for (int i = 0; i < newArr.Length; i++)
            {

                Console.Write(newArr[i] + " ");
            }
            Console.ReadKey();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftingElementsOfArray
{
    internal class Program
    {
        static void ReverseArray(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            ReverseArray(array, start + 1, end - 1);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Въведете брой елементи на масива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            ReverseArray(array, 0, array.Length - 1);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}

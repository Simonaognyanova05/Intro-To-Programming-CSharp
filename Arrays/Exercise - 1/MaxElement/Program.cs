using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int max = arr[1];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i+1}: "); 
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++) 
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"The max element is: {max}");
        }
    }
}

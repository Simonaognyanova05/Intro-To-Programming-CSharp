using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            double sum = 0;
            for(int i  = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
                sum = (sum + arr[i]);
            }
            Console.WriteLine("The average of the elements in the array is: " + sum / arr.Length);

        }
    }
}

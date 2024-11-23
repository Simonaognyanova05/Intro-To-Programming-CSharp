using System.Diagnostics;

namespace AverageSum
{
    internal class Program
    {
        private static double[] ReadArray(double[] arr)
        {
            double[] arrayWithData = new double[arr.Length];

            for (int i = 0; i < arrayWithData.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arrayWithData[i] = double.Parse(Console.ReadLine()!);
            }

            return arrayWithData;
        }

        private static double AverageSum(double[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }

        static void Main(string[] args)
        {
            double[] A = new double[6];

            Console.WriteLine($"The average sum of the elements in the array is: {AverageSum(ReadArray(A)):f2}");
        }
    }
}

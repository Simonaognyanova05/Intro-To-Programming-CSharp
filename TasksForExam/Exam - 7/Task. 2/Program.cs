using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    internal class Program
    {
        static bool IsPrime(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static int[] InitPrimes(int N)
        {
            int[] primes = new int[N];
            int count = 0; 
            int number = 2;

            while (count < N)
            {
                if (IsPrime(number))
                {
                    primes[count] = number;
                    count++;
                }
                number++;
            }

            return primes;
        }

        static int[] RotateRight(int[] array)
        {
            if (array.Length <= 1) return null;

            int lastElement = array[array.Length - 1]; 

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement; 

            return array;
        }

        static int[] ReverseInPlace(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n / 2; i++)
            {
                int temp = array[i]; 
                array[i] = array[n - i - 1]; 
                array[n - i - 1] = temp; 
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведете стойност за N (N < 1000): ");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0 || N >= 1000)
            {
                Console.Write("Невалидна стойност. Опитайте отново: ");
            }

            int[] primes = InitPrimes(N);

            Console.WriteLine("Първите {0} прости числа са:", N);
            foreach (var prime in primes)
            {
                Console.Write(prime + " ");
            }

            Console.WriteLine("Преди завъртане " + string.Join(" ", primes));
            Console.WriteLine("След завъртане " + string.Join(" ", RotateRight(primes)));
            Console.WriteLine("След обръщане " + string.Join(" ", ReverseInPlace(primes)));


        }
    }
}

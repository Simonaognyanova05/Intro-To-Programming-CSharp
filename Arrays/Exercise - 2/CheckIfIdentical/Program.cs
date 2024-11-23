namespace ReverseOrder
{
    internal class Program
    {
        private static int[] ReadArray(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            return arr;
        }

        private static void EvenOddSubtraction(int[] arr)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            int difference = evenSum - oddSum;

            Console.WriteLine($"The difference between the even and odd sum is {difference}.");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] arr = new int[n];

            EvenOddSubtraction(ReadArray(arr));
        }
    }
}

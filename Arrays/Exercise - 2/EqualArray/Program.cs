namespace EqualArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of elements in the first array:");
            int firstArrayInput = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter the count of elements in the second array:");
            int secondArrayInput = int.Parse(Console.ReadLine()!);

            int[] firstArray = new int[firstArrayInput];
            int[] secondArray = new int[secondArrayInput];

            Console.WriteLine("Enter the elements in the first array:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Enter the elements in the second array:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine()!);
            }

            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Arrays are not identical. Found difference at length.");
                return;
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    return;
                }
            }

            int sum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += firstArray[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

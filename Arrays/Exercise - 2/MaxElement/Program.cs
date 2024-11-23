namespace MaxElement
{
    internal class Program
    {
        private static int[] InitializeArray(int[] arr)
        {
            int[] initArr = new int[arr.Length];

            for (int i = 0; i < initArr.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                initArr[i] = int.Parse(Console.ReadLine()!);
            }

            return initArr;
        }

        private static int FindMaxElement(int[] arr)
        {
            int maxElement = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }

            return maxElement;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] arr = new int[n];

            Console.WriteLine($"The max element is: {FindMaxElement(InitializeArray(arr))}");
        }
    }
}

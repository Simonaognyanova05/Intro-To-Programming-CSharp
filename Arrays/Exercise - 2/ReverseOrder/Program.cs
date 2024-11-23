namespace ReverseOrder
{
    internal class Program
    {
        private static int[] OrderByDescendingUsingBubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        private static int[] ReadArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] arr = new int[n];

            PrintArray(OrderByDescendingUsingBubbleSort(ReadArray(arr)));
        }
    }
}

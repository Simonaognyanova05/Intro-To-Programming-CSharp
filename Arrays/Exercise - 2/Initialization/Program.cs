namespace VprUpr8
{
    internal class Program
    {
        private static void PrintArray(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"A[{i}] = {arr[i]}");
            }
        }

        private static int[] InitializeArray(int[] arr)
        {
            int[] initArr = new int[arr.Length];

            for (int i = 0; i < initArr.Length; i++)
            {
                initArr[i] = i * i;
            }

            return initArr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            PrintArray(InitializeArray(arr));
        }
    }
}

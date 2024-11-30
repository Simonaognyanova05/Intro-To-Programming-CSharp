namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine()!);
            int[][] jaggedArr = new int[rows][];

            // read each row and split the input
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                string[] input = Console.ReadLine()!
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                jaggedArr[row] = new int[input.Length];

                // convert each element from string to integer
                for (int col = 0; col < input.Length; col++)
                {
                    jaggedArr[row][col] = int.Parse(input[col]);
                }
            }

            foreach (int[] row in jaggedArr)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    // print each element followed by a space
                    Console.Write(row[i]);

                    // print a space after every element except the last one
                    if (i < row.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
                // move to the next line after each row
                Console.WriteLine();
            }
        }
    }
}

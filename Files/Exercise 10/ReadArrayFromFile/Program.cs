namespace ReadArrayFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = Console.ReadLine()!;
            string outputFilePath = Console.ReadLine()!;

            int[][] matrix = ReadMatrixFromFile(inputFilePath, out int totalElements);

            int[] allElements = new int[totalElements];
            int index = 0;
            foreach (int[] row in matrix)
            {
                foreach (int element in row)
                {
                    allElements[index++] = element;
                }
            }

            BubbleSort(allElements);

            string[] sortedLines = { string.Join(" ", allElements) };

            File.WriteAllLines(outputFilePath, sortedLines);

            Console.WriteLine($"The sorted matrix has been written to '{outputFilePath}'");
        }

        private static int[][] ReadMatrixFromFile(string filePath, out int totalElements)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[][] matrix = new int[lines.Length][];
            totalElements = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int[] row = ParseNumbersFromLine(line);
                matrix[i] = row;
                totalElements += row.Length;
            }

            return matrix;
        }

        private static int[] ParseNumbersFromLine(string line)
        {
            int[] numbers = new int[line.Length];
            int numCount = 0;
            int currNum = 0;
            bool isBuildingNumber = false;

            foreach (char ch in line)
            {
                if (char.IsDigit(ch))
                {
                    currNum = currNum * 10 + (ch - '0');
                    isBuildingNumber = true;
                }
                else
                {
                    if (isBuildingNumber)
                    {
                        numbers[numCount++] = currNum;
                        currNum = 0;
                        isBuildingNumber = false;
                    }
                }
            }

            if (isBuildingNumber)
            {
                numbers[numCount++] = currNum;
            }

            int[] result = new int[numCount];
            Array.Copy(numbers, result, numCount);
            return result;
        }

        private static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
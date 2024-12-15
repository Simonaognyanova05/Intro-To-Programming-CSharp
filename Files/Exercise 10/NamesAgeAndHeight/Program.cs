namespace NamesAgeAndHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine()!;

            if (!File.Exists(filePath))
            {
                string content = Console.ReadLine()!;

                File.WriteAllText(filePath, content);

                Console.WriteLine($"Successfully written to {filePath} directory.");
            }
            else
            {
                Console.WriteLine($"File with the same name already exists in the {filePath} directory.");
            }
        }
    }
}

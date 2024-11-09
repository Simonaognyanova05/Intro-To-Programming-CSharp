Console.WriteLine("Enter the number n: ");
int n = int.Parse(Console.ReadLine()!);

int currentNumber = 1;
int row = 1;

while (currentNumber <= n)
{
    for (int i = 0; i < row; i++)
    {
        if (currentNumber > n)
        {
            break;
        }

        Console.Write(currentNumber + " ");
        currentNumber++;
    }

    Console.WriteLine();
    row++;
}
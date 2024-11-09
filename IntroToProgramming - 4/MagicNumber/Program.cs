int startingNumber = int.Parse(Console.ReadLine()!);
int finalNumber = int.Parse(Console.ReadLine()!);
int magicNumber = int.Parse(Console.ReadLine()!);
int combinations = 0;

bool isFound = false;

for (int i = startingNumber; i <= finalNumber; i++)
{
    for (int j = startingNumber; j <= finalNumber; j++)
    {
        combinations++;

        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N: {combinations} ({i} + {j} = {magicNumber})");
            isFound = true;
        }
    }

    if (isFound)
    {
        break;
    }
}

if (!isFound)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
}
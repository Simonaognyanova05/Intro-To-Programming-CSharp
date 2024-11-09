Console.Write("Enter the start of the interval: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the end of the interval: ");
int end = int.Parse(Console.ReadLine()!);
int sum = 0;

for (int i = start; i <= end; i++)
{
    sum += i;
    Console.Write($"{i} ");
}

Console.WriteLine($"\nSum: {sum}");
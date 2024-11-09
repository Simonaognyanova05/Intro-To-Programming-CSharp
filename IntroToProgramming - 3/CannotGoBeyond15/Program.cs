Console.WriteLine("Enter positive numbers to sum:");
int sum = 0;
int iterator = 0;

Console.WriteLine("Press 0 to exit the program.");
while (true)
{
    Console.Write($"Enter the {iterator + 1} number = ");
    int number = int.Parse(Console.ReadLine()!);

    if (number < 0)
    {
        Console.WriteLine("The number is negative, try again.");
        continue;
    }
    else if (number == 0)
    {
        Console.WriteLine($"The sum up to this point was {sum}.");
        break;
    }
    else
    {
        sum += number;
        iterator++;
    }

    if (sum > 15)
    {
        Console.WriteLine($"After adding the {iterator} number you got over 15.");
        Console.WriteLine($"The sum is over 15 and is equal to {sum}.");
        break;
    }
}
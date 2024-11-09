Console.WriteLine("Enter the hours:");
int hours = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the minutes:");
int minutes = int.Parse(Console.ReadLine()!);

minutes += 15;

if (minutes >= 60)
{
    hours += minutes / 60;
    minutes %= 60;
}

if (hours >= 24)
{
    hours %= 24;
}

Console.WriteLine($"{hours}:{minutes:d2}");
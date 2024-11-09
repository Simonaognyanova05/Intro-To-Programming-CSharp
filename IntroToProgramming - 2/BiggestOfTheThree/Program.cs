Console.WriteLine("Enter three numbers:");
int first = int.Parse(Console.ReadLine()!), second = int.Parse(Console.ReadLine()!), third = int.Parse(Console.ReadLine()!);
if (first > second)
{
    if (first > third)
    {
        Console.WriteLine($"{first} is the biggest.");
    }
    else
    {
        Console.WriteLine($"{third} is the biggest.");
    }
}
else
{
    if (second > third)
    {
        Console.WriteLine($"{second} is the biggest.");
    }
    else
    {
        Console.WriteLine($"{third} is the largest.");
    }
}
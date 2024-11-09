Console.WriteLine("Enter a negative number:");
int a = int.Parse(Console.ReadLine()!);

if (a < 0)
{
    a *= -1; // alternatively you can use the bitwise operator...
}
else
{
    Console.WriteLine("The number must be negative.");
}

Console.WriteLine($"The absolute value of the number is: {a}.");
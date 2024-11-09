Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine()!);

if (a == 100 || b == 100)
{
	if (b == 200 || a == 200)
	{
        Console.WriteLine($"The sum of {a} and {b} is: {a + b}.");
	}
}

Console.WriteLine($"Exact value of a is: {a}.");
Console.WriteLine($"Exact value of b is: {b}.");
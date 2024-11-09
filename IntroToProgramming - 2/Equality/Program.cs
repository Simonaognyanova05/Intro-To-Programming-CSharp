Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine()!);

if (a == b)
{
    Console.WriteLine($"{a} and {b} are equal.");
}
else
{
    Console.WriteLine($"{a} and {b} are not equal.");
}
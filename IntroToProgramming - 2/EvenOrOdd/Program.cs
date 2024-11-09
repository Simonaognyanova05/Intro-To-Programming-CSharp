Console.WriteLine("Enter a number:");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
    Console.WriteLine($"{a} is an even number.");
}
else
{
    Console.WriteLine($"{a} is an odd number");
}
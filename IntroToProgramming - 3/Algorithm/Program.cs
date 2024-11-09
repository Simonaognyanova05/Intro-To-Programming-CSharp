Console.Write("Enter value for b = ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Enter value for k = ");
int k = int.Parse(Console.ReadLine()!);

int x = 0;
int step = 3;

while (true)
{
    int y = b * x + k;

    if (y > 10)
    {
        break;
    }

    Console.WriteLine($"x = {x}, y = {y}");
    x += step;
}
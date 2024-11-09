Console.WriteLine("How many numbers do you want to enter:");
int n = int.Parse(Console.ReadLine()!);

int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the number {i + 1}");
    int number = int.Parse(Console.ReadLine()!);

    switch (number)
    {
        case < 200:
            countP1++;
            break;
        case < 400:
            countP2++;
            break;
        case < 600:
            countP3++;
            break;
        case < 800:
            countP4++;
            break;
        default:
            countP5++;
            break;
    }
}

double p1 = (double)countP1 / n * 100;
double p2 = (double)countP2 / n * 100;
double p3 = (double)countP3 / n * 100;
double p4 = (double)countP4 / n * 100;
double p5 = (double)countP5 / n * 100;

Console.WriteLine($"{p1:F2}%");
Console.WriteLine($"{p2:F2}%");
Console.WriteLine($"{p3:F2}%");
Console.WriteLine($"{p4:F2}%");
Console.WriteLine($"{p5:F2}%");
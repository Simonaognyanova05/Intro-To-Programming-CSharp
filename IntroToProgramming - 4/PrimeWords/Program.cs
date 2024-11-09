Console.Write("Enter a positive integer: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    bool isPrime = true;
    int divisorCount = 0;
    int sqrt = (int)Math.Sqrt(i);
    bool isSquareOfPrime = false;

    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            divisorCount++;
            if (divisorCount > 3)
            {
                break;
            }
        }
    }

    if (i > 1)
    {
        for (int k = 2; k <= sqrt; k++)
        {
            if (i % k == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
    else
    {
        isPrime = false;
    }

    if (sqrt * sqrt == i)
    {
        isSquareOfPrime = true;
        for (int m = 2; m <= Math.Sqrt(sqrt); m++)
        {
            if (sqrt % m == 0)
            {
                isSquareOfPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        Console.WriteLine("Prime");
    }
    else if (isSquareOfPrime)
    {
        Console.WriteLine("SquarePrime");
    }
    else if (divisorCount == 3)
    {
        Console.WriteLine("Trio");
    }
    else
    {
        Console.WriteLine(i);
    }
}
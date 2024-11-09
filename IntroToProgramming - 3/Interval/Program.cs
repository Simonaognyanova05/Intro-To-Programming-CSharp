Console.WriteLine("Enter the end of the interval:");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;

int originalNumber = n;

while (n > 0)
{
	if (n % 2 == 0)
	{
        sum += n;
        n--;
    }
    else
    {
        n--;
        continue;
    }
}

Console.WriteLine($"The sum of the even numbers in the interval from 0 to {originalNumber} is {sum}.");
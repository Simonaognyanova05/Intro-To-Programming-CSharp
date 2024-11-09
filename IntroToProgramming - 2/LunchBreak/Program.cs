Console.WriteLine("Enter the series that you want to watch:");
string seriesName = Console.ReadLine()!;
Console.WriteLine("Enter the episode's duration:");
int episodeDuration = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the break's duration:");
int breakDuration = int.Parse(Console.ReadLine()!);

double lunchTime = breakDuration / 8.0;
double relaxTime = breakDuration / 4.0;

double remainingTime = breakDuration - lunchTime - relaxTime;

if (remainingTime >= episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime - episodeDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration - remainingTime)} more minutes.");
}
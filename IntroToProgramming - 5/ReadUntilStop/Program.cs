string input;
bool shouldPrint = true;

while (true)
{
    input = Console.ReadLine()!;

    if (input == "Stop")
    {
        shouldPrint = false;
    }

    if (shouldPrint)
    {
        Console.WriteLine($"The output is: {input}.");
    }
}
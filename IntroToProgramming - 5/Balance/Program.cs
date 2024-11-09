double totalAmount = 0.0;
string input;

while ((input = Console.ReadLine()!) != "NoMoreMoney")
{
    if (double.TryParse(input, out double amount))
    {
        if (amount < 0)
        {
            Console.WriteLine("Invalid operation!");
            break;
        }

        totalAmount += amount;
        Console.WriteLine($"Increase: {amount:F2}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

Console.WriteLine($"Total: {totalAmount:F2}");
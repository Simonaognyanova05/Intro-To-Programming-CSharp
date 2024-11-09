decimal exchangeRate = 1.79549m;

Console.WriteLine("Enter sum in USD:");
decimal usdAmount = decimal.Parse(Console.ReadLine()!);

decimal bgnAmount = usdAmount * exchangeRate;

Console.WriteLine($"The sum in BGN is: {bgnAmount}");
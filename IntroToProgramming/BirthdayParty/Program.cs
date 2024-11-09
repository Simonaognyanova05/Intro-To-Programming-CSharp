Console.WriteLine("Enter the hall rent:");
decimal hallRent = decimal.Parse(Console.ReadLine()!);

decimal cakePrice = 0.2m * hallRent;
decimal drinksPrice = 0.55m * cakePrice;
decimal animatorPrice = hallRent / 3;

decimal totalBudget = hallRent + cakePrice + drinksPrice + animatorPrice;

Console.WriteLine($"The total budget for the party is: {totalBudget:f2} BGN.");
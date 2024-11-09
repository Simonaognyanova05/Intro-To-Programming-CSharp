Console.WriteLine("Enter the amount deposited:");
decimal depositAmount = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the deposit period (in months):");
int depositPeriod = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the annual interest rate:");
decimal annualInterestRate = decimal.Parse(Console.ReadLine()!);

decimal finalAmount = depositAmount + depositPeriod * ((depositAmount * (annualInterestRate / 100)) / 12);

Console.WriteLine($"The final amount at the end of the deposit: {finalAmount:f2}.");
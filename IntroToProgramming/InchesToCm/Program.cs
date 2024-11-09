double conversionFactor = 2.54;

Console.WriteLine("Enter a value in inches:");
double inches = double.Parse(Console.ReadLine()!);

double centimeters = inches * conversionFactor;

Console.WriteLine($"The value in centimeters is: {centimeters}.");
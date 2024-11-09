Console.WriteLine("Enter the number of pages in the book:");
int pagesCount = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the number of pages, which the child can read in an hour:");
double pagesPerHour = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the number of days, that are needed to read the whole book:");
int days = int.Parse(Console.ReadLine()!);

double totalHours = pagesCount / pagesPerHour;
double hoursPerDay = totalHours / days;

Console.WriteLine($"The child must read {hoursPerDay:f2} hours per day.");
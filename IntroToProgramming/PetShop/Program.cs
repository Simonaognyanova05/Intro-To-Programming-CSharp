Console.WriteLine("Enter the number of dogs:");
int dogCount = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the count of the other animals:");
int otherAnimalsCount = int.Parse(Console.ReadLine()!);

decimal dogFoodPrice = 2.5m;
decimal otherAnimalFoodPrice = 4.0m;

decimal finalPrice = (dogCount * dogFoodPrice) + (otherAnimalsCount * otherAnimalFoodPrice);

Console.WriteLine($"{finalPrice} lv.");
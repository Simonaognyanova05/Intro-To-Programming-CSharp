Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine()!);

if (age < 0)
{
    Console.WriteLine("Not born yet!");
}
else if (age >= 0 && age <= 2)
{
    Console.WriteLine("Baby");
}
else if (age >= 3 && age <= 13)
{
    Console.WriteLine("Child");
}
else if (age >= 14 && age <= 19)
{
    Console.WriteLine("Teenager");
}
else if (age >= 20 && age <= 65)
{
    Console.WriteLine("Adult");
}
else if (age >= 66)
{
    Console.WriteLine("Elder");
}
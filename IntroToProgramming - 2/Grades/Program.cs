Console.WriteLine("Enter your grade:");
double grade = double.Parse(Console.ReadLine()!);

if (grade < 2.0 || grade > 6.0)
{
    Console.WriteLine("Grades like these don't exist!");
}
else if (grade >= 2.0 && grade <= 2.99)
{
    Console.WriteLine("Failed! Try harder next time!");
}
else if (grade >= 3.0 && grade <= 3.49)
{
    Console.WriteLine("Average. You could do better!");
}
else if (grade >= 3.5 && grade <= 4.49)
{
    Console.WriteLine("Good.");
}
else if (grade >= 4.5 && grade <= 5.49)
{
    Console.WriteLine("Very good! This is a great grade!");
}
else if (grade >= 5.5 && grade <= 6.0)
{
    Console.WriteLine("Excellent! This is an amazing grade!");
}
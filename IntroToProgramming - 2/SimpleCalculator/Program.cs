Console.WriteLine("Enter the first number:");
double firstNumber = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the second number:");
double secondNumber = double.Parse(Console.ReadLine()!);

Console.WriteLine("Here are the options:\n"
                  + "1 - Addition\n"
                  + "2 - Subtraction\n"
                  + "3 - Multiplication\n"
                  + "4 - Division\n"
                  + "5 - Exit");

Console.Write("Enter your choice: ");
int choice = int.Parse(Console.ReadLine()!);

switch (choice)
{
    case 1:
        Console.WriteLine($"The addition of {firstNumber} and {secondNumber} is: {firstNumber + secondNumber}.");
        break;
    case 2:
        Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is: {firstNumber - secondNumber}.");
        break;
    case 3:
        Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is: {firstNumber * secondNumber}.");
        break;
    case 4:
        Console.WriteLine($"The division of {firstNumber} and {secondNumber} is: {firstNumber / secondNumber}.");
        break;
    default:
        Console.WriteLine("Thank you, for using the calculator.");
        break;
}
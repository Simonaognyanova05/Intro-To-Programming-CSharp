Console.Write("Enter your username: ");
string username = Console.ReadLine()!;
Console.Write("Enter your password: ");
string password = Console.ReadLine()!;
string input;
int attempts = 5;

while (true)
{
    Console.Write("Use your password to login: ");
    input = Console.ReadLine()!;
    attempts--;

    if (input == password)
    {
        Console.WriteLine($"Welcome, {username}!");
        break;
    }
    else if (attempts > 0)
    {
        Console.WriteLine($"Wrong password, try again!\nYou have {attempts} attempts left.");
        continue;
    }
    else
    {
        Console.WriteLine("Access denied!");
        break;
    }
}
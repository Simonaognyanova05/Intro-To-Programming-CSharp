for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write("W ");
        }
        else
        {
            Console.Write("B ");
        }
    }
    Console.WriteLine();
}
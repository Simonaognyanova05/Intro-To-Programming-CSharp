using System;

class Program
{
    private enum OrderStatus
    {
        Processing = 0,
        Shipped = 1,
        Delivered = 2,
        Cancelled = 3
    }

    private static string GetOrderStatusMessage(OrderStatus status)
    {
        switch (status)
        {
            case OrderStatus.Processing:
                return "Your order is being processed.";
            case OrderStatus.Shipped:
                return "Your order is being shipped.";
            case OrderStatus.Delivered:
                return "Your order is delivered.";
            case OrderStatus.Cancelled:
                return "Your order has been canceled.";
            default:
                return "Invalid status.";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Choose a status for your order:");
        Console.WriteLine("0 - Processing");
        Console.WriteLine("1 - Shipped");
        Console.WriteLine("2 - Delivered");
        Console.WriteLine("3 - Cancelled");
        Console.Write("Your choice: ");

        string input = Console.ReadLine()!;

        int statusValue = int.Parse(input);

        if (statusValue >= 0 && statusValue <= 3)
        {
            OrderStatus status = (OrderStatus)statusValue;

            Console.WriteLine(GetOrderStatusMessage(status));
        }
        else
        {
            Console.WriteLine("Invalid status.");
        }
    }
}

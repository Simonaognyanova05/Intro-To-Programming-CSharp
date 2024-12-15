namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            Vehicle[] vehicles = new Vehicle[size];

            for (int i = 0; i < size; i++)
            {
                vehicles[i] = new Vehicle();
                Console.WriteLine($"Enter details for vehicle {i + 1}:");
                vehicles[i].Type = Console.ReadLine()!;
                vehicles[i].Model = Console.ReadLine()!;
                vehicles[i].Colour = Console.ReadLine()!;
                vehicles[i].HorsePower = double.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("\nVehicle Catalogue:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Type: {vehicles[i].Type}\nModel: {vehicles[i].Model}\nColour: {vehicles[i].Colour}\nHorsepower: {vehicles[i].HorsePower}");
            }

            Console.WriteLine($"The average horsepower of all vehicles is {CalculateAvgHorsePower(vehicles)}");
        }

        private static double CalculateAvgHorsePower(Vehicle[] vehicles)
        {
            double horsepowerSum = 0;

            foreach (var item in vehicles)
            {
                horsepowerSum += item.HorsePower;
            }

            return horsepowerSum / vehicles.Length;
        }
    }
}

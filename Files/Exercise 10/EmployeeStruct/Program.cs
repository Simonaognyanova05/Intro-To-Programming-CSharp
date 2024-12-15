namespace EmployeeStruct
{
    public struct Employee
    {
        public int Id;

        public void GetId(int id)
        {
            Console.WriteLine($"Employee Id: {id}.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.Id = int.Parse(Console.ReadLine()!);

            emp.GetId(emp.Id);
        }
    }
}

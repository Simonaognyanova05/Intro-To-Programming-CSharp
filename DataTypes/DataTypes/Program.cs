using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    [Flags]
    enum UserWrights
    {
        CanRead = 1,
        CanWrite = 2,
        CanDelete = 4,
        CanUpdate = 8,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            UserWrights user1 = UserWrights.CanRead;
            UserWrights user2 = UserWrights.CanWrite | UserWrights.CanRead;

            Console.WriteLine(user1);
            Console.WriteLine(user2);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
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
            UserWrights user2 = UserWrights.CanDelete | UserWrights.CanRead;

            if ((user2 & UserWrights.CanWrite) == UserWrights.CanWrite)
            {
                Console.WriteLine("He can");
            }
            else
            {
                Console.WriteLine("He can't");
            }

            Console.ReadKey();
        }
    }
}

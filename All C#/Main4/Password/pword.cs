using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class pword
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(),
                password = Console.ReadLine(),
                input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine("Welcome " + username + "!");
        }
    }
}

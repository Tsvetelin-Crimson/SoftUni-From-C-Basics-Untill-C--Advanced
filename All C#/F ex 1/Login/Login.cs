using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(),  //needs a fix
                correctPword = "";
            

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPword += username[i];
            }

            for (int i = 0; i < 4; i++)
            {
                string password = Console.ReadLine();

                if (password == correctPword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (i <= 2)
                {
                   Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                       Console.WriteLine($"User {username} blocked!");
                }
            }

            


        }
    }
}

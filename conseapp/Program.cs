using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conseapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Please provide a username and password.");
                }
                else if (username == "admin1256" && password == "admin@1256@1256")
                {
                    Console.WriteLine("Sign-in success.");
                }
                else
                {
                    Console.WriteLine("Invalid user.");
                }

                Console.ReadLine();
            }
        }
    }
}

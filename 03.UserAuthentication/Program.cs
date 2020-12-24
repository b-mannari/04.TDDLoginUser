using System;
using UserAuthentication.ClassObjects;

namespace UserAuthenticationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            //Display user with options to choose
            Console.Clear();
            Console.WriteLine("1. Create User:");
            Console.WriteLine("2. Login User:");
            Console.WriteLine("Please enter your choice");
            string opt = Console.ReadLine();

            //Display user with options to choose
            Console.Clear();
            Console.WriteLine("Please enter your Username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string password = Console.ReadLine();

            if (Convert.ToInt32(opt) < 1 && Convert.ToInt32(opt) > 2)
            {
                Console.WriteLine("Please choose numbers between 1 and 2"); goto Start;
            }

            string message;
            if (Convert.ToInt32(opt) == 1)
            {
                CreateUser createUser = new CreateUser();
                message = createUser.CreateNewUser(username, password);
            }
            else
            {
                LoginUser loginUser = new LoginUser();
                message = loginUser.Login(username, password);
            }
            Console.WriteLine(message);
        }
    }
}

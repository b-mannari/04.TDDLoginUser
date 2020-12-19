using System;
using UserAuthentication;

namespace UserAuthenticationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateInputs validate = new ValidateInputs();

            //Display user with options to choose
            Console.Clear();
            Console.WriteLine("Please enter your Username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string password = Console.ReadLine();

            //string message = validate.CreateUser(username, password);
            string message = validate.Login(username, password);

            Console.WriteLine(message);
        }
    }
}

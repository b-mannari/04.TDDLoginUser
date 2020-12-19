using System;

namespace UserAuthenticationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();

            //Display user with options to choose
            Console.Clear();
            Console.WriteLine("Please enter your Username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string password = Console.ReadLine();

            //string message = validate.CreateUserName(username, password);
            string message = validate.LoginUserName(username, password);
            Console.WriteLine(message);
        }
    }
}

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace UserAuthentication
{
    public class ValidateInputs
    {
        public bool ValidateUserName(string userName)
        {
            if (Regex.Match(userName, "^[a-zA-Z]*$").Success)
            {
                return true;
            }
            return false;
        }

        public string CreateUser(string username, string password)
        {
            bool validUserName = ValidateUserName(username);
            if (validUserName)
            {
                return "User created Successfully";
            }
            else
            {
                return "Unable to create user";
            }
        }

        public string Login(string username, string password)
        {
            string message = "";
            try
            {
                string inputUsername = "username"; string inputPassword = "password";
                if (inputUsername == username && inputPassword == password)
                {
                    message = "Login Success";
                }
                else
                {
                    message = "Login failure";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return message;
        }
    }
}
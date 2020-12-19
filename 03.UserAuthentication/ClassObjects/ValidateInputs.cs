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

        public string CreateUserName(string username, string password)
        {
            bool validUserName = ValidateUserName(username);
            if (validUserName)
            {
                return "User created";
            }
            else
            {
                return "User not created";
            }
        }

    }
}
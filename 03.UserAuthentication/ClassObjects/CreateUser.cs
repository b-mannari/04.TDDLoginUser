using System;
using System.Text.RegularExpressions;

namespace UserAuthentication.ClassObjects
{
    public class CreateUser
    {
        public bool ValidateUserName(string userName)
        {
            if (Regex.Match(userName, @"^[a-zA-Z]*$").Success)
            {
                return true;
            }
            return false;
        }

        public bool ValidatePassword(string password)
        {
            if (Regex.Match(password, @"^.*(?=.{6,6})(?=.*\d)(?=.*[a-zA-Z]).*$").Success)
            {
                return true;
            }
            return false;
        }

        public string AddNewUser(string username, string password, UserAccount userAccount)
        {
            bool validUserName = ValidateUserName(username);

            bool validPassword = ValidatePassword(password);

            if (validUserName && validPassword)
            {
                if (userAccount.GetUserInfo.ContainsKey(username))
                {
                    Console.WriteLine("This username is already exists.");
                }
                else
                {
                    userAccount.AddUserInfo();
                }
                return "User created Successfully";
            }
            else
            {
                return "Unable to create user";
            }
        }
    }
}

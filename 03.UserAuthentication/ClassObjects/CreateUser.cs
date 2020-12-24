using System;
using System.Collections;
using System.Collections.Generic;
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
            //Sprint1
            bool validUserName = ValidateUserName(username);

            //Sprint 3
            bool validPassword = ValidatePassword(password);

            //Sprint1
            //if (validUserName)

            //Sprint3
            if (validUserName && validPassword)
            {
                if (userAccount.GetUserInfo.ContainsKey(username))
                {
                    Console.WriteLine("This username is already exists.");
                }
                else
                {
                    //dic.Add(username, password);
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

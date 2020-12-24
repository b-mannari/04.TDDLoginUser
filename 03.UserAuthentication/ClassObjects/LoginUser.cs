using System;
using System.Collections;
using System.Collections.Generic;

namespace UserAuthentication.ClassObjects
{
    public class LoginUser
    {
        public string Login(string username, string password, UserAccount userAccount)
        {
            //string dbUserName = "username"; string dbPassword = "password"; //HashMapping 
            string message = "";
            try
            {
                if (userAccount.GetUserInfo.ContainsKey(username) && userAccount.GetUserInfo.ContainsValue(password))
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
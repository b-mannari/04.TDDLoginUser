using System;
using System.Text.RegularExpressions;

namespace UserAuthentication.ClassObjects
{
    public class LoginUser
    {
        CreateUser CreateUser;
        public LoginUser(CreateUser createUser)
        {
            this.CreateUser = createUser;
        }

        public string Login(string username, string password)
        {
            if (CreateUser.GetUser.ContainsKey(username))

            {
                if ((String)CreateUser.GetUser[username] == password)
                {
                    return "User Logged In Successfully";
                }
                else
                {
                    return "Login failed.Invalid password";
                }
            }
            else
            {
                return "Login failed.Invalid username";
            }
        }

    }
}
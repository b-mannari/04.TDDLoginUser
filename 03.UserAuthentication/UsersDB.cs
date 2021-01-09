using System.Collections.Generic;

namespace UserAuthentication
{
    public class UserDB
    {
        private Dictionary<string, string> dic = new Dictionary<string, string>();

        public string Username { get; set; }

        public string Password { get; set; }

        public Dictionary<string, string> GetUser
        {
            get { return dic; }
            set { dic = value; }
        }

        public string AddUser(string username, string password)
        {
            dic.Add(username, password);
            return "User added successfully";
        }
    }
}

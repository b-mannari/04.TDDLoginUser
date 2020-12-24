using System.Collections.Generic;

namespace UserAuthentication
{
    public class UserAccount
    {
        private Dictionary<string, string> dic = new Dictionary<string, string>();

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Dictionary<string, string> GetUserInfo
        {
            get { return dic; }
            set { dic = value; }
        }

        public string AddUserInfo()
        {
            dic.Add(username, password);
            return dic.ToString();
        }
    }
}

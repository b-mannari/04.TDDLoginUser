using System.Collections.Generic;
using System.IO;

namespace UserAuthentication
{
    public class ValidateInputs
    {
        public void TextFileToDictionary()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            using (var sr = new StreamReader(@"C:\TFS\GitHub\user.txt"))
            {
                string line = null;

                // while it reads a key
                while ((line = sr.ReadLine()) != null)
                {
                    // add the key and whatever it can read next as the value
                    dic.Add(line, sr.ReadLine());
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace UserAuthenticationConsole
{
    class Validation
    {
        //Method to check if the selected option is valid
        public static bool IsValidOption(string opt)
        {
            //Check if the input option value is not empty
            if (string.IsNullOrEmpty(opt) || Convert.ToInt32(opt) < 0 || Convert.ToInt32(opt) > 3)
            {
                return false;
            }
            return true;
        }
    }
}

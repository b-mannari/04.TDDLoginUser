using System;
using System.Collections.Generic;
using System.Text;

namespace UserAuthenticationConsole
{
    class ConsoleInputs
    {
        private string _optionType;
        public string OptionType
        {
            get { return _optionType; }
            set { _optionType = value; }
        }

        public void StartOperation()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("0. Clear:");
                Console.WriteLine("1. Create User:");
                Console.WriteLine("2. Login User:");
                Console.WriteLine("3. Exit:");
                Console.WriteLine("Please enter your choice");
                this.OptionType = System.Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}

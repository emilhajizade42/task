using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modles
{
    class User : IAccount
    {
        public string fullName;
        public string email;
        public string password;

      
        public void ShowInfo()
        {
            Console.WriteLine($"{fullName} and {email}");
        }

        public bool PasswordChecker(string pass)
        {
            int length = pass.Length;
            bool stringLength = length > 8;
            bool bigLetter = false;
            bool smallLetter = false;
            bool number = false;
            foreach (var item in pass)
            {
                if (char.IsDigit(item))
                {
                    number = true;
                }
                if (char.IsUpper(item))
                {
                    bigLetter = true;
                }
                if (char.IsLower(item))
                {
                    smallLetter = true;
                }
            }

            if (bigLetter & smallLetter &number  & stringLength)
            {
                return true;
            }
            return false;
        }

        public User(string fullName, string email, string password)
        {
            this.fullName = fullName;
            this.email = email;
            this.password = password;
        }
    }
}

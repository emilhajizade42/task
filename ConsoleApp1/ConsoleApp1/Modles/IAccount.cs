using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modles
{
    interface IAccount
    {

        public bool PasswordChecker(string pass);
      
        public void ShowInfo();
        
    }
}

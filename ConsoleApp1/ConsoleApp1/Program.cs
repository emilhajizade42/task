using System;

namespace ConsoleApp1.Modles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var user12 = new User("emil hajizade ", " sdkasj@mail.ru", "aA12sdadfasdfs");
            user12.ShowInfo();
            var z =user12.PasswordChecker(user12.password);
            Console.WriteLine(z);
            //var  b = user12.PasswordChecker("sas1Aaaaaa");
            //Console.WriteLine(b);
        }
    }
}

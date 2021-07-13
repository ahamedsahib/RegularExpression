using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            UserRegistration user = new UserRegistration();
            //user.NameCheck();
            //user.EmailCheck();
            //user.PhoneNumber();
            user.Password();
        }
    }
}
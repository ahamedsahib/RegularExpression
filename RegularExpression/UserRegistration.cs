using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class UserRegistration
    {
         
        public void UserInputs()
        {
            string NamePattern = "^[A-Z]{1}[a-z]{2,}";
            Console.WriteLine("Enter First Name ");
            string Firstname = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(Firstname, NamePattern)?$"{Firstname}is Valid":$"{Firstname}Invalid!! Name Start with Capital and must contain atleast 3 characters!");
            
        }
         
    }
}

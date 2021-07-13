using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class UserRegistration
    {
         
        public void NameCheck()
        {
            string NamePattern = "^[A-Z]{1}[a-z]{2,}$";
            Console.WriteLine("Enter First Name ");
            string Firstname = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(Firstname, NamePattern)?$"{Firstname} is Valid":$"{Firstname} Invalid!! Name Start with Capital and must contain atleast 3 characters!");
            Console.WriteLine("Enter Last Name ");
            string Lastname = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(Lastname, NamePattern) ? $"{Lastname} is Valid" : $"{Lastname} Invalid!! Name Start with Capital and must contain atleast 3 characters!");

        }
        public void EmailCheck()
        {
            string emailPattern = @"^abc([+.-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2})?$";
            Console.WriteLine("Enter your Email ID");
            String email = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(email, emailPattern) ? $"{email} is Valid" : $"{email} Invalid!!");
        }
        public void PhoneNumber()
        {
            string phoneNumberPattern = "[0-9]{1,2}[ ][0-9]{10}$";
            Console.WriteLine("Enter your phone Number");
            string phoneNo = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(phoneNo, phoneNumberPattern) ? $"{phoneNo} is Valid" : $"{phoneNo} Invalid!! must conuntry code and 10 digit phone Number");
        }
        public void Password()
        {
            while (true)
            {
                string passwordPattern = "^(?=.{8,}$)(?=.*[A-Z]).*$";
                Console.WriteLine("Enter your Password");
                string password = Console.ReadLine();
                Console.WriteLine(Regex.IsMatch(password, passwordPattern) ? $"{password} is Valid" : $"{password} Invalid!!");
            }
        }
    }
}

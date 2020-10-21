using System;
using System.Text.RegularExpressions;

namespace CampbellLab7_RegEx_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ValidName(string _name)
            {
                Regex namePattern = new Regex(@"^[A-Z]{1}\w{1,29}$");
                if (namePattern.IsMatch(_name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            bool ValidEmail(string _email)
            {
                Regex emailPattern = new Regex(@"^([A-z]|[0-9]){5,30}@([A-z]|[0-9]){5,10}\.([A-z]|[0-9]){2,3}$");
                if (emailPattern.IsMatch(_email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool ValidPhone(string _phoneNumber)
            {
                Regex phonePattern = new Regex(@"^\d{3}-\d{3}-\d{4}$");
                if (phonePattern.IsMatch(_phoneNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool ValidDate(string _date)
            {
                Regex datePattern = new Regex(@"^([0-9]{2})/([0-9]{2})/([0-9]{4})$");
                if (datePattern.IsMatch(_date))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool ValidHTML(string _htmlTag)
            {
                Regex htmlTagPattern = new Regex(@"^<[a-z]+>.+?<\/[a-z]+>$");
                if (htmlTagPattern.IsMatch(_htmlTag))
                {
                    return true;
                }
                else return false;
            }

            Console.WriteLine("Enter a valid name!   (Starts w/ capital 5-30 letters)");
            string nameInput = Console.ReadLine();
            bool nameIsValid = ValidName(nameInput);

            if (nameIsValid)
            {
                Console.WriteLine("Great Job, your name is valid!");
            }
            else
            {
                Console.WriteLine("Invalid name, sorry!");
            }

            Console.WriteLine("Enter a valid email!   (xxxxx@xxxx.xx)");
            string emailInput = Console.ReadLine();
            bool emailIsValid = ValidEmail(emailInput);

            if (emailIsValid)
            {
                Console.WriteLine("Great Job, your email is valid!");
            }
            else
            {
                Console.WriteLine("Invalid email, sorry!");
            }

            Console.WriteLine("Enter a valid phone number! (xxx-xx-xxxx)" );
            string phoneNumberInput = Console.ReadLine();
            bool phoneNumberIsValid = ValidPhone(phoneNumberInput);

            if (phoneNumberIsValid)
            {
                Console.WriteLine("Great Job, your phoneNumber is valid!");
            }
            else
            {
                Console.WriteLine("Invalid phoneNumber, sorry!");
            }

            Console.WriteLine("Enter a valid date! (dd/mm/yyyy)");
            string dateInput = Console.ReadLine();
            bool dateIsValid = ValidDate(dateInput);

            if (dateIsValid)
            {
                Console.WriteLine("Great Job, your date is valid!");
            }
            else
            {
                Console.WriteLine("Invalid date, sorry!");
            }

            Console.WriteLine("Bonus!! Give me your best HTML!");
            string htmlInput = Console.ReadLine();
            bool htmlIsValid = ValidHTML(htmlInput);

            if (htmlIsValid)
            {
                Console.WriteLine("Great Job, your html tag is valid!");
            }
            else
            {
                Console.WriteLine("Invalid html, stick to backend! ;)");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yout email address in the following format: firstName.lastName@exam.com");
            string email = Console.ReadLine();
            string Name = NameFromEmail1(email);
            Console.WriteLine(Name);
        }
    }

        public static string NameFromEmail1(string email)
        {
        string[] parts = email.Split('.', '@');
        string firstname = "";
        string lastname = "";
        parts[0] = firstname;
        parts[1] = lastname;
        string Name = firstname + lastname;
        return Name;

        }
}

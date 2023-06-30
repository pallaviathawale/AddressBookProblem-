using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Contact
    {
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public static AddressBook AddContact()
        {
            AddressBook contact = new AddressBook();
            Console.WriteLine("Enter First name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            contact.ZipCode = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address");
            contact.Email = Console.ReadLine();
            return contact;

        }
        
        
    }
}


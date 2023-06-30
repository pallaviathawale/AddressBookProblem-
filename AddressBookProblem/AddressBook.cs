using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        public void CreateContact()
        {
            Contact contacts = new Contact();

            Console.WriteLine("Enter First Name : ");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            contacts.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            contacts.PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            contacts.ZipCode = Console.ReadLine();
            Console.WriteLine("Contact created successfully......");
        }
    }
}

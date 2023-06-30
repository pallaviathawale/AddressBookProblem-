using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{

    public class AddressBook
    {
        List<Contact> addressBookList = new List<Contact>();

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
        public void AddContact()
        {
            Contact addContact = new Contact();
            Console.WriteLine("Enter First Name : ");
            addContact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            addContact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            addContact.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            addContact.PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            addContact.Address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            addContact.State = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            addContact.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            addContact.ZipCode = Console.ReadLine();
            addressBookList.Add(addContact);
            Console.WriteLine("Contact Added Successfully!");
        }
        public void EditContact(string firstName)
        {

            Contact contactToEdit = addressBookList.Find(contact => contact.FirstName == firstName);

            if (contactToEdit == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.WriteLine("Enter new contact information:");

            Console.Write("First Name: ");
            string newFirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string newLastName = Console.ReadLine();

            Console.Write("Address: ");
            string newAddress = Console.ReadLine();

            Console.Write("City: ");
            string newCity = Console.ReadLine();

            Console.Write("State: ");
            string newState = Console.ReadLine();

            Console.Write("Zip: ");
            string newZip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string newPhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            string newEmail = Console.ReadLine();

            contactToEdit.FirstName = newFirstName;
            contactToEdit.LastName = newLastName;
            contactToEdit.Address = newAddress;
            contactToEdit.City = newCity;
            contactToEdit.State = newState;
            contactToEdit.ZipCode = newZip;
            contactToEdit.PhoneNo = newPhoneNumber;
            contactToEdit.Email = newEmail;

            Console.WriteLine("Contact updated.");
        }

        public void DisplayContact()
        {
            Console.WriteLine("Contact Details");
            foreach (Contact display in addressBookList)
            {
                Console.WriteLine(display.FirstName);
                Console.WriteLine(display.LastName);
                Console.WriteLine(display.Email);
                Console.WriteLine(display.PhoneNo);
                Console.WriteLine(display.Address);
                Console.WriteLine(display.State);
                Console.WriteLine(display.City);
                Console.WriteLine(display.ZipCode);
            }

        }
    }
}

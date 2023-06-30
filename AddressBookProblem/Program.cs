namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            
                    AddressBook addressBook = new AddressBook();
                    addressBook = Contact.AddContact();
            
        }
    }
}
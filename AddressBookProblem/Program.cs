namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
           AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Add Multiple Person\n5.Edit Contact \n6.Delete Contact \n7.Add Multiple Person \n7.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;
                    case 2:
                        addressBook.AddContact();
                        break;
                    case 3:
                        addressBook.DisplayContact();
                        break;

                    case 4:
                        addressBook.AddMultipleContact();
                        break;
                    case 5:
                       
                       addressBook.EditContact();
                        break;
                    case 6:
                        addressBook.DeleteContact();
                        break;
                    case 7 :
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
    
}
namespace PhoneBookApp
{
    class Program
    {
        public static void ShowContactInfo(Contact contact)
        {
            Console.WriteLine($"{contact.Name}: {contact.Number}");
        }
        public static void NewContactInput(PhoneBook phoneBook)
        {
            Console.WriteLine("Add new contact in format: <name>:<number>");
            string userInput = Console.ReadLine();
            phoneBook.AddNewContact(userInput);
        }

        public static void PrintContactInfo(SearchContactBy keyName, PhoneBook phoneBook)
        {
            Console.WriteLine($"Pass contact {keyName}");
            string userInput = Console.ReadLine();
            Contact? selectedContact = phoneBook.GetContact(keyName, userInput);

            if (selectedContact != null) { ShowContactInfo(selectedContact); return; }

            Console.WriteLine($"Could not find given contact with  number: {userInput}");
        }



        public static void ShowAllContacts(List<Contact> contacts)
        {
            Console.WriteLine("All contacts:");
            foreach (var contact in contacts)
            {
                ShowContactInfo(contact);
            }
            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            List<Contact> contacts = phoneBook.GetAllContacts();

            ShowAllContacts(contacts);

            //1.Add new contact
            NewContactInput(phoneBook);
            //2.Show contacts by number
            PrintContactInfo(SearchContactBy.Number, phoneBook);
            //3.Show all contacts
            ShowAllContacts(contacts);
            //4.Show contacts by name
            PrintContactInfo(SearchContactBy.Name, phoneBook);




        }
    }
}

namespace PhoneBookApp
{

    internal class PhoneBook
    {
        private List<Contact> Contacts = new List<Contact>()
        {
            new Contact("John", "+48 123 456 789"),
            new Contact("Igor", "+48 231 436 749"),
            new Contact("Mark", "+41 541 456 729")
        };

        private Contact? getContactData(string contact)
        {
            string[] data = contact.Split(':');
            if (data.Length <= 1)
            { Console.WriteLine("Bad format provided"); return null; }

            return new Contact(data[0], data[1]);
        }

        public void AddNewContact(string newContact)
        {
            Contact? contactData = getContactData(newContact);
            if (contactData != null) Contacts.Add(contactData);
        }

        public Contact? GetContact(SearchContactBy searchBy, string value)
        {
            Contact? result = Contacts.Find(contact => contact[searchBy] == value);
            return result;
        }

        public List<Contact> GetAllContacts()
        {
            return Contacts;
        }
    }
}

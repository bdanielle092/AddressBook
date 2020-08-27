using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> ContactList { get; set; }
        public void AddContact(Contact newContact)
        {
            ContactList.Add(newContact.Email, newContact);

        }
        public void GetByEmail(string email)
        {
            foreach (KeyValuePair<string, Contact> newContact.Email in AddressBook);
        }
    }
}
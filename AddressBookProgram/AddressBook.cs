using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    class AddressBook
    {

        List<Contacts> contactList;
        public AddressBook()
        {
            contactList = new List<Contacts>();
        }
        public void addContact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNo, string eMail)
        {
            Contacts contact = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNo, eMail);
            contactList.Add(contact);
        }
    }
}

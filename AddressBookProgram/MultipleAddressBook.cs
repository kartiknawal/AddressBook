using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    class MultipleAddressBook
    {
        Dictionary<string, AddressBook> addressBooksCollection = new Dictionary<string, AddressBook>();
        public MultipleAddressBook()
        {
            addressBooksCollection = new Dictionary<string, AddressBook>();
        }
        public void AddAddressBook(string name)
        {
            AddressBook addressBook = new AddressBook();
            addressBooksCollection.Add(name, addressBook);

        }
        public AddressBook GetAddressBook(string name)
        {
            if (addressBooksCollection.ContainsKey(name))
            {
                return addressBooksCollection[name];
            }
            return null;
        }
    }
}

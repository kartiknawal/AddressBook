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
    }
}

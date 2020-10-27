using System;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            string[] details;

            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("Enter details separated by a comma");
            Console.WriteLine("First Name, Last Name, Address, City, State, ZipCode, Email");
            details = Console.ReadLine().Split(",");

            addressBook.addContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);

            Console.WriteLine("Details Added");
        }
    }
}

﻿using System;

namespace AddressBookProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] name;
            int choice = 0;
            string[] details;
            bool flag = true;

            MultipleAddressBook multipleAddressBooks = new MultipleAddressBook();
            AddressBook addressBook = null;

            Console.WriteLine("Welcome to Address Book Program");
            while (true)
            {

                Console.WriteLine("1.Add Address Book\n2.Open Address Book");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name of Address Book");
                string addBookName = Console.ReadLine();
                if (choice == 1)
                {
                    multipleAddressBooks.AddAddressBook(addBookName);
                    addressBook = multipleAddressBooks.GetAddressBook(addBookName);
                    flag = true;

                }
                else if (choice == 2)
                {
                    addressBook = multipleAddressBooks.GetAddressBook(addBookName);
                    flag = true;
                    if (addressBook == null)
                    {
                        Console.WriteLine("No such Address Book");
                        flag = false;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    flag = false;
                }

                while (flag)
                {

                    Console.WriteLine("1.Add New Contact\n2.Edit Contact\n3.Remove contact\n4.Exit");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter details separated by a comma");
                            Console.WriteLine("First Name, Last Name, Address, City, State, ZipCode, Email");
                            details = Console.ReadLine().Split(",");

                            string message = addressBook.addContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);

                            Console.WriteLine(message);
                            break;
                        case 2:
                            Console.WriteLine("Enter the name to edit");
                            name = Console.ReadLine().Split(" ");

                            if (addressBook.CheckName(name[0], name[1]) == true)
                            {
                                Console.WriteLine("Enter the following details separated by comma");
                                Console.WriteLine("FirstName,LastName,Address, City, State, ZipCode, Email");
                                details = Console.ReadLine().Split(",");
                                addressBook.editContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
                                Console.WriteLine("Details editted successfully");
                            }
                            else
                            {
                                Console.WriteLine("No such contact found");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the name to be removed");
                            name = Console.ReadLine().Split(" ");
                            if (addressBook.CheckName(name[0], name[1]) == true)
                            {
                                addressBook.removeContact(name[0], name[1]);
                                Console.WriteLine("Contact Removed Successfully");
                            }
                            else
                            {
                                Console.WriteLine("No such contact found");
                            }
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

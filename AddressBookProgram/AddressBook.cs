﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
namespace AddressBookProgram
{
    public class AddressBook
    {

        public List<Contacts> contactList;
        string path = @"C:\Users\Gharat\source\repos\AddressBook\Address Book Contacts.txt";

        public AddressBook()
        {
            contactList = new List<Contacts>();

        }
        public string AddContact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNo, string eMail)
        {
            if (CheckName(firstName, lastName) == false)
            {
                Contacts contact = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNo, eMail);
                contactList.Add(contact);
                return "Details Added Successfully";
            }
            return "Name already exists";
        }
        public void EditContact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNo, string eMail)
        {
            foreach (Contacts c in contactList)
            {
                if (c.firstName.Equals(firstName))
                {
                    c.lastName = lastName;
                    c.address = address;
                    c.city = city;
                    c.state = state;
                    c.zipCode = zipCode;
                    c.phoneNo = phoneNo;
                    c.eMail = eMail;

                    return;
                }
            }
        }
        public void RemoveContact(string firstName, string lastName)
        {
            foreach (Contacts c in contactList)
            {
                if (c.firstName.Equals(firstName) && c.lastName.Equals(lastName))
                {
                    contactList.Remove(c);

                    return;
                }
            }
        }
        public bool CheckName(string firstName, string lastName)
        {

            foreach (Contacts contact in contactList.FindAll(e => e.firstName.Equals(firstName) && e.lastName.Equals(lastName)))
            {
                return true;
            }
            return false;
        }
        public List<Contacts> GetPersonByCityOrState(string cityOrState)
        {
            List<Contacts> contact = new List<Contacts>();
            foreach (Contacts c in contactList.FindAll(e => e.city.Equals(cityOrState) || e.state.Equals(cityOrState)))
            {
                contact.Add(c);
            }
            return contact;
        }
        public void SortByName()
        {
            contactList.Sort((contact1, contact2) => contact1.firstName.CompareTo(contact2.firstName));
            foreach (Contacts c in contactList)
            {
                Console.WriteLine(c.ToString());
            }

        }
        public void SortByCity()
        {
            contactList.Sort((contact1, contact2) => contact1.city.CompareTo(contact2.city));
            foreach (Contacts c in contactList)
            {
                Console.WriteLine(c.ToString());
            }

        }
        public void SortByState()
        {
            contactList.Sort((contact1, contact2) => contact1.state.CompareTo(contact2.state));
            foreach (Contacts c in contactList)
            {
                Console.WriteLine(c.ToString());
            }

        }
        public void SortByZipCode()
        {
            contactList.Sort((contact1, contact2) => contact1.zipCode.CompareTo(contact2.zipCode));
            foreach (Contacts c in contactList)
            {
                Console.WriteLine(c.ToString());
            }

        }
        public void WriteToFile(string addressBookName)
        {
            if (FileExitsts())
            {
                int count = 0;
                Console.WriteLine(addressBookName + ":");
                using (StreamWriter sr = File.AppendText(path))
                {

                    foreach (Contacts c in contactList)
                    {
                        sr.WriteLine(++count + " " + c.ToString() + "\n");

                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }

        }
        public void ReadFromFile()
        {
            if (FileExitsts())
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
        }
        public void ClearFile()
        {
            File.WriteAllText(path, string.Empty);
        }
        public bool FileExitsts()
        {
            if (File.Exists(path))
                return true;
            return false;
        }
    }
}

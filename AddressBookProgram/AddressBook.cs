﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    public class AddressBook
    {

        List<Contacts> contactList;


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
            foreach (Contacts c in contactList)
            {
                if (c.firstName.Equals(firstName) && c.lastName.Equals(lastName))
                {
                    return true;
                }
            }
            return false;
        }
        public void SearchContactByCityOrState(string cityOrState)
        {

            foreach (var contact in contactList)
            {
                if (contact.city == cityOrState || contact.state == cityOrState)
                {
                    Console.WriteLine("Name :" + contact.firstName + " " + contact.lastName + "\nAddress :" + contact.address + "   ZipCode :" + contact.zipCode + "\nPhone No :" + contact.phoneNo + "   Email :" + contact.eMail);
                }
            }

        }

    }
}

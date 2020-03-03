using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
   public class AddressBook
    {
        public static void AddressBookMethods()
        {
            FirstPerson firstPerson = new FirstPerson();
            Console.WriteLine("Firstperson details:");
            firstPerson.PersonName();
            firstPerson.PersonAge();
            firstPerson.PersonCity();
            Console.WriteLine("Secondperson details:");
            SecondPerson secondPerson = new SecondPerson();
            secondPerson.PersonName();
            secondPerson.PersonAge();
            secondPerson.PersonCity();
        }
    }
}

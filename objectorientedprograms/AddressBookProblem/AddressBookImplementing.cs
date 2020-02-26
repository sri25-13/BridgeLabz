using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBookProblem
{
    class AddressBookImplementing
    {
        public static void SerializingAndDeserializing()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\AddressBookProblem\AddressBook.json";
            string jsonfile = Utility.ReadFile(json);
            Model m = AddressBookUtility.Deserializing(jsonfile);
            AddressBookUtility.Display(m);
            AddressBookMethodCalling ab = new AddressBookMethodCalling();
            ab.MethodCalling(m);
            AddressBookUtility.Display(m);
            AddressBookUtility.Serializing(m, json);


        }
    }
}

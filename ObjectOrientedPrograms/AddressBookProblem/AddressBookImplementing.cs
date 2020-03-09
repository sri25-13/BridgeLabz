// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookImplementing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.AddressBookProblem
{
    /// <summary>
    /// class for implementing address book
    /// </summary>
    public class AddressBookImplementing
    {
        /// <summary>
        /// Serializing the and Deserializing.
        /// </summary>
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

﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.AddressBookProblem
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.IO;

    /// <summary>
    /// utility class for AddressBook
    /// </summary>
    public class AddressBookUtility
    {
        /// <summary>
        /// Serializings the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="jsonfile">The jsonfile.</param>
        public static void Serializing(Model model, string jsonfile)
        {
            try
            {
                string jsonResultString = JsonConvert.SerializeObject(model);
                File.WriteAllText(jsonfile, jsonResultString);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        /// <summary>
        /// Deserializings the specified jsonfile.
        /// </summary>
        /// <param name="jsonfile">The jsonfile.</param>
        /// <returns>
        /// returns modelclass object
        /// </returns>
        public static Model Deserializing(string json)
        {
            Model file = null;
            try
            {
                file = JsonConvert.DeserializeObject<Model>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return file;
        }

        /// <summary>
        /// Adds the person.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void AddPerson(Model model)
        {
            List<AddressBookDetails> ad = model.Person;
            AddressBookDetails data = new AddressBookDetails();
            Console.WriteLine("enter person details to be added");
            Console.WriteLine("enter firstname");
            data.Firstname = Utility.ReadString();
            Console.WriteLine("enter lastname");
            data.Lastname = Utility.ReadString();
            Console.WriteLine("enter address");
            data.Address = Utility.ReadString();
            Console.WriteLine("enter state");
            data.State = Utility.ReadString();
            Console.WriteLine("enter city");
            data.City = Utility.ReadString();
            Console.WriteLine("enter zip");
            data.Zip = Utility.ReadInt();
            Console.WriteLine("enter phonenumber");
            data.PhoneNumber = Utility.ReadLong();
            ad.Add(data);
        }

        /// <summary>
        /// Deletes the person.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void DeletePerson(Model model)
        {
            List<AddressBookDetails> ad = model.Person;
            Console.WriteLine("enter last name to be removed");
            string lastname = Utility.ReadString();
            foreach (var name in ad)
            {
                if (name.Lastname.Equals(lastname))
                {
                    ad.Remove(name);
                    break;
                }
            }
        }

        /// <summary>
        /// Displays the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void Display(Model model)
        {
            List<AddressBookDetails> ad = model.Person;
            Console.WriteLine("\n");
            Console.WriteLine("firstname\tLastname\tAddress\t\tState\tcity\tZip\tPhonenumber");
            if (model != null)
            {
                foreach (var data in ad)
                {
                    Console.WriteLine(data.Firstname + "\t" + data.Lastname + "\t" + data.Address + "\t" + data.State + "\t" + data.City + "\t" + data.Zip + "\t" + data.PhoneNumber);
                }
            }
        }

        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void UpdateData(Model model)
        {
            List<AddressBookDetails> ad = model.Person;
            Console.WriteLine("enter lastname of a person");
            string lastname = Utility.ReadString();
            foreach (var name in ad)
            {
                if (name.Lastname == lastname)
                {
                    Console.WriteLine("enter any property to get updated");
                    string property = Utility.ReadString();
                    if (property == "Firstname")
                    {
                        Console.WriteLine("enter a new firstname to get updated");
                        string newName = Utility.ReadString();
                        name.Firstname = newName;
                    }

                    if (property == "Lastname")
                    {
                        Console.WriteLine("enter a new lastname to get updated");
                        string newLastName = Utility.ReadString();
                        name.Lastname = newLastName;
                    }

                    if (property == "Address")
                    {
                        Console.WriteLine("enter a new address to get updated");
                        string newAddress = Utility.ReadString();
                        name.Address = newAddress;
                    }

                    if (property == "State")
                    {
                        Console.WriteLine("enter new state to be updated");
                        string newState = Utility.ReadString();
                        name.State = newState;
                    }

                    if (property == "City")
                    {
                        Console.WriteLine("enter a new city to get updated");
                        string newCity = Utility.ReadString();
                        name.City = newCity;
                    }

                    if (property == "Zip")
                    {
                        Console.WriteLine("enter a new zip to get updated");
                        int newZip = Utility.ReadInt();
                        name.Zip = newZip;
                    }

                    if (property == "PhoneNumber")
                    {
                        Console.WriteLine("enter a new phonenumber to get updated");
                        long newPhoneNumber = Utility.ReadLong();
                        name.PhoneNumber = newPhoneNumber;
                    }
                }
            }
        }
    }
}
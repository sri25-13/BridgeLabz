using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms.AddressBookProblem
{
    class AddressBookUtility
    {
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
        public static Model Deserializing(string Jsonfile)
        {
            Model file = null;
            try
            {
                file = JsonConvert.DeserializeObject<Model>(Jsonfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return file;
        }
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

        public static void UpdateData(Model model)
        {
            List<AddressBookDetails> ad = model.Person;
            Console.WriteLine("enter lastname of a person");
            String lastname = Utility.ReadString();
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




// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// class for Utility
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
        {
            string s = Console.ReadLine();
            return s;
        }

        /// <summary>
        /// Reads the double.
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Reads the long.
        /// </summary>
        /// <returns></returns>
        public static long ReadLong()
        {
            return long.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Reads the int.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            string jsonfile = "";
            try
            {
                jsonfile = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return jsonfile;
        }

        /// <summary>
        /// Displays the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void Display(Model model)
        {
            List<InventoryDetails>[] list = new List<InventoryDetails>[3];
            list[0] = model.Rices;
            list[1] = model.Wheats;
            list[2] = model.Pulses;
            Console.WriteLine("\n");
            Console.WriteLine("Name\t\t\tPrice\t\t\tWeight\t\t\tTotalPrice");
            foreach (var items in list)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + "\t\t\t" + item.Price + "\t\t\t" + item.Weight + "\t\t\t" + (item.Price * item.Weight));
                }
            }
        }

        /// <summary>
        /// Displays the stock.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void DisplayStock(StockAccountManagement.Model model)
        {
            List<StockAccountManagement.StockDetails> stock = model.Stocks;
            Console.WriteLine("\n");
            Console.WriteLine("Stockname\tShare\tShareprice\tTotalPrice");
            foreach (var data in stock)
            {
                Console.WriteLine(data.StockName + "\t\t\t" + data.Share + "\t\t\t" + data.SharePrice + "\t\t\t" + (data.Share * data.SharePrice));
            }
        }

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
        /// <returns></returns>
        public static Model Deserializing(string jsonfile)
        {
            Model file = null;
            try
            {
                file = JsonConvert.DeserializeObject<Model>(jsonfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return file;
        }

        /// <summary>
        /// Deserializings the stock.
        /// </summary>
        /// <param name="jsonfile">The jsonfile.</param>
        /// <returns></returns>
        public static StockAccountManagement.Model DeserializingStock(string jsonfile)
        {
            StockAccountManagement.Model file = null;
            try
            {
                file = JsonConvert.DeserializeObject<StockAccountManagement.Model>(jsonfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return file;
        }

        /// <summary>
        /// Adds the rice.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void AddRice(Model model)
        {
            List<InventoryDetails> rice = model.Rices;
            InventoryDetails newitem = new InventoryDetails();
            Console.WriteLine("enter the rice variety");
            newitem.Name = Utility.ReadString();
            Console.WriteLine("enter the price");
            newitem.Price = Utility.ReadDouble();
            Console.WriteLine("enter weight");
            newitem.Weight = Utility.ReadDouble();
            rice.Add(newitem);
        }

        /// <summary>
        /// Adds the wheats.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void AddWheats(Model model)
        {
            List<InventoryDetails> wheat = model.Wheats;
            InventoryDetails wheats = new InventoryDetails();
            Console.WriteLine("enter the wheat variety name");
            wheats.Name = Utility.ReadString();
            Console.WriteLine("enter the price");
            wheats.Price = Utility.ReadDouble();
            Console.WriteLine("enter weight");
            wheats.Weight = Utility.ReadDouble();
            wheat.Add(wheats);
        }

        /// <summary>
        /// Adds the pulses.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void AddPulses(Model model)
        {
            List<InventoryDetails> pulses = model.Pulses;
            InventoryDetails newpulses = new InventoryDetails();
            Console.WriteLine("enter the pulses variety name");
            newpulses.Name = Utility.ReadString();
            Console.WriteLine("enter the price");
            newpulses.Price = Utility.ReadDouble();
            Console.WriteLine("enter weight");
            newpulses.Weight = Utility.ReadDouble();
            pulses.Add(newpulses);
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void RemoveItem(Model model)
        {
            List<InventoryDetails>[] inventory = new List<InventoryDetails>[3];
            inventory[0] = model.Rices;
            inventory[1] = model.Wheats;
            inventory[2] = model.Pulses;
            Console.WriteLine("enter an item to get removed from the list");
            string removeitem = Utility.ReadString();
            foreach (var items in inventory)
            {
                foreach (var item in items)
                {
                    if (item.Name == removeitem)
                    {
                        items.Remove(item);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void UpdateData(Model model)
        {
            List<InventoryDetails>[] inventory = new List<InventoryDetails>[3];
            inventory[0] = model.Rices;
            inventory[1] = model.Wheats;
            inventory[2] = model.Pulses;
            Console.WriteLine("enter name of the item to get updated in the list");
            string updateitem = Utility.ReadString();
            foreach (var items in inventory)
            {
                foreach (var item in items)
                {
                    if (item.Name == updateitem)
                    {
                        Console.WriteLine("enter any property to get updated");
                        string property = Utility.ReadString();
                        if (property == "Name")
                        {
                            Console.WriteLine("enter a new name to get updated");
                            string newName = Utility.ReadString();
                            item.Name = newName;
                        }

                        if (property == "Weight")
                        {
                            Console.WriteLine("enter a new weight to get updated");
                            double newWeight = Utility.ReadDouble();
                            item.Weight = newWeight;
                        }

                        if (property == "Price")
                        {
                            Console.WriteLine("enter a new price to get updated");
                            double newPrice = Utility.ReadDouble();
                            item.Price = newPrice;
                        }
                    }
                }
            }
        }
    }
}

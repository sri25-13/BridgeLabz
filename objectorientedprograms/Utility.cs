using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;



namespace ObjectOrientedPrograms
{
    class Utility
    {
        public static string ReadString()
        {
            string s = Console.ReadLine();
            return s;
        }
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
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
        public static int RandomValues(int num)
        {
            Random random = new Random();
            int value = random.Next(num);
            return value;
        }
        public static void ShufflingCards(String[,] CardsArray)
        {
            int row1, row2, column1, column2;
            for (int i = 0; i < 52; i++)
            {
                row1 = RandomValues(CardsArray.GetLength(0));
                column1 = RandomValues(CardsArray.GetLength(1));
                row2 = RandomValues(CardsArray.GetLength(0));
                column2 = RandomValues(CardsArray.GetLength(1));
                Swap(CardsArray, row1, column1, row2, column2);
            }
        }
        public static void CardArray(String[] Suits, String[,] Cards, String[] Rank)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards[i, j] = Suits[i] + "-" + Rank[j];
                }

            }
        }
        public static void PrintString2DArray(string[,] PlayersArray)
        {
            for (int i = 0; i < PlayersArray.GetLength(0); i++)
            {
                for (int j = 0; j < PlayersArray.GetLength(1); j++)
                    Console.Write(PlayersArray[i, j]);
                Console.WriteLine();
            }
        }
        public static void Swap(string[,] CardsArray, int row1, int column1, int row2, int column2)
        {
            string temp = CardsArray[row1, column1];
            CardsArray[row1, column1] = CardsArray[row2, column2];
            CardsArray[row2, column2] = temp;
        }
        public static void DistributingCards(string[,] Cards, string[,] Players)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 9; j++)
                    Players[i, j] = Cards[i, j];
        }
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
            model.Rices = rice;
        }
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
            model.Wheats = wheat;
        }
       
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
            model.Pulses = pulses;
        }
        public static void RemoveItem(Model model)
        {
            List<InventoryDetails>[] inventory = new List<InventoryDetails>[3];
            inventory[0] = model.Rices;
            inventory[1] = model.Wheats;
            inventory[2] = model.Pulses;
            Console.WriteLine("enter an item to get removed from the list");
            String removeitem = Utility.ReadString();
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
        public static void UpdateData(Model model)
        {
            List<InventoryDetails>[] inventory = new List<InventoryDetails>[3];
            inventory[0] = model.Rices;
            inventory[1] = model.Wheats;
            inventory[2] = model.Pulses;
            Console.WriteLine("enter name of the item to get updated in the list");
            String updateitem = Utility.ReadString();
            foreach (var items in inventory)
            {                                      
                foreach (var item in items)
                {                                  
                    if (item.Name == updateitem)
                    {
                        Console.WriteLine("enter any property to get updated");
                        String property = Utility.ReadString();
                        if (property == "Name")
                        {
                            Console.WriteLine("enter a new name to get updated");
                            String newName = Utility.ReadString();
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
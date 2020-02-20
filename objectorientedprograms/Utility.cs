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
            list[0] = model.rices;
            list[1] = model.wheats;
            list[2] = model.pulses;
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
    }
}

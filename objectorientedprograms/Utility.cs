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

    }
}

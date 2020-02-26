using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class StockAccountImplementation
    {
        public static void Deserializing()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\StockAccountManagement\StockAccounts.json";
            string jsonfile = Utility.ReadFile(json);
            StockAccountManagement.Model m = Utility.DeserializingStock(jsonfile);
            Utility.DisplayStock(m);
        }
    }
}
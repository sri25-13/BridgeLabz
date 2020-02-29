using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class InventoryManagement
    {
        public static void Test()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\InventoryDataManagement\InventoryData.json";
            string jsonfile = Utility.ReadFile(json);
            Model m = Utility.Deserializing(jsonfile);
            Utility.Display(m);
        }
    }
}

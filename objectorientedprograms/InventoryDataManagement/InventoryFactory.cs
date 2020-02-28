using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class InventoryFactory
    {
        public static void Test()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\InventoryDataManagement\inventory.json";
            string jsonfile = Utility.ReadFile(json);
            Model m = Utility.Deserializing(jsonfile);
            Utility.Display(m);
            InventoryManagement1 im = new InventoryManagement1();
            im.CallingMethods(m);
            Utility.Display(m);
            Utility.Serializing(m, json);
        }
    }
}
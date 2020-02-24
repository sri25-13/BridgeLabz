using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Inventory1
    {
        public static void Test()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\inventory.json";
            string jsonfile = Utility.ReadFile(json);
            Model m = Utility.Deserializing(jsonfile);
            Utility.Display(m);
            InventoryManagement1 im = new InventoryManagement1();
            im.InventoryManagementMethod(m);
            Utility.Display(m);
            Utility.Serializing(m, json);
        }
    }
}
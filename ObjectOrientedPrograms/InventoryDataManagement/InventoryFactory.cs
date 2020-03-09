// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    /// <summary>
    /// class for Inventory
    /// </summary>
    public class InventoryFactory
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\InventoryDataManagement\InventoryData.json";
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
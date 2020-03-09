// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
   /* using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Text;
*/

    /// <summary>
    /// class for InventoryManagement
    /// </summary>
    public class InventoryManagement
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
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccountImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.StockAccountManagement
{
    /// <summary>
    /// class for implementing stockaccount
    /// </summary>
    public class StockAccountImplementation
    {
        /// <summary>
        /// Deserializings this instance.
        /// </summary>
        public static void Deserializing()
        {
            string json = @"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\StockAccountManagement\StockAccounts.json";
            string jsonfile = Utility.ReadFile(json);
            StockAccountManagement.Model m = Utility.DeserializingStock(jsonfile);
            Utility.DisplayStock(m);
        }
    }
}
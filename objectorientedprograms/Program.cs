using System;
namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.InventoryManagements\n2.DeckOfCards\n3.InventoryDataManagement\n4.AddressBookProblem\n5.StockAccountManagement");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    InventoryManagement.Test();
                    break;
                case 2:
                    DeckOfCards.DistributeCards();
                    break;
                case 3:
                    InventoryFactory.Test();
                    break;
                case 4:
                    AddressBookProblem.AddressBookImplementing.SerializingAndDeserializing();
                    break;
                case 5:
                    StockAccountManagement.StockAccountImplementation.Deserializing();
                    break;
            }
        }
    }
}

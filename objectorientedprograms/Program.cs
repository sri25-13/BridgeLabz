using System;
namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("1.InventoryManagements\n2.InventoryDataManagement\n3.AddressBookProblem\n4.StockAccountManagement");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    InventoryManagement.Test();
                    break;
                case 2:
                    InventoryFactory.Test();
                    break;
                case 3:
                    AddressBookProblem.AddressBookImplementing.SerializingAndDeserializing();
                    break;
                case 4:
                    StockAccountManagement.StockAccountImplementation.Deserializing();
                    break;
                
            }
        }
    }
}

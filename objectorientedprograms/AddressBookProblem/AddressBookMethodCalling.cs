using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBookProblem
{
    public class AddressBookMethodCalling
    {
        public  void MethodCalling(Model model)
        {
            Console.WriteLine("1.Adding person");
            Console.WriteLine("2.Removing person");
            Console.WriteLine("3.Updating data");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    AddressBookUtility.AddPerson(model);
                    break;
                case 2:
                    AddressBookUtility.DeletePerson(model);
                    break;
                case 3:
                    AddressBookUtility.UpdateData(model);
                    break;
            }
        }
    }
}
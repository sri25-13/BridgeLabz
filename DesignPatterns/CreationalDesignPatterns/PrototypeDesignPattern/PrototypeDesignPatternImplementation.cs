using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    public class PrototypeDesignPatternImplementation
    {
        public static void PrototypeImplementing()
        {
            Employee employee = new Employee();
            Console.WriteLine("enter employeename");
            employee.EmployeeName = Utility.ReadString();
            Console.WriteLine("enter employee id");
            employee.EmployeeId = Utility.ReadInt();

             Console.WriteLine(employee.GetDetails());
            Employee employee1 = (employee).Clone();
            Console.WriteLine("enter another employeename");
            employee1.EmployeeName = Utility.ReadString();
            //sConsole.WriteLine(employee1.GetDetails());
            Console.WriteLine("--------------");
            Console.WriteLine(employee.GetDetails());
            Console.WriteLine(employee1.GetDetails());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    public class Employee : EmployeeDetails
    {
        public string employeeName;
        public int employeeId;
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
       public override string ToString()
        {
            return string.Format("employeeName : {0}"+ "   "+"employeeId : {1}", EmployeeName,EmployeeId);
        }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}


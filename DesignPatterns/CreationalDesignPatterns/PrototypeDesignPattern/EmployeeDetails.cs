using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
  public abstract class EmployeeDetails
    {
        public abstract Employee Clone();
        public abstract string GetDetails();
    }
}

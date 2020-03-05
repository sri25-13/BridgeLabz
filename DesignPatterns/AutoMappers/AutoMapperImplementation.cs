using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace DesignPatterns.AutoMappers
{

    public class AutoMapperImplementation
    {
        
        public static void AutoMapperImplementing()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<Person, Employee>()
                              .ForMember(p => p.EmployeeName, e => e.MapFrom(a => a.PersonName))
                              .ForMember(p => p.EmployeeId, e => e.MapFrom(a => a.PersonId))
                              .ForMember(p => p.EmployeeAddress, e => e.MapFrom(a => a.PersonAddress));
            });
            Person person = new Person();
            {
                person.PersonName = "harshini";

                person.PersonId = "15wj";

                person.PersonAddress = "Pratap nagar";
            };

           var emp = Mapper.Map<Person, Employee>(person);
            Console.WriteLine("name:" + emp.EmployeeName + ", id :" + emp.EmployeeId + ", address :" + emp.EmployeeAddress);
        }
    }
}

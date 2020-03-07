// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AutoMappers
{
    using System;
    using AutoMapper;

    /// <summary>
    /// class for implementing AutoMapper
    /// </summary>
    public class AutoMapperImplementation
    {
        /// <summary>
        /// Automatics the mapper implementing.
        /// </summary>
        public static void AutoMapperImplementing()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<Person, Employee>()
                              .ForMember(p => p.EmployeeName, e => e.MapFrom(a => a.PersonName))
                              .ForMember(p => p.EmployeeId, e => e.MapFrom(a => a.PersonId))
                              .ForMember(p => p.EmployeeAddress, e => e.MapFrom(a => a.PersonAddress));
            });
            Person person = new Person
            {
                PersonName = "harshini",

                PersonId = "15wj",

                PersonAddress = "Pratap nagar"
            };
            var emp = Mapper.Map<Person, Employee>(person);
            Console.WriteLine("name:" + emp.EmployeeName + ", id :" + emp.EmployeeId + ", address :" + emp.EmployeeAddress);
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Reflection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// class for reflection
    /// </summary>
    public class Reflection
    {
        /// <summary>
        /// Reflections the implementing.
        /// </summary>
        public static void ReflectionImplementing()
        {
            Type type = typeof(Customer);
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("List of properties of the Customer class are:");
            foreach (PropertyInfo propertyInfo in properties)
            {
                Console.WriteLine(propertyInfo.Name);
            }

            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine("List of constructors of the customer class are :");
            foreach (ConstructorInfo constructorInfo in constructors)
            {
                Console.WriteLine(constructorInfo);
            }

            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("List of methods of the customer class are :");
            foreach (MethodInfo methodInfo in methods)
            {
                Console.WriteLine(methodInfo);
            }
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VisitorDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    using System;

    /// <summary>
    /// class for VisitorDesignPattern
    /// </summary>
    public class VisitorDesignPattern
    {
        /// <summary>
        /// Visitors the design pattern implementation.
        /// </summary>
        public static void VisitorDesignPatternImplementation()
        {
            IItemElement[] items = new IItemElement[] { new Book(20, "1234"), new Book(100, "5678"), new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple") };
            int total = CalculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        /// <summary>
        /// Calculates the price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        private static int CalculatePrice(IItemElement[] items)
        {
            IShoppingCartVisitor visitor = new ShoppingCartVisitorImplementation();
            int sum = 0;
            foreach (IItemElement item in items)
            {
                sum += item.Accept(visitor);
            }

            return sum;
        }
    }
}

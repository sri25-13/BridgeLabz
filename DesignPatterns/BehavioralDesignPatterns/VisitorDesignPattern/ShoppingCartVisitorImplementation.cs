﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartVisitorImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    using System;

    /// <summary>
    /// class for implementing ShoppingCartVisitor
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern.IShoppingCartVisitor" />
    public class ShoppingCartVisitorImplementation : IShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        public int Visit(Book book)
        {
            int cost;
            //apply 5$ discount if book price is greater than 50 
            if (book.GetPrice() > 50)
            {
                cost = book.GetPrice() - 5;
            }
            else
                cost = book.GetPrice();

            Console.WriteLine("Book ISBN::" + book.GetIsbnNumber() + " cost =" + cost);
            return cost;
        }

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns></returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPricePerKg() * fruit.GetWeight();
            Console.WriteLine(fruit.GetName() + " cost = " + cost);
            return cost;
        }
    }
}
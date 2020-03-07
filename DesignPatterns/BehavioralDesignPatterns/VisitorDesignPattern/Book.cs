// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Book.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    using System;

    /// <summary>
    /// Class book
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern.IItemElement" />
    public class Book : IItemElement
    {
        /// <summary>
        /// The price
        /// </summary>
        private readonly int price;

        /// <summary>
        /// The isbn number
        /// </summary>
        private readonly string isbnNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <param name="isbn">The isbn.</param>
        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns></returns>
        public int GetPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Gets the isbn number.
        /// </summary>
        /// <returns></returns>
        public string GetIsbnNumber()
        {
            return this.isbnNumber;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}

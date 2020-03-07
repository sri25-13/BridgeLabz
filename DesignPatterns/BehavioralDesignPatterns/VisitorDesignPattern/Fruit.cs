// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fruit.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    using System;

    /// <summary>
    /// class fruit 
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern.IItemElement" />
    public class Fruit : IItemElement
    {
        /// <summary>
        /// The price per kg
        /// </summary>
        private readonly int pricePerKg;

        /// <summary>
        /// The weight
        /// </summary>
        private readonly int weight;

        /// <summary>
        /// The name
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit"/> class.
        /// </summary>
        /// <param name="priceKg">The price kg.</param>
        /// <param name="wt">The wt.</param>
        /// <param name="nm">The nm.</param>
        public Fruit(int priceKg, int wt, string nm)
        {
            this.pricePerKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }

        /// <summary>
        /// Gets the price per kg.
        /// </summary>
        /// <returns></returns>
        public int GetPricePerKg()
        {
            return this.pricePerKg;
        }

        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <returns></returns>
        public int GetWeight()
        {
            return this.weight;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
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
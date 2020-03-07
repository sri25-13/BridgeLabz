// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IShoppingCartVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    /// <summary>
    /// Interface IShoppingCartVisitor
    /// </summary>
    public interface IShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        public int Visit(Book book);

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns></returns>
        public int Visit(Fruit fruit);
    }
}

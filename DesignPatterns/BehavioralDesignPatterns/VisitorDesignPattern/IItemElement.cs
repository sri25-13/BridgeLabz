// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IItemElement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    /// <summary>
    /// Interface IItemElement
    /// </summary>
    public interface IItemElement
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int Accept(IShoppingCartVisitor visitor);
    }
}

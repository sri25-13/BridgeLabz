// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Delegate.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Delegates
{
    using static ObjectOrientedPrograms.Delegates.Operations;

    /// <summary>
    /// class for Delegate
    /// </summary>
    public class Delegate
    {
        /// <summary>
        /// Multis the casting.
        /// </summary>
        public static void MultiCasting()
        {
            Operation operation = new Operation(Adding);
            operation += Operations.Multiplication;
            operation += Operations.Subtraction;
            operation(8, 9);
            operation -= Operations.Subtraction;
        }
    }
}

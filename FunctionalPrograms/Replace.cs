// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Replace.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for Replacing the string 
    /// </summary>
    public class Replace
    {
        /// <summary>
        /// Replaces the string.
        /// </summary>
        public static void ReplaceString()
        {
            string str = "Hello <<username>>,How are you?";
            Console.WriteLine("enter the string you want to replace with username");
            string s = Utility.ReadString();
            if (s.Length <= 3)
            {
                Console.WriteLine("INVALID INPUT");
            }
            else
            {
                string replace = str.Replace("<<username>>", s);
                Console.WriteLine(replace);
            }
        }
    }
}

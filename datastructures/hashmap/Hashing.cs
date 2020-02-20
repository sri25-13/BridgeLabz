// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hashing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.IO;

    /// <summary>
    /// class for performing Hashing
    /// </summary>
    public class Hashing
    {
        /// <summary>
        /// Hashes the map.
        /// </summary>
        public static void HashMap()
        {
            HashMap hm = new HashMap();
            FileStream fs = new FileStream(@"C:\Users\Bridgelabz\source\repos\hashmapinput.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs);
            string input = sr.ReadLine();
            string[] str = input.Split(" ");
            int[] array = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = int.Parse(str[i]);
            }

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                hm.HashingFunction(array[i]);
                hm.Print();
            }
        }
    }
}
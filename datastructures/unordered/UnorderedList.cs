// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnorderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.IO;

    /// <summary>
    /// class for Unorderedlist
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class UnorderedList<T>
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        public static void ReadFile()
        {
            UnOrderedListMethods<string> unorderedlist = new UnOrderedListMethods<string>();
            string[] words = File.ReadAllLines(@"C:\Users\Bridgelabz\source\repos\unorderedinput.txt");
            foreach (string s in words)
            {
                Console.WriteLine(s);
                unorderedlist.Add(s);
            }

            Console.WriteLine("\n");
            Console.WriteLine("enter an option to be executed");
            Console.WriteLine("1.Size\n2.Search\n3.Index\n4.IsEmpty\n5.Append\n6.Remove\n7.Insert\n8.Pop at position\n9.Pop\n");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    int n = unorderedlist.Size();
                    Console.WriteLine(n);
                    break;
                case 2:
                    Console.WriteLine("enter a string to search in the list");
                    string s1 = Utility.ReadString();
                    bool result = unorderedlist.Search(s1);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine("enter a string to check the index from the list");
                    string s2 = Utility.ReadString();
                    int pos = unorderedlist.Index(s2);
                    Console.WriteLine(pos);
                    break;
                case 4:
                    bool res = unorderedlist.IsEmpty();
                    Console.WriteLine("list is not empty: " + res);
                    break;
                case 5:
                    Console.WriteLine("enter a string to append into list");
                    string s3 = Utility.ReadString();
                    unorderedlist.Append(s3);
                    /* FileStream aFile = new FileStream(@"C:\Users\BridgeLabz\source\repos\Input.txt",
                         FileMode.Append, FileAccess.Write);
                     StreamWriter sw = new StreamWriter(aFile);
                     sw.WriteLine(s3);
                     unorderedlist.Print();
                     sw.Close();
                     aFile.Close();*/
                    unorderedlist.Print();
                    break;
                case 6:
                    Console.WriteLine("enter a string to remove from the list");
                    string s4 = Utility.ReadString();
                    unorderedlist.Remove(s4);
                    unorderedlist.Print();
                    break;
                case 7:
                    Console.WriteLine("enter a string to insert at a specified position");
                    string s5 = Utility.ReadString();
                    Console.WriteLine("enter position at which you want to insert the string");
                    int position = Utility.ReadInt();
                    unorderedlist.Insert(position, s5);
                    unorderedlist.Print();
                    break;
                case 8:
                    Console.WriteLine("enter position at which u want to remove the item");
                    int num = Utility.ReadInt();
                    unorderedlist.Pop(num);
                    unorderedlist.Print();
                    break;
                case 9:
                    string s6 = unorderedlist.Pop();
                    unorderedlist.Print();
                    Console.WriteLine("poped item  is" + s6);
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
        }
    }
}

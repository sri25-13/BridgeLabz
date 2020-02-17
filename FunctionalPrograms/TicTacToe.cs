// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for playing TicTacToe
    /// </summary>
   public class TicTacToe
    {
       public static int player = 0;
       public static int[,] BOARD = new int[3, 3];
        public static bool isEmpty = true;

        /// <summary>
        /// Initializes the board.
        /// </summary>
        public static void InitBoard()
        {
            Console.WriteLine("TIC TAC TOE GAME\nComputer is x\nPlayer  is o ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BOARD[i, j] = -10;
                }
            }

            Console.WriteLine("Board is this :");
            DispBoard();
           
        }
        /// <summary>
        /// Disps the board.
        /// </summary>
        public static void DispBoard()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("---------------");
                Console.Write("||");
                for (int j = 0; j < 3; j++)
                {
                    if (BOARD[i, j] == 0)
                    {
                        count++;
                        Console.Write(" o |");
                    }
                    else if (BOARD[i, j] == 1)
                    {
                        count++;
                        Console.Write(" x |");
                    }
                    else
                        Console.Write("   |");
                }
                Console.WriteLine("|");
            }
            if (count == 9)
            {
                isEmpty = false;
            }
            Console.WriteLine("---------------");
        }
        /// <summary>
        /// Puts the value.
        /// </summary>
        public static void PutVal()
        {
            Random random = new Random();
            int i;
            int j;
            if (player % 2 == 1)
            {
                i = (int)(random.NextDouble() * 10) % 3;
                j = (int)(random.NextDouble() * 10) % 3;
            }
            else
            {

                Console.WriteLine("enter value of row ");
                i = Utility.ReadInt();
                Console.WriteLine("enter value of column");
                j = Utility.ReadInt();
            }
            if (BOARD[i, j] == -10)
            {
                if (player % 2 == 0)
                {
                    BOARD[i, j] = 0;
                }
                else
                {
                    BOARD[i, j] = 1;
                    Console.WriteLine("Coumputer Choosing " + i + " " + j);
                }
            }
            else
            {

                PutVal();
            }
        }
        /// <summary>
        /// Wins this instance.
        /// </summary>
        /// <returns></returns>
        public static bool Win()
        {
            return ((BOARD[0, 0] + BOARD[0, 1] + BOARD[0, 2] == player * 3)
                 || (BOARD[1, 0] + BOARD[1, 1] + BOARD[1, 2] == player * 3)
                 || (BOARD[2, 0] + BOARD[2, 1] + BOARD[2, 2] == player * 3)
                 || (BOARD[0, 0] + BOARD[1, 0] + BOARD[2, 0] == player * 3)
                 || (BOARD[0, 1] + BOARD[1, 1] + BOARD[2, 1] == player * 3)
                 || (BOARD[0, 2] + BOARD[1, 2] + BOARD[2, 2] == player * 3)
                 || (BOARD[0, 0] + BOARD[1, 1] + BOARD[2, 2] == player * 3)
                 || (BOARD[2, 0] + BOARD[1, 1] + BOARD[0, 2] == player * 3));

        }

        /// <summary>
        /// Plays this instance.
        /// </summary>
        public static void Play()
        {
            InitBoard();
            while (isEmpty)
            {
                Console.WriteLine("Players turn");
                PutVal();
                DispBoard();
                if (Win())
                {

                    Console.WriteLine("Player won");
                    return;
                }
                player = 1;
                Console.WriteLine("Computers turn");
                PutVal();
                DispBoard();
                if (Win())
                {

                    Console.WriteLine("Computer won");
                    return;
                }
                player = 0;
            }
        }
    }
}

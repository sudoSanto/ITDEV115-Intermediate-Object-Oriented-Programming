using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV115
//Assignment 6

namespace TicTacToeInheritance
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string s) : base(s) { }

        public override int MakeMove(string[] currentBoard)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            // Pass -1 for invalid input.
            int move = -1;

            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    move = 6;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    move = 7;
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    move = 8;
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    move = 3;
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    move = 4;
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    move = 5;
                    break;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    move = 0;
                    break;

                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    move = 1;
                    break;

                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    move = 2;
                    break;

                default:
                    break;
            }//case

            if (move >= 0)
                if (currentBoard[move] == "X" || currentBoard[move] == "O")
                    move = -1;

            return move;

        }//MakeMove
    }
}

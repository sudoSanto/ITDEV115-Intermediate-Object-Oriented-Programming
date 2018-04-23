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
    class TicTacToeUI
    {
        public void AnnounceWinner(playerType player)
        {
            string piece = "";

            if (player == playerType.X)
                piece = "X";
            else if (player == playerType.O)
                piece = "O";

            Console.SetCursorPosition(10, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player " + piece + " won!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        public void DisplayBoardGrid(string[] b)
        {
            Console.SetCursorPosition(15, 5);
            Console.Write(" " + b[0] + " | " + b[1] + " | " + b[2]);
            Console.SetCursorPosition(15, 6);
            Console.Write("----------");
            Console.SetCursorPosition(15, 7);
            Console.Write(" " + b[3] + " | " + b[4] + " | " + b[5]);
            Console.SetCursorPosition(15, 8);
            Console.Write("----------");
            Console.SetCursorPosition(15, 9);
            Console.Write(" " + b[6] + " | " + b[7] + " | " + b[8]);
            Console.SetCursorPosition(0, 0);
        }

        public void DisplayGrid(playerType player)
        {
            string piece = "";

            if (player == playerType.X)
                piece = "X";
            else if (player == playerType.O)
                piece = "O";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 3);
            Console.Write("TIC TAC TOE GAME!");
            Console.SetCursorPosition(10, 15);
            Console.Write("Player " + piece + "'s turn!");
            Console.SetCursorPosition(10, 16);
            Console.Write("Press a number shown above to occupy that space!");
            Console.SetCursorPosition(0, 0);
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("\n\n\nReady to have a rousing game of Tic Tac toe?  The object");
            Console.WriteLine("of the game is to get three of your pieces either across, up and down,");
            Console.WriteLine("or diagonally.  If you do, before your opponent, you win the game!");
            Console.WriteLine("\n\nHit any key when you are ready to begin");
            Console.ReadKey();
        }
    }
}

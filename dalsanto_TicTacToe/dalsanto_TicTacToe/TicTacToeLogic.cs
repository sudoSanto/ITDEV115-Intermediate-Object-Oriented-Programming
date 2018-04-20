using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV115
//Assignment 5

namespace dalsanto_TicTacToe
{
    //I attached a TIC TAC TOE example done in C++.  Please read through, we will implement in C#.
    //Also we will need to practice Data Abstraction.
    //I want the UI stuff in a TicTacToeUI class and logic in TicTacToeLogic class - this document did not do that.
    //Post any questions on the Discussion Board.

    class TicTacToeLogic
    {
        public playerType IsPlaying(playerType pt)
        {
            if (pt == playerType.X)
                pt = playerType.O;
            else
                pt = playerType.X;

            return pt;
        }

        public bool IsTie(bool full, bool x, bool o)
        {
            bool isTie = false;

            if (full && !x && !o)
            {
                isTie = true;
                Console.SetCursorPosition(10, 18);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("The game is a tie!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 0);
            }

            return isTie;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGUI
{
    class Player
    {
        private string pieces = " ";
        public string Pieces { get { return pieces; } set { pieces = value; } }

        public Player(string s) { Pieces = s; }

        public bool MakeMove(string[] currentBoard, int move)
        {
            bool makeMove = true;

                if (currentBoard[move] == "X" || currentBoard[move] == "O")
                    makeMove = false;

            return makeMove;
        }
    }
}

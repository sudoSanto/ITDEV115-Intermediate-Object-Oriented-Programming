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
    class Board
    {
        // There are no methods or properties set for this Field in the UML.
        int count = 0;

        private int[,] winningCombos = {
            {0, 1, 2 },
            {3, 4, 5 },
            {6, 7, 8 },
            {0, 3, 6 },
            {1, 4, 7 },
            {2, 5, 8 },
            {0, 4, 8 },
            {2, 4, 6 }
            };
        public int[,] WinningCombos { get { return winningCombos; } }

        public Board() { }

        public bool IsFull(string[] currentBoard)
        {
            bool isFull = false;
            int numEmpty = 0;

            for (int i = 0; i < currentBoard.Length; i++)
            {
                if (currentBoard[i] != "X" && currentBoard[i] != "O")
                    numEmpty++;
            }

            if (numEmpty > 0)
                isFull = false;
            else
                isFull = true;

            return isFull;
        }

        public bool IsWinner(string[] currentBoard, playerType player)
        {
            int piecesInCombo = 0;
            string piece = " ";
            bool isWinner = false;

            if (player == playerType.X)
                piece = "X";
            if (player == playerType.O)
                piece = "O";

            for (int x = 0; x < winningCombos.GetLength(0); x++)
            {
                for (int y = 0; y < winningCombos.GetLength(1); y++)
                {
                    if (currentBoard[WinningCombos[x, y]] == piece)
                        piecesInCombo++;
                }
                if (piecesInCombo < 3)
                    piecesInCombo = 0;
            }

            if (piecesInCombo >= 3)
                isWinner = true;

            return isWinner;
        }
    }
}

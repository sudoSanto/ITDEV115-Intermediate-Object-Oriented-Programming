using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGUI
{
    public enum playerType { X, O }

    class Game
    {
        public TicTacToeLogic tttLogic = new TicTacToeLogic();

        public string[] gameArray = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };
        public string[] resetGameArray = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };

        public Board gameBoard = new Board();

        public playerType gamePlayer = playerType.X;

        public Player playerX = new Player("X");

        public Player playerO = new Player("O");

        public playerType IsPlaying(playerType pt) { return tttLogic.IsPlaying(pt); }

        public bool IsTie(bool full, bool x, bool o) { return tttLogic.IsTie(full, x, o); }

        public string MakeMove(int move, string makeMove)
        {
            switch (gamePlayer)
            {
                case playerType.X:
                    if (playerX.MakeMove(gameArray, move))
                    {
                        gameArray[move] = "X";
                        makeMove = "X";
                        gamePlayer = IsPlaying(playerType.X);
                    }
                    break;

                case playerType.O:
                    if (playerX.MakeMove(gameArray, move))
                    {
                        gameArray[move] = "O";
                        makeMove = "O";
                        gamePlayer = IsPlaying(playerType.O);
                    }
                    break;

                default:
                    break;
            }

            return makeMove;
        }
    }
}
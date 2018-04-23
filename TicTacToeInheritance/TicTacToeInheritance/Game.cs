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
    public enum playerType { X, O }

    class Game
    {
        // Not in UML, but in assignment instructions.
        TicTacToeLogic tttLogic = new TicTacToeLogic();
        TicTacToeUI tttUI = new TicTacToeUI();

        private string[] gameArray = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };

        Board gameBoard = new Board();

        private playerType gamePlayer = playerType.X;

        private Player playerX = new HumanPlayer("X");

        private Player playerO = new ComputerPlayer("O");

        private void AnnounceWinner(playerType player) { tttUI.AnnounceWinner(player); }

        private void DisplayBoardGrid(string[] currentBoard) { tttUI.DisplayBoardGrid(currentBoard); }

        private void DisplayGrid(playerType player) { tttUI.DisplayGrid(player); }

        private void DisplayWelcome() { tttUI.DisplayWelcome(); }

        private playerType IsPlaying(playerType pt) { return tttLogic.IsPlaying(pt); }

        private bool IsTie(bool full, bool x, bool o) { return tttLogic.IsTie(full, x, o); }

        public void Play()
        {
            string[] resetGameArray = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };
            bool runGame = true;
            int move = 0;

            DisplayWelcome();

            do
            {
                DisplayGrid(gamePlayer);
                DisplayBoardGrid(gameArray);

                switch (gamePlayer)
                {
                    case playerType.X:
                        move = playerX.MakeMove(gameArray);
                        if (move >= 0)
                        {
                            gameArray[move] = "X";
                            gamePlayer = IsPlaying(playerType.X);
                        }
                        break;

                    case playerType.O:

                        move = playerO.MakeMove(gameArray);
                        if (move >= 0)
                        {
                            gameArray[move] = "O";
                            gamePlayer = IsPlaying(playerType.O);
                        }
                        break;

                    default:
                        break;
                }

                // Player X wins.
                if (gameBoard.IsWinner(gameArray, playerType.X))
                {
                    AnnounceWinner(playerType.X);
                    runGame = false;
                }
                // Player Y wins.
                else if (gameBoard.IsWinner(gameArray, playerType.O))
                {
                    AnnounceWinner(playerType.O);
                    runGame = false;
                }
                // Tie.
                else if (IsTie(gameBoard.IsFull(gameArray),
                    gameBoard.IsWinner(gameArray, gamePlayer),
                    gameBoard.IsWinner(gameArray, gamePlayer)))
                    runGame = false;

                // Resets within the method to prevent recursion.  When the
                // method finishes, so does the app.
                if (!runGame)
                {
                    DisplayBoardGrid(gameArray);
                    gameArray = resetGameArray;
                    gamePlayer = playerType.X;
                    runGame = PlayAgain();
                }

            } while (runGame);
        }

        private bool PlayAgain()
        {
            bool playAgain = true;
            bool inMenu = true;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            Console.SetCursorPosition(10, 20);
            Console.Write("Play again?(y/n)");
            Console.SetCursorPosition(0, 0);

            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Y:
                        playAgain = true;
                        inMenu = false;
                        break;

                    case ConsoleKey.N:
                        playAgain = false;
                        inMenu = false;
                        break;

                    default:
                        break;
                }
            } while (inMenu);

            return playAgain;
        }
    }
}

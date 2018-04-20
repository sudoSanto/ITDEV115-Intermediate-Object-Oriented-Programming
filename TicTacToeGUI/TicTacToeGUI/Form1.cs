using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class Form1 : Form
    {
        Game tttGame = new Game();

        public Form1()
        {
            InitializeComponent();

            DisplayWelcome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = tttGame.MakeMove(6, button1.Text);
            changePlayer(button1.Text);
            checkWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = tttGame.MakeMove(7, button2.Text);
            changePlayer(button2.Text);
            checkWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = tttGame.MakeMove(8, button3.Text);
            changePlayer(button3.Text);
            checkWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = tttGame.MakeMove(3, button4.Text);
            changePlayer(button4.Text);
            checkWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = tttGame.MakeMove(4, button5.Text);
            changePlayer(button5.Text);
            checkWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = tttGame.MakeMove(5, button6.Text);
            changePlayer(button6.Text);
            checkWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = tttGame.MakeMove(0, button7.Text);
            changePlayer(button7.Text);
            checkWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = tttGame.MakeMove(1, button8.Text);
            changePlayer(button8.Text);
            checkWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = tttGame.MakeMove(2, button9.Text);
            changePlayer(button9.Text);
            checkWin();
        }

        private void changePlayer(string s)
        {
            if (s == "X")
                s = "O";
            else
                s = "X";

            label2.Text = "It's player " + s + "'s turn!";
        }

        private void checkWin()
        {
            // Player X wins.
            if (tttGame.gameBoard.IsWinner(tttGame.gameArray, playerType.X))
            {
                AnnounceWinner(playerType.X);
            }
            // Player Y wins.
            else if (tttGame.gameBoard.IsWinner(tttGame.gameArray, playerType.O))
            {
                AnnounceWinner(playerType.O);
            }
            // Tie.
            else if (tttGame.IsTie(tttGame.gameBoard.IsFull(tttGame.gameArray),
                tttGame.gameBoard.IsWinner(tttGame.gameArray, tttGame.gamePlayer),
                tttGame.gameBoard.IsWinner(tttGame.gameArray, tttGame.gamePlayer)))
                AnnounceTie();
        }

        public void AnnounceWinner(playerType player)
        {
            string piece = "";

            if (player == playerType.X)
                piece = "X";
            else if (player == playerType.O)
                piece = "O";

            MessageBox.Show("Player " + piece + " won!");
            System.Windows.Forms.Application.Exit();
        }

        public void AnnounceTie()
        {
            MessageBox.Show("The game ended in a tie!");
            System.Windows.Forms.Application.Exit();
        }

        public void DisplayWelcome()
        {
            MessageBox.Show("Ready to have a rousing game of Tic Tac toe?  The object" +
                "\nof the game is to get three of your pieces either across, up and down," +
                "\nor diagonally.  If you do, before your opponent, you win the game!");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:\t\tMatt Dal Santo" +
                "\nCourse:\t\tITDEV-115-200\n" +
                "Instructor:\tMr. Menzl & Mr. Hunsicker\n" +
                "Assignment:\tTic Tac Toe GUI\n" +
                "Date:\t\t" + System.DateTime.Today.ToShortDateString());
        }
    }
}

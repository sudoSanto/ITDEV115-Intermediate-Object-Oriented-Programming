using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseInfo;

//Matthew Dal Santo
//ITDEV115
//Assignment 6

namespace TicTacToeInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Game tttGame = new Game();
            Info info = new Info();

            info.DisplayInfo("Assignment 6 - Tic Tac Toe Inheritance");

            tttGame.Play();
        }
    }
}

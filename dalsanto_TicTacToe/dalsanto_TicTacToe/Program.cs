using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseInfo;

//Matthew Dal Santo
//ITDEV115
//Assignment 5

namespace dalsanto_TicTacToe
{
    //Just want to say that the UML, the assignment directions and the text
    //supplied made this assignment one of the most difficult ones I've done
    //in our class to date.
    //The three combined were very confusing.  If the code looks very convoluted, 
    //it was only so that it obeyed the UML and assignment instructions.
    //The Info class was contained in a DLL as demonstrated in last week's class.
    class Program
    {
        static void Main(string[] args)
        {
            Game tttGame = new Game();
            Info info = new Info();

            info.DisplayInfo("Assignment 5 - Tic Tac Toe");

            tttGame.Play();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbleApp
{
    class JumbleApp
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 2
        //
        //I would have probably done the program differently, but didn't want to have points deducted, 
        //so didn't deviate from instructions.
        //I followed the instructions as much to the letter as I could and used all the given examples.

        static void Main(string[] args)
        {
            Info Assignment2Info = new Info();
            UIJumble JumbleMain = new UIJumble();

            Assignment2Info.DisplayInfo("Assignment 2 - Jumble Game");

            JumbleMain.PlayGame();
        }
    }
}

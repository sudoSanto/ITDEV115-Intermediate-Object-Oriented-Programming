using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballPlayerApplication
{
    class BaseBallPlayerUI
    {
        public BaseBallPlayerUI() { }
        BaseBallPlayer[] baseballPlayers = new BaseBallPlayer[2];

        private void DisplayInfo(double batAvg1, double batAvg2, string firstN1, string firstN2, 
            string lastN1, string lastN2, string teamN1, string teamN2)
        {
            string assignment = "Assignment 2 - Baseball Player Application";
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Name: \t\t\tMatthew Dal Santo");
            Console.WriteLine("Course: \t\tITDEV-115-200");
            Console.WriteLine("Instructor: \t\tMr. Hunsicker & Mr. Menzl");
            Console.WriteLine("Assignment: \t\t{0}", assignment);
            Console.WriteLine("Date: \t\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Player 1 Name: \t\t\t" + firstN1 + " " + lastN1);
            Console.WriteLine("Player 1 Batting Average: \t" + batAvg1);
            Console.WriteLine("Player 1 Team: \t\t\t" + teamN1);
            Console.WriteLine("");
            Console.WriteLine("Player 2 Name: \t\t\t" + firstN2 + " " + lastN2);
            Console.WriteLine("Player 2 Batting Average: \t" + batAvg2);
            Console.WriteLine("Player 2 Team: \t\t\t" + teamN2);
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public void MainMethod()
        {
            for (int i = 0; i < 2; i++)
            {
                baseballPlayers[i] = new BaseBallPlayer();
            }
            baseballPlayers[0].BattingAvg = .342;
            baseballPlayers[1].BattingAvg = .277;
            baseballPlayers[0].FirstName = "Babe";
            baseballPlayers[1].FirstName = "Norichika";
            baseballPlayers[0].LastName = "Ruth";
            baseballPlayers[1].LastName = "Aoki";
            baseballPlayers[0].Team = "Braves";
            baseballPlayers[1].Team = "Mets";

            DisplayInfo(baseballPlayers[0].BattingAvg, baseballPlayers[1].BattingAvg,
                baseballPlayers[0].FirstName, baseballPlayers[1].FirstName,
                baseballPlayers[0].LastName, baseballPlayers[1].LastName,
                baseballPlayers[0].Team, baseballPlayers[1].Team);
        }
    }
}

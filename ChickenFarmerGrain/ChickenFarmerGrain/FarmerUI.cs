using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenFarmerGrain
{
    class FarmerUI
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 3

        //There was no ProcessChoice method in the UML so it was not included in this App

        Farmer FarmerGuy = new Farmer();

        public FarmerUI() { }

        public void DisplayGameState()
        {
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
            Console.WriteLine("\nThe farmer is on the {0} bank of the river.", FarmerGuy.TheFarmer);
        }

        public void DisplayNorthBank()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("******************************* North Bank *************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < FarmerGuy.NorthBank.Count; i++)
            {
                Console.Write(FarmerGuy.NorthBank[i]);
                Console.Write("  ");
            }
        }

        public void DisplayRiver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DisplaySouthBank()
        {
            for (int i = 0; i < FarmerGuy.SouthBank.Count; i++)
            {
                Console.Write(FarmerGuy.SouthBank[i]);
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("******************************* South Bank *************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\tThis is the Farmer Game.  The object of the game");
            Console.WriteLine("\tis to get the farmer, fox, chicken, and grain to the other");
            Console.WriteLine("\tside of the river.  But hold on, not so fast.  If the farmer");
            Console.WriteLine("\tleaves the chicken and grain on either side of the river alone,");
            Console.WriteLine("\tthe chicken will eat the grain and that is not good.  If the");
            Console.WriteLine("\tfarmer leaves the fox and chicken on any side of the river alone,");
            Console.WriteLine("\tthe fox will eat the chicken.  That is also not good.  In either case");
            Console.WriteLine("\tyou lose the game.  If you get the farmer, the chicken,");
            Console.WriteLine("\tthe fox, and the grain safely across the river and intact, you win");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\nPress any key when you are ready to start this thought provoking game");
            Console.ReadKey();
            Console.Clear();
        }

        public bool Play(int intro)
        {
            if (intro < 1) { DisplayWelcome(); }
            DisplayGameState();
            return PromptForMove();
        }

        public void PlayGame()
        {
            bool RunGame = true;
            int count = 0;

            while(RunGame)
            {
                RunGame = Play(count);
                count++;
            }
        }

        //There was no ProcessChoice method in the UML so it was not included in this App
        //I would have liked to make an additional method or two to break this up.  But again I didn't
        //want to deviate from the UML.
        public bool PromptForMove()
        {
            string tempString = "";
            string stringChoice = "";
            bool choiceError = true;
            //0: keep going, 1: win, 4: Fox ate Chicken, 8: Chicken ate Grain
            int outcome = 0;

            Console.Write("\nChoose next item for the farmer.  If you choose nothing, just hit the enter key ");
            stringChoice = Console.ReadLine();
            if (stringChoice == "")
            {
                outcome = FarmerGuy.Move(stringChoice);
                choiceError = false;
            }
            else if (FarmerGuy.TheFarmer == Direction.North)
            {
                for (int i = 0; i < FarmerGuy.NorthBank.Count; i++)
                {
                    if (stringChoice.ToUpper() == FarmerGuy.NorthBank[i])
                    {
                        outcome = FarmerGuy.Move(stringChoice.ToUpper());
                        choiceError = false;
                        stringChoice = "";
                    }
                }
            }
            else if (FarmerGuy.TheFarmer == Direction.South)
            {
                for (int i = 0; i < FarmerGuy.SouthBank.Count; i++)
                {
                    if (stringChoice.ToUpper() == FarmerGuy.SouthBank[i])
                    {
                        outcome = FarmerGuy.Move(stringChoice.ToUpper());
                        choiceError = false;
                        stringChoice = "";
                    }
                }
            }

            Console.Clear();
            if (choiceError)
            {
                Console.WriteLine("\nThat item is not on this side of the river");
                Console.WriteLine("Please try again");
                return true;
            }
            else if (outcome == 1)
            {
                Console.WriteLine("\n\n\nYou have successfully completed the game!!");
                Console.WriteLine("CONGRATULATIONS");
                Console.Write("\n\n\nWould you like to play again? ");
                tempString = Console.ReadLine();
                if (tempString != "" && tempString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else if (outcome == 4)
            {
                Console.WriteLine("\n\n\n\n\n\nOh No! The Fox Ate the Chicken!!");
                Console.WriteLine("YOU LOSE");
                Console.Write("\n\n\nWould you like to play again? ");
                tempString = Console.ReadLine();
                if (tempString != "" && tempString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else if (outcome == 8)
            {
                Console.WriteLine("\n\n\n\n\n\nOh No! The Chicken Ate the Grain!!");
                Console.WriteLine("YOU LOSE");
                Console.Write("\n\n\nWould you like to play again? ");
                tempString = Console.ReadLine();
                if (tempString != "" && tempString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else { return true; }
        }
    }
}

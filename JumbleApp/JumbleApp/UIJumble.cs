using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbleApp
{
    class UIJumble
    {
        public UIJumble() { }

        public void DisplayWelcome()
        {
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("\n\tJumble Game!");
            Console.WriteLine("\n\tA word will display with it's characters jumbled.");
            Console.WriteLine("\tWhen prompted, guess the word.");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public void Play()
        {
            //variable not needed
            //string guess;
            string again;
            bool result = false;
            //hits not required.  variable not needed.
            //int counter = 0;

            Jumble theGame = new Jumble();
            theGame.ScrambleWord();

            do
            {
                Console.Clear();

                Console.Write("\n\n\tYour jumbled word is: ");
                Console.WriteLine(theGame.DisplayWord);

                Console.Write("\n\tGuess the word: ");
                result = theGame.CompareResult(Console.ReadLine());

                if (result)
                {
                    Console.WriteLine("\n\nThat is correct! You win!");
                    again = "NO";
                }
                else
                {
                    Console.WriteLine("\n\nNo, that is NOT correct!");

                    Console.Write("\n\tWould you like to try again?(Y/N): ");
                    again = Console.ReadLine().ToUpper();
                }
            }
            while ((!result) && ((again == "YES") || (again == "Y")));

            if (!result)
                Console.WriteLine("\n\nThe word was {0}", theGame.HiddenWord);
        }

        public void PlayGame()
        {
            string playAgain;

            DisplayWelcome();

            do
            {
                Play();

                Console.Write("\n\tWould you like to play again?(Y/N): ");
                playAgain = Console.ReadLine().ToUpper();
            }
            while ((playAgain == "YES") || (playAgain == "Y"));

            Console.Clear();
            Console.WriteLine("\n\n\tThank you for playing.\n\tI hope you had fun!");
        }

        public string TakeAGuess()
        {
            //variable not needed
            //string value;

            Console.Write("Guess the word: ");
            return(Console.ReadLine());
        }
    }
}

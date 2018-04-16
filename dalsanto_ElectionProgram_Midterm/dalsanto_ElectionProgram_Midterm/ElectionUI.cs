using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_ElectionProgram_Midterm
{
    class ElectionUI
    {
        //Matthew Dal Santo
        //ITDEV115
        //Mid-Term

        Election theElection = new Election();

        //"Then DisplayResults will loop through the array displaying the
        //Name  Votes   Percentage
        //Lastly the Winner is Displayed"
        private void DisplayResults()
        {
            Console.Clear();
            Console.WriteLine("\tName\tVotes\tPercentage");
            Console.WriteLine("___________________________________________________\n");
            for (int i = 0; i < theElection.NumberofCandiates; i++)
            {
                Console.WriteLine("\t{0}\t{1}\t{2:N1}%",
                    theElection.GetCandidateName(i),
                    theElection.GetCandidateVotes(i),
                    (((double)theElection.GetCandidateVotes(i) / (double)theElection.TotalVotes()) * 100));
            }
            Console.WriteLine("\nThe winner is {0}", theElection.FindWinner());
            Console.ReadKey();
        }

        //"MainMethod will PromptForString and PromptForInt for
        //each Candidate name and votes."
        public void MainMethod()
        {
            for (int i = 0; i < theElection.NumberofCandiates; i++)
            {
                PromptforString(i);
                PromptforInt(i);
            }

            DisplayResults();
        }

        //Instructions said to call the method PromptForInt, UML dictated PromptforInt.
        //Was unsure which would be desired so defaulted to UML.
        private void PromptforInt(int i)
        {
            //Example app did not invalidate negative numbers, so they are allowed in validation.
            int tempInt = 0;
            Console.Write("Please enter {0}'s vote count: ", theElection.GetCandidateName(i));
            while (!Int32.TryParse(Console.ReadLine(), out tempInt)) {
                Console.WriteLine("Error in input.  Please enter an integer.");
                Console.Write("Please enter {0}'s vote count: ", theElection.GetCandidateName(i));
            }
            theElection.SetVotes(tempInt, i);
        }

        //Instructions said to call the method PromptForString, UML dictated PromptforString.
        //Was unsure which would be desired so defaulted to UML.
        private void PromptforString(int i)
        {
            Console.Write("\nplease enter candiate {0}'s name: ", (i + 1));
            theElection.SetCandidateName(Console.ReadLine(), i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_ElectionProgram_Midterm
{
    class Election
    {
        //Matthew Dal Santo
        //ITDEV115
        //Mid-Term

        //Instructions said to call the variable candidatesNames, UML dictated candidates.
        //Was unsure which would be desired so defaulted to UML.
        private string[] candidates = new string[NUMCANDIATES];

        //Spelled as it was displayed in the UML.
        //"(5 names are fine)."
        private const int NUMCANDIATES = 5;
        //"The ElectionUI class will need the NUMOFCANDIDATES so use a property to
        //return the value of the constant."
        public int NumberofCandiates
        {
            get { return NUMCANDIATES; }
        }

        private int[] votes = new int[NUMCANDIATES];

        //"FindWinner will loop through the array of votes and returns the
        //winner of the election."
        public String FindWinner()
        {
            int tempIndex = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                //Example program does not account for ties so they were not checked
                //and the lowest index is favored as was determined from testing the
                //example program.
                if (votes[tempIndex] < votes[i]) { tempIndex = i; }
            }

            return candidates[tempIndex];
        }

        //"return the name of the candidate."
        public String GetCandidateName(int index)
        {
            return candidates[index];
        }

        //"returns the votes for that candidate."
        public int GetCandidateVotes(int index)
        {
            return votes[index];
        }

        //"will set the name in the internal array."
        public void SetCandidateName(string values, int index)
        {
            candidates[index] = values;
        }

        //Instructions said to call the method GetCandidateVotes, UML dictated SetVotes.
        //Was unsure which would be desired so defaulted to UML.
        //"SetCandidateVotes(int votes, int index) will set the votes for each candidate."
        //Could not use the votes naming convention as dictated in the instructions as it
        //conflicted with an already created array dictated by the UML.  For the program
        //to function properly it had to be named differently than the instructions
        //dictated.
        public void SetVotes(int numberVotes, int index)
        {
            votes[index] = numberVotes;
        }

        //"TotalVotes returns the sum of the votes"
        public int TotalVotes()
        {
            return votes.Sum();
        }
    }
}

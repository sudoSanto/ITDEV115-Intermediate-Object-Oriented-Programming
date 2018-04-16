using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbleApp
{
    class Jumble
    {
        Random rnd = new Random();

        private string[] arrayWord = { "mineral", "leopard", "housecat", "exams", "teacher", "prosperity", "mississippi" ,
            "germany", "airplane", "frangelico" };

        private char[] displayWord;
        public char[] DisplayWord { get { return displayWord; } set { displayWord = value; } }

        private string hiddenWord;
        public string HiddenWord { get { return hiddenWord; } set { hiddenWord = value; } }

        public Jumble() { GenerateRandomNumber(); }

        public Boolean CompareResult(string guess)
        {
            if (guess.ToLower() == hiddenWord) return true;
            else return false;
        }

        public void GenerateRandomNumber()
        {
            hiddenWord = arrayWord[rnd.Next(0, 10)];
        }

        public void ScrambleWord()
        {
            int tempInt;
            char tempChar;
            Random randIndex = new Random();

            displayWord = new char[hiddenWord.Length];

            for (int i = 0; i < hiddenWord.Length; i++)
            {
                do
                {
                    tempInt = randIndex.Next(0, hiddenWord.Length);
                } while (displayWord[tempInt] != 0);

                tempChar = hiddenWord[i];
                displayWord[tempInt] = tempChar;
            }
        }
    }
}

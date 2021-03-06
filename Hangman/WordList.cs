using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class WordList
    {
        public string randomWord()
        {
            string[] listwords = new string[3];
            listwords[0] = "car";
            listwords[1] = "happy";
            listwords[2] = "boy";

            Random wordRand = new Random();
            var exo = wordRand.Next(0, 3);
            string wordToGuess = listwords[exo];

            return wordToGuess;

        }

        public char[] stringToCharArray(string word)
        {
            char[] guess = new char[word.Length];

            for (int s = 0; s < word.Length; s++)
                guess[s] = '-';

            return guess;
        }

        public char[] searchReplaceChar(char[] guess, char guessChar, string wordToGuess)
        {
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                //  entered char is found on wordToGuess
                if (guessChar == wordToGuess[i])
                {
                    guess[i] = guessChar;
                }
            }

            return guess;
        }

    }

}

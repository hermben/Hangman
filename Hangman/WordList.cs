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
       
     }

}

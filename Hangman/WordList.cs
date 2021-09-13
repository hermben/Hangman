using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class WordList
    {
        string[] listwords = new string[10];
        listwords[0] = "beautiful";
            listwords[1] = "happy";
            listwords[2] = "boy";

            Random wordRand = new Random(0, 2);
        var exo = wordRand.Next(0, 9);
        string wordToGuess = listwords[exo];
            char[]guess= new char[]

     }

}

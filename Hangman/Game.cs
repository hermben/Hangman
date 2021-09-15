using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        int numTurns;
        bool won;
        string wordToGuess;
        char[] guess;
        GameScreen screen = new GameScreen();

        public void init()
        {
            WordList wordList = new WordList();
            numTurns = 3;
            won = false;
            wordToGuess = wordList.randomWord();
            guess = wordList.stringToCharArray(wordToGuess);
        }

        public void start()
        {
            init();


            screen.displayWelcomeMessage();


            while (won == false && numTurns != 0)
            {
                char guessChar = screen.getUserChar(guess);

                var isCharfound = false;
                // Search and Replace - with character found 
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    //  entered char is found on wordToGuess
                    if (guessChar == wordToGuess[i])
                    {
                        guess[i] = guessChar;
                        isCharfound = true;
                    }
                }

                if (isCharfound == false)
                {
                    numTurns--;
                    screen.displayTurnsLeft(numTurns);
                }

                // verifies if user won
                won = true;
                for (int j = 0; j < guess.Length; j++)
                {
                    if (guess[j] == '-')
                    {
                        won = false;
                    }

                }

            }

            screen.displayResult(won);
        }

    }
}

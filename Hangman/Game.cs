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
        WordList wordList = new WordList();

        public void init()
        {
            numTurns = 3;
            won = false;
            wordToGuess = wordList.randomWord();
            guess = wordList.stringToCharArray(wordToGuess);
        }

        public void start()
        {
            this.init();
            screen.displayWelcomeMessage();

            while (won == false && numTurns != 0)
            {
                // Get a char from user input
                char guessChar = screen.getUserChar(guess);

                // WordToguess contains user entered char
                if (wordToGuess.Contains(guessChar))
                {
                    guess = wordList.searchReplaceChar(guess, guessChar, wordToGuess);
                } else
                {
                    numTurns--;
                    screen.displayTurnsLeft(numTurns);
                }

                //// verifies if user won
                won = this.hasPlayerWon();
            }

            screen.displayResult(won);
        }

        public bool hasPlayerWon()
        {
            // verifies if user won
            for (int j = 0; j < this.guess.Length; j++)
            {
                if (this.guess[j] == '-')
                {
                    return false;
                }
            }

            return true;
        }

    }
}

using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numTurns = 3;
            var won = false;
            WordList wordList = new WordList();
            string wordToGuess = wordList.randomWord();
            char[] guess = wordList.stringToCharArray(wordToGuess);
            GameScreen screen = new GameScreen();
            

            screen.displayWelcomeMessage();


            while (won == false && numTurns != 0 )
            {
                char guessChar =  screen.getUserChar(guess);

                var isCharfound = false; 
                // Search and Replace - with character found 
                for (int i =0; i< wordToGuess.Length; i++)
                {
                    // The entered char is found on wordToGuess
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
                for (int j = 0;j<guess.Length; j++)
                {
                    if (guess[j]== '-')
                    {
                        won = false;
                    }

                }

            }

            screen.displayResult(won);
        }
    }
}

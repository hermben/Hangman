using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman");
            
            var numTurns = 3;
            var won = false;
            WordList wordList = new WordList();
            string wordToGuess = wordList.randomWord();
            char[] guess = new char[wordToGuess.Length];

            for (int s = 0; s < wordToGuess.Length; s++)
                guess[s] = '-';

            while (won == false && numTurns != 0 )
            {
                Console.WriteLine(guess);
                Console.WriteLine("please enter a letter: ");


                char guessChar =Convert.ToChar( Console.ReadLine());
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
                    Console.WriteLine("Wrong character you have :" + numTurns );
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
            if (won == true)
            {
                Console.WriteLine("you have won");
            }else
            {
                Console.WriteLine("you have lost");
            }
        }
    }
}

using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecome to Hangman");
            string[] listwords = new string[3];
            listwords[0] = "car";
            listwords[1] = "happy";
            listwords[2] = "boy";

            var numTurns = 3;
            var won = false;
            Random wordRand = new Random();
            var exo = wordRand.Next(0, 3);
            string wordToGuess = listwords[exo];
            char[] guess = new char[wordToGuess.Length];

            Console.Write("Please enter your guess");

            for (int s = 0; s < wordToGuess.Length; s++)
                guess[s] = '-';

            while (won == false && numTurns != 0 )
            {
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
                Console.WriteLine(guess);
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

            Console.WriteLine("you have won");

        }
    }
}

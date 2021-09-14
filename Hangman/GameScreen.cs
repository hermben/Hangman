using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GameScreen
    {
        public void displayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Hangman");
        }

        public char getUserChar(char[] guess)
        {
            Console.WriteLine(guess);
            Console.WriteLine("please enter a letter: ");
            return Convert.ToChar(Console.ReadLine());
        }

        public void displayResult(bool won)
        {
            if (won == true)
            {
                Console.WriteLine("you have won");
            }
            else
            {
                Console.WriteLine("you have lost");
            }
        }

        public void displayTurnsLeft(int numTurns)
        {
            Console.WriteLine("Wrong character you have :" + numTurns + " turns left");
        }
    }
}

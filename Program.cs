using System;

namespace HigherLowerGame {

    class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Would you like to play the higher/lower game? (Yes/No)");
            string answerToPlayGame = Console.ReadLine();
            if (answerToPlayGame == "No" || answerToPlayGame == "no")
            {
                Console.WriteLine("Goodbye.");
            }

            Console.WriteLine("Okay.");

            HighLow newGame = new HighLow(0, 100);

            Console.WriteLine("Guess a number from 1 to 100. Don't tell anyone what it is.");

            int gameGuess = newGame.FindNextGuessRange();
            // Console.WriteLine(gameGuess);
            Console.WriteLine("Is your number higher or lower than " + gameGuess + "? (higher/lower/correct)");
            string userResponse = Console.ReadLine();

            while (userResponse == "higher" || userResponse == "lower" )
            {
                newGame.SetNewGuessRange(userResponse);
                gameGuess = newGame.FindNextGuessRange();

                Console.WriteLine("Is your number higher or lower than " + gameGuess + "? (higher/lower/correct)");
                userResponse = Console.ReadLine();
            }
            Console.WriteLine("I win!");
        }
    }
}

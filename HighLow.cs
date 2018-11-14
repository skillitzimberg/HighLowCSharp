using System;

namespace HigherLowerGame {

    class HighLow
    {
        private int GuessRangeLow;
        private int GuessRangeHigh;
        private int GameGuess;

        public HighLow(int guessRangeLow, int guessRangeHigh)
        {
            GuessRangeLow = guessRangeLow;
            GuessRangeHigh = guessRangeHigh;
        }

        public int FindNextGuessRange()
        {
            if((GuessRangeHigh - GuessRangeLow) % 2 == 0)
            {
                GameGuess = (GuessRangeHigh - GuessRangeLow) / 2 + GuessRangeLow;
            }
            else
            {
                GameGuess = ((GuessRangeHigh - GuessRangeLow) + 1) / 2 + GuessRangeLow;
            }
            return GameGuess;
        }

        public void SetNewGuessRange(string userResponse)
        {
            if (userResponse == "higher")
            {
                GuessRangeLow = GameGuess + 1;
            }
            else
            {
                GuessRangeHigh = GameGuess - 1;
            }
        }
    }
}

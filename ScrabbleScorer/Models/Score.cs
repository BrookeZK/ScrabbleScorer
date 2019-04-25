using System.Collections.Generic;

namespace ScrabbleScorer
{
    public class Score
    {
        private char _letter;
        private int _scoreValue = 0;
        private static Dictionary<char, int> _letterScores = new Dictionary<char, int>() { {'a', 1}, {'b', 2}, {'c', 2}, {'d', 2}, {'e', 1}, {'f', 4}, {'g', 2}, {'h', 4}, {'i', 1}, {'j', 8}, {'k', 5}, {'l', 1}, {'m', 2}, {'n', 1}, {'o', 1}, {'p', 2}, {'q', 10}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1}, {'v', 4}, {'w', 4}, {'x', 8}, {'y', 4}, {'z', 10} };

        public Score(char letter)
        {
            _letter = letter;
        }

        public static int GetCharValue(char charKey)
        {
            return _letterScores[charKey];
        }

        public char[] StringToCharArray(string inputWord)
        {
            char[] result = inputWord.ToCharArray();
            return result;
        }

    }
}

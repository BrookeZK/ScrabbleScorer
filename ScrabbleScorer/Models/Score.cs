using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScorer
{
    public class Score
    {
        private char _letter;
        private List<int> _wordValue = new List<int>();
        private static Dictionary<char, int> _letterScores = new Dictionary<char, int>() { {'a', 1}, {'b', 3}, {'c', 3}, {'d', 2}, {'e', 1}, {'f', 4}, {'g', 2}, {'h', 4}, {'i', 1}, {'j', 8}, {'k', 5}, {'l', 1}, {'m', 3}, {'n', 1}, {'o', 1}, {'p', 3}, {'q', 10}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1}, {'v', 4}, {'w', 4}, {'x', 8}, {'y', 4}, {'z', 10} };

        public Score(char letter)
        {
            _letter = letter;
        }

        public char GetLetter()
        {
            return _letter;
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

        public List<int> StoreValueForLetter(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                int keyValue = GetCharValue(charArray[i]);
                _wordValue.Add(keyValue);
            }
            return _wordValue;
        }

        public int Summands(List<int> wordValue)
        {
            int totalWordScore = wordValue.Sum();
            return totalWordScore;
        }
    }
}

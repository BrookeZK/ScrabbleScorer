using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ScrabbleScorer.Tests
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void ScoreConstructor_CreatesInstanceOfScore_Score()
        {
            // Arrange
            //Act
            Score newScore = new Score('a');
            //Assert
            Assert.AreEqual(typeof(Score),  newScore.GetType());
        }

        [TestMethod]
        public void GetLetter_RetrievesLetterPropertyOfScore_char()
        {
            // Arrange
            Score newScore = new Score('a');
            //Act
            char result = newScore.GetLetter();
            //Assert
            Assert.AreEqual('a' , result);
        }

        [TestMethod]
        public void GetCharValue_RetrievesDictionaryKeyValuePairs_int()
        {
            // Arrange
            Score newScore = new Score('q');
            //Act
            int result = Score.GetCharValue(newScore.GetLetter());
            //Assert
            Assert.AreEqual(10 , result);
        }

        [TestMethod]
        public void StringToCharArray_TurnsWordIntoCharArray_CharArray()
        {
            // Arrange
            Score newScore = new Score('a');
            string testString = "word";
            // Act
            char[] letterArray = newScore.StringToCharArray(testString);
            // Assert
            Assert.AreEqual('o', letterArray[1]);
        }

        [TestMethod]
        public void StoreValueForLetter_StoreCharValueInList_List()
        {
            // Arrange
            Score newScore = new Score('f');
            string testString = "word";
            char[] letterArray = newScore.StringToCharArray(testString);
            int result = Score.GetCharValue(letterArray[0]);
            int result1 = Score.GetCharValue(letterArray[1]);
            int result2 = Score.GetCharValue(letterArray[2]);
            int result3 = Score.GetCharValue(letterArray[3]);
            List<int> wordScore = new List<int> { result, result1, result2, result3 };
            // Act
            List<int> wordScore2 = newScore.StoreValueForLetter(letterArray);
            // Assert
            CollectionAssert.AreEqual(wordScore2, wordScore);
        }

        [TestMethod]
        public void Summands_TotalTheNumberOfValuesIntCharValueList_Int()
        {
            //Arrange
            Score newScore = new Score('f');
            List<int> wordScore = new List<int> { 1, 2, 3, 4 };
            int totalNum = wordScore.Sum();
            //Act
            int totalNum2 = newScore.Summands(wordScore);
            //Assert
            Assert.AreEqual(totalNum, totalNum2);
        }
    }
}

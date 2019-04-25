using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer;
using System.Collections.Generic;
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

            //Act
            int result = Score.GetCharValue('b');
            //Assert
            Assert.AreEqual(3 , result);
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
        public void FindValueOfChar_TakesCharKeyAndReturnsValueFromDic_int()
        {
            // Arrange
            Score newScore = new Score('q');
            // Act
            int result = newScore.FindValueOfChar(newScore.GetLetter());
            // Assert
            Assert.AreEqual(10, result);
        }
    }
}

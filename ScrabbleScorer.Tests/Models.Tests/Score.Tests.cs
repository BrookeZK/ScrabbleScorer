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
        public void GetDictionary_RetrievesDictionaryKeyValuePairs_int()
        {
            // Arrange

            //Act
            int result = Score.GetCharValue('b');
            //Assert
            Assert.AreEqual(2 , result);
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
    }
}

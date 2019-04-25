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
            // Score newScore = new Score('a');
            //Act
            int result = Score.GetCharValue('b');
            //Assert
            Assert.AreEqual(, result);
        }
    }
}

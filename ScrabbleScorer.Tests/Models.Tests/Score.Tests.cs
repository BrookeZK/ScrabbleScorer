using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer;
using System.Collections.Generic;

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
            Score newScore = new Score("word", 5);
            //Assert
            Assert.AreEqual(typeof(Score),  newScore.GetType());
        }

        // [TestMethod]
        // public void ReturnCharValue_TakesCharAndReturnsAValue_int()
        // {
        //
        // }
    }
}

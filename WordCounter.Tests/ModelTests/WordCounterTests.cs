using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void userStringToCounter_0Matches_0()
        {
            // arrange 
            string word = "dog";
            string sentence = "I am a cat";
            int count = 0;
            // Act
            int result = Calculation.userStringToCounter(word,sentence);
            // Assert
             Assert.AreEqual(count,result);
        }
        [TestMethod]
        public void userStringToCounter_1Match_1()
        {
            // Arrange 
            string word = "dog";
            string sentence = "I am a dog";
            int count = 1;
            // Act 
            int result = Calculation.userStringToCounter(word,sentence);
            // Assert
            Assert.AreEqual(count,result);
        }

        [TestMethod]
        public void userStringToCounter_1Matchlowercase_1()
        {
            // Arrange 
            string word = "dog";
            string sentence = "I am a Dog";
            int count = 1;
            // Act 
            int result = Calculation.userStringToCounter(word,sentence);
            // Asssert

            Assert.AreEqual(count ,result);
        }
        [TestMethod]
        public void userStringToCounter_noMatchForPartialWords_0()
        {
            //Arrange
             string word = "fire";
             string sentence = "I am a firefighter";
             int count = 0;
             // Act
             int result = Calculation.userStringToCounter(word,sentence);
             // Assert
            Assert.AreEqual(count,result);
        }
         [TestMethod]
        public void userStringToCounter_CheckForPunctiuationInWord_0()
        {
            //Arrange
            string word = "fi!re";
            string sentence = "I am on fire";
            int count = 0;
            // Act
            int result = Calculation.userStringToCounter(word,sentence);
            // Assert
            Assert.AreEqual(count,result);
        }

        

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void userInputToStringArray_0Matches()
        {
             Assert.AreEqual(Calculation.userInputToStringArray("dog","I am a cat"),0);
        }
        [TestMethod]
        public void userInputToStringArray_1Match()
        {
            Assert.AreEqual(Calculation.userInputToStringArray("dog","I am a dog"),1);
        }
    }
}
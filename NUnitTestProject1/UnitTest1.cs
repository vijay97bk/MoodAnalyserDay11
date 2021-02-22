using NUnit.Framework;
using MoodAnalyserDay11;

namespace NUnitTestProject1
{

    public class Tests
    {
        
        /// <summary>
        /// Givens the sad should return sad.
        /// </summary>
        [Test]
        
        public void Given_Sad_Should_return_Sad()
        {
            AnalyseMood analyseMood = new AnalyseMood("I am SAD");
            string actual;
            string Expected = "SAD";
            actual = analyseMood.MoodAnalyse();
            
            Assert.AreEqual(Expected, actual);
        }
        [Test]

        public void Given_HAPPY_Should_return_HAPPY()
        {
            AnalyseMood analyseMood = new AnalyseMood("I am HAPPY");
            string actual;
            string Expected = "HAPPY";
            actual = analyseMood.MoodAnalyse();

            Assert.AreEqual(Expected, actual);
        }
        [Test]

        public void Given_EMPTY_Should_return_EmptyMessage()
        {
            try
            {
                string message="";
                AnalyseMood analyseMood = new AnalyseMood(message);
                string mood = analyseMood.MoodAnalyse();
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual("mood Cannot be empty", ex.Message);
            }
        }
        [Test]

        public void Given_Null_Should_return_NullMessage()
        {
            try
            {
                string message = null;
                AnalyseMood analyseMood = new AnalyseMood(message);
                string mood = analyseMood.MoodAnalyse();
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual("mood Cannot be null", ex.Message);
            }
        }
    }
}
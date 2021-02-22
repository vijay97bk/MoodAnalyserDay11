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
            AnalyseMood analyseMood = new AnalyseMood("I am HAPPY");
            string actual;
            string Expected = "HAPPY";
            actual = analyseMood.MoodAnalyse();



            Assert.AreEqual(Expected, actual);
        }
    }
}
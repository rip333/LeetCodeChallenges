using LeetCode.Challenges.DecodeWays;
using NUnit.Framework;

namespace LeetCodeUnitTests.ChallengesTests
{
    [TestFixture]
    public class DecodeWaysTests
    {
        [Test]
        public void TestExample1()
        {
            Assert.AreEqual(2, DecodeWays.NumDecodings("12"));
        }
        
        [Test]
        public void TestExample2()
        {
            Assert.AreEqual(3, DecodeWays.NumDecodings("226"));
        }
        
        [Test]
        public void TestExample3()
        {
            Assert.AreEqual(0, DecodeWays.NumDecodings("0"));
        }
        
        [Test]
        public void TestExample4()
        {
            Assert.AreEqual(0, DecodeWays.NumDecodings("06"));
        }
    }
}
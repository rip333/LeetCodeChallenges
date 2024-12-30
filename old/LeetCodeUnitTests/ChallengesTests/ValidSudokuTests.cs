using LeetCodeAugust.Challenges.ValidSudoku;
using NUnit.Framework;

namespace LeetCodeUnitTests.ChallengesTests
{
    [TestFixture]
    public class ValidSudokuTests
    {
        private ValidSudoku _validSudoku = new ValidSudoku();
        private char[][] _board;

        [Test]
        public void TestExample1()
        {
            _board = new []
            {
                new[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new [] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new [] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new [] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new [] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new [] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new [] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new [] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new [] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}

            };

            var response = _validSudoku.IsValidSudoku(_board);
            Assert.True(response);
        }
        
        [Test]
        public void TestExample2()
        {
            _board = new []
            {
                new [] {'8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new [] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new [] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new [] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new [] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new [] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new [] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new [] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new [] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}

            };

            var response = _validSudoku.IsValidSudoku(_board);
            Assert.False(response);
        }
    }
}
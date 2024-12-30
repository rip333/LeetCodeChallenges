using LeetCodeAugust.Challenges.MakingALargeIsland;
using NUnit.Framework;

namespace LeetCodeUnitTests.ChallengesTests
{
    [TestFixture]
    public class MakingALargeIslandTests
    {
        private int[][] grid;
        private MakingALargeIsland _makingALargeIsland = new MakingALargeIsland();
        
        [Test]
        public void TestExample1()
        {
            grid = new int[2][];
            grid[0] = new [] {1, 0};
            grid[1] = new [] {0, 1};

            var result = _makingALargeIsland.LargestIsland(grid);
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void TestExample2()
        {
            grid = new int[2][];
            grid[0] = new [] {1, 1};
            grid[1] = new [] {1, 0};

            var result = _makingALargeIsland.LargestIsland(grid);
            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void TestExample3()
        {
            grid = new int[2][];
            grid[0] = new [] {1, 1};
            grid[1] = new [] {1, 1};

            var result = _makingALargeIsland.LargestIsland(grid);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestExample4()
        {
            /**
            /[[0,0,0,0,0,0,0],
            / [0,1,1,1,1,0,0],
            / [1,0,1,0,1,0,0],
            / [0,1,0,0,1,0,0],
            / [0,1,0,0,1,0,0],
            / [0,1,1,1,1,0,0]]
            **/
            
            grid = new int[7][];
            grid[0] = new[] {0, 0, 0, 0, 0, 0, 0};
            grid[1] = new[] {0, 1, 1, 1, 1, 0, 0};
            grid[2] = new[] {0, 1, 0, 0, 1, 0, 0};
            grid[3] = new[] {1, 0, 1, 0, 1, 0, 0};
            grid[4] = new[] {0, 1, 0, 0, 1, 0, 0};
            grid[5] = new[] {0, 1, 0, 0, 1, 0, 0};
            grid[6] = new[] {0, 1, 1, 1, 1, 0, 0};
            
            var result = _makingALargeIsland.LargestIsland(grid);
            Assert.AreEqual(18, result);
        }

        [Test]
        public void TestExample5()
        {
            grid = new int[3][];
            grid[0] = new[] {1, 0, 1};
            grid[1] = new[] {0, 0, 0};
            grid[2] = new[] {0, 1, 1};

            var result = _makingALargeIsland.LargestIsland(grid);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestExample6()
        {
            //[[1,0,1,0,1],[0,1,1,0,1],[1,1,1,0,0],[1,0,1,1,1],[0,0,1,1,0]]
            grid = new int[5][];
            grid[0] = new[] {1, 0, 1, 0, 1};
            grid[1] = new[] {0, 1, 1, 0, 1};
            grid[2] = new[] {1, 1, 1, 0, 0};
            grid[3] = new[] {1, 0, 1, 1, 1};
            grid[4] = new[] {0, 0, 1, 1, 0};

            var result = _makingALargeIsland.LargestIsland(grid);
            Assert.AreEqual(15, result);
        }
    }
}
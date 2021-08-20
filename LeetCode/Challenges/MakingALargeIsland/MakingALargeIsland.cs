using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeAugust.Challenges.MakingALargeIsland
{
    
    /**
     * https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/613/week-1-august-1st-august-7th/3835/
     */
    public class MakingALargeIsland
    {
        public int LargestIsland(int[][] grid)
        {
            var largestIslandSize = BiggestIsland(grid);

            for (var i = 0; i < grid[0].Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 1) continue;

                    grid[i][j] = 1;
                    var biggestIslandSizeOfNewGrid = BiggestIsland(grid);
                    
                    if (biggestIslandSizeOfNewGrid > largestIslandSize)
                    {
                        largestIslandSize = biggestIslandSizeOfNewGrid;
                    }

                    grid[i][j] = 0;
                }
            }

            return largestIslandSize;
        }

        private int BiggestIsland(int[][] grid)
        {
            var islands = new List<Island>();

            for (var i = 0; i < grid[0].Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        Island currentIsland;
                        if (!islands.Any(island => island.DoesIslandContainCoordinates(i, j)))
                        {
                            currentIsland = new Island(i, j);
                            islands.Add(currentIsland);
                        }
                        else
                        {
                            currentIsland = islands.Find(r => r.DoesIslandContainCoordinates(i, j));
                        }

                        if (i + 1 != grid.Length && grid[i + 1][j] == 1 && !currentIsland.DoesIslandContainCoordinates(i+1, j) 
                            && !islands.Any(island => island.DoesIslandContainCoordinates(i+1, j)))
                        {
                            currentIsland.AddChild(new Island(i + 1, j));
                        }

                        if (j + 1 != grid[i].Length && grid[i][j + 1] == 1 && !currentIsland.DoesIslandContainCoordinates(i, j+1)
                            && !islands.Any(island => island.DoesIslandContainCoordinates(i, j+1)))
                        {
                            currentIsland.AddChild(new Island(i, j + 1));
                        }
                    }
                }
            }
            
            //combine adjacent islands
            for (var i = 0; i < islands.Count; i++)
            {
                var islandA = islands[i];
                if (i + 1 >= islands.Count) continue;
                for (var j = i + 1; j < islands.Count; j++)
                {
                    var islandB = islands[j];
                    if (!islandA.IsIslandAdjacent(islandB)) continue;
                    islandA.MergeIsland(islandB);
                    islands.RemoveAt(j);
                }
            }

            return islands.Select(island => island.Children.Count + 1).Concat(new[] {0}).Max();
        }
        private class Island
        {
            public int X, Y;
            public List<Island> Children = new List<Island>();

            public Island(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void AddChild(Island child)
            {
                if (Children.Any(r => r.X == child.X && r.Y == child.Y))
                {
                    return;
                }
                Children.Add(child);
            }

            public bool DoesIslandContainCoordinates(int x, int y)
            {
                if (x == X && y == Y)
                {
                    return true;
                }

                return Children.Any(island => island.DoesIslandContainCoordinates(x, y));
            }

            public bool IsIslandAdjacent(Island islandB)
            {
                if (AreCoordinateAdjacentOrEqual(X, Y, islandB.X, islandB.Y))
                {
                    return true;
                }

                if (islandB.Children.Any(island => IsIslandAdjacent(island)))
                {
                    return true;
                }

                return Children.Any(island => island.IsIslandAdjacent(islandB));
            }

            private bool AreCoordinateAdjacentOrEqual(int a0, int a1, int b0, int b1)
            {
                if (a0 == b0 && a1 == b1)
                {
                    return true;
                }
                if (a0 == b0 && Math.Abs(a1 - b1) == 1)
                {
                    return true;
                }
                return a1 == b1 && Math.Abs(a0 - b0) == 1;
            }

            public void MergeIsland(Island islandB)
            {
                var newIsland = new Island(islandB.X, islandB.Y);
                Children.Add(newIsland);
                foreach (var island in islandB.Children)
                {
                    AddChild(island);
                }
            }
        }
    }
}
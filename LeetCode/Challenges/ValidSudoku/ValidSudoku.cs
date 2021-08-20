using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeAugust.Challenges.ValidSudoku
{
    //https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/615/week-3-august-15th-august-21st/3904/
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            //validate 9x9 size
            if (board.Length != 9 || board.Any(x => x.Length != 9))
            {
                return false;
            }
            
            //validate columns
            if (board.Any(column => !IsGroupValid(column)))
            {
                return false;
            }
            
            //calculate and validate rows
            for (var i = 0; i < 9; i++)
            {
                var row = board.Select(x => x[i]).ToArray();
                if (!IsGroupValid(row))
                {
                    return false;
                }
            }

            //setup boxes and validate
            for (var i = 0; i < 9; i += 3)
            {
                for (var j = 0; j < 9; j += 3)
                {
                    var innerMatrix = new List<char>();
                     for (var k = 0; k < 3; k++)
                     {
                         for (var m = 0; m < 3; m++)
                         {
                             var value = board[i + k][j + m];
                             if (value != '.')
                             {
                                 innerMatrix.Add(value);
                             }
                         }
                     }

                     if (!IsGroupValid(innerMatrix.ToArray()))
                     {
                         return false;
                     }
                }
            }

            return true;
        }

        private bool IsGroupValid(char[] group)
        {
            var list = group.Where(x => x != '.').Select(x => int.Parse(x.ToString())).ToList();

            //check for invalid numbers
            if (list.Any(number => number < 1 || number > 9))
            {
                return false;
            }
            
            //check for duplicates
            for (var i = 1; i < 10; i++)
            {
                if (!list.Contains(i)) continue;
                if (list.Count(x => x == i) > 1)
                    return false;
            }

            return true;
        }
    }
}
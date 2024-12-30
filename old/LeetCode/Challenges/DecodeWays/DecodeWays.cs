using System;
using System.Collections.Generic;

namespace LeetCode.Challenges.DecodeWays
{
    /**
     * August 18
     * https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/615/week-3-august-15th-august-21st/3902/
     */
    
    public class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            var input = s;
            if (input.Length == 0 || input.Substring(0, 1) == "0")
            {
                return 0;
            }

            if (input.Length == 1)
            {
                return 1;
            }

            var numDecodings = 0;
            var firstInt = input.Substring(0, 1);
            var secondInt = input.Substring(1, 1);
            
            if (firstInt == "1")
            {
                numDecodings++;
                numDecodings += NumDecodings(input.Substring(1));
                numDecodings += NumDecodings(input.Substring(2));
            } 
            else if (firstInt == "2" && int.Parse(secondInt) < 7)
            {
                numDecodings++;
                numDecodings += NumDecodings(input.Substring(1));
                numDecodings += NumDecodings(input.Substring(2));
            }
            return numDecodings; 
        }
        
        

        public static readonly Dictionary<string, char> Encoding = new Dictionary<string, char>()
        {
            { "1" , 'A'},
            { "2" , 'B'},
            { "3" , 'C'},
            { "4" , 'D'},
            { "5" , 'E'},
            { "6" , 'F'},
            { "7" , 'G'},
            { "8" , 'H'},
            { "9" , 'I'},
            { "10", 'J'},
            { "11", 'K'},
            { "12", 'L'},
            { "13", 'M'},
            { "14", 'N'},
            { "15", 'O'},
            { "16", 'P'},
            { "17", 'Q'},
            { "18", 'R'},
            { "19", 'S'},
            { "20", 'T'},
            { "21", 'U'},
            { "22", 'V'},
            { "23", 'W'},
            { "24", 'X'},
            { "25", 'Y'},
            { "26", 'Z'},
        };
    }
}
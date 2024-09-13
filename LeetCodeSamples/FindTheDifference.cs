﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    /*
     * You are given two strings s and t.
     * String t is generated by random shuffling string s and then add one more letter at a random position.
     * Return the letter that was added to t.
     * 
     * Example 1:
     * Input: s = "abcd", t = "abcde"
     * Output: "e"
     * Explanation: 'e' is the letter that was added.
     * 
     * Example 2:
     * Input: s = "", t = "y"
     * Output: "y"
     * 
     * Constraints:
     * 0 <= s.length <= 1000
     * t.length == s.length + 1
     * s and t consist of lowercase English letters.
     */

    internal class FindTheDifference
    {
        public char FindTheLetterDifference(string s, string t)
        {
            //var addedLetter = '\0';    // Default Value of char is '\0' which indicates 'Null'

            if (s.Length >= 0 && s.Length <= 1000 && (t.Length == s.Length + 1))
            {
                List<char> list1 = new List<char>(s);
                List<char> list2 = new List<char>(t);

                foreach (char c in list2)
                {
                    if (!list1.Contains(c))
                    {
                        return c;
                    }
                    list1.Remove(c);
                }
            }
            return '\0';                        
        }
    }
}

/*
 * Output:
 * -------
 * Difference in abcd & abcde is e
 * Difference in '' & y is y
 * Difference in abcd & abcde is a
 */

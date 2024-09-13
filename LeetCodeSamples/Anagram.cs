using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    /*
     * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
     * typically using all the original letters exactly once.
     * 
     * Example 1:
     * Input: s = "anagram", t = "nagaram"
     * Output: true
     * 
     * Example 2:
     * Input: s = "rat", t = "car"
     * Output: false
     * 
     * Constraints:
     * 1 <= s.length, t.length <= 5 * 104
     * s and t consist of lowercase English letters.
     * 
     */
    internal class Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            if (s.Length >= 1 && t.Length <= 5 *(Math.Pow(10, 4)))
            {
               return String.Concat(s.OrderBy(c => c)) == String.Concat(t.OrderBy(c => c));                
            }

            return false;
        }

        public bool IsAnagramWithForEach(string s, string t)
        {
            bool isAnagram = true;

            if (s.Length != t.Length)
            {
                isAnagram = false;
                return isAnagram;
            }

            if (s.Length >= 1 && t.Length <= 5 * (Math.Pow(10, 4)))
            {
                // To do: The characters in both strings must be the same and appear the same number of times.

                foreach (char c in t)
                {
                    if (!s.Any(cc => cc == c))
                    {
                        isAnagram = false;
                        break;
                    }
                }
            }

            return isAnagram;
        }

    }
}
/* Output:
 * -------
 * 'anagram & nagaram' are Anagram: True
 * 'rat & car' are Anagram: False
 * 'ab & a' are Anagram: False
 * 'aacc & ccac' are Anagram: False
 * 
 */

/*
 * Anagram:
 * -------
 * An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
 * typically using all the original letters exactly once. 
 * For instance, the word "listen" is an anagram of "silent," and "evil" is an anagram of "vile." 
 * The key characteristic of an anagram is that both the original word and the resulting word must use the same letters in the same frequency.
 * 
 * Here are some important points about anagrams:
 * 
 * 1. Same Characters and Frequency: The characters in both strings must be the same and appear the same number of times.
 * 
 * 2. Case Sensitivity: Anagrams are typically case-sensitive, so "Listen" is not considered an anagram of "Silent" 
 * unless you convert both strings to the same case.
 * 
 * 3. Ignoring Spaces and Punctuation: In phrases, spaces and punctuation are usually ignored. 
 * For example, "A decimal point" is an anagram of "I'm a dot in place."
 * 
 * Example of Anagrams
 * 1. "Dormitory" and "Dirty room"
 * 2. "The eyes" and "They see"
 * 3. "Astronomer" and "Moon starer"
 * 
 */
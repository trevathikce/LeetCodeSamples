using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class LengthOfLastWord
    {
        public int GetLengthOfLastWord(string s)
        {
            int lengthOfLastWord = 0;

            if (string.IsNullOrEmpty(s))
                return lengthOfLastWord;

            s = Regex.Replace(s.Trim(), " +", " ");

            string[] words = s.Split(' ');
            string lastWord = words[words.Length - 1];

            lengthOfLastWord = lastWord.Trim().Length;

            return lengthOfLastWord;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class RepeatedSubstring
    {
        public bool RepeatedSubstringPattern(string s)
        {
            string a = s + s;
            string b = a.Substring(1, a.Length - 2);
            if (b.Contains(s))
            {
                return true;
            }
            return false;
        }
    }
}

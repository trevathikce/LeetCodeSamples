using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class ToLowerCase
    {
        public string ConvertToLowerCase(string s)
        {
            if (string.IsNullOrEmpty(s) )
                return string.Empty;

            return s.ToLower();
        }
    }
}

/*
 * Output
 * 
 * To Lower Case
 * -------------
 * Hello: hello
 * here: here
 * LOVELY: lovely
 * 
 */

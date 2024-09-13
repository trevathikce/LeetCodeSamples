using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int integer = 0;
            char currentRomanChar = '\0';
            int currentNumber = 0;
            int prevValue = 0;

            if (string.IsNullOrEmpty(s))
                return integer;

            s = s.ToUpper();

            Hashtable romanToNumberMap = new Hashtable{
                {'I', 1},
                {'V', 5},
                {'X', 10 },
                {'L', 50},
                {'C', 100},
                {'D', 500 },
                {'M', 1000 }
            };

            // Process each character in the string from right to left
            for (int index = s.Length -1; index >=0 ; index--)
            {
                currentRomanChar = s[index];

                //if (romanToNumberMap.ContainsKey(currentRomanChar))
                //{
                //    currentNumber = (int)(romanToNumberMap[currentRomanChar]);

                //    if (index >0 && currentNumber < (int)romanToNumberMap[s[index-1]])   // i.e., Current Value is less than Previous Value
                //    {
                //        integer -= currentNumber;
                //    }
                //    else
                //    {
                //        integer += currentNumber;
                //    }
                //}
                if (romanToNumberMap.ContainsKey(currentRomanChar))
                {
                    currentNumber = (int)(romanToNumberMap[currentRomanChar]);

                    if (currentNumber < prevValue)   // i.e., Current Value is less than Previous Value
                    {
                        integer -= currentNumber;
                    }
                    else
                    {
                        integer += currentNumber;
                    }
                    // Update the previous value
                    prevValue = currentNumber;
                }
                else
                {
                    throw new ArgumentException("Invalid Roman Character.");
                }
            }

            return integer;
        }
    }
}

/*
 * Output:
 * 
 * Roman To Integer
 * ----------------
 * III: 3
 * LVIII: 58
 * MCMXCIV: 1994
 * 
 */
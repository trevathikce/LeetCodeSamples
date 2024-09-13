using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class PlusOne
    {
        public int[] GetDigitsPlusOne(int[] digits)
        {
            if (digits.Length >= 1 && digits.Length <= 100 && digits.All(i => i >= 0 && i <= 9))
            {
                string arrayInteger = string.Empty;
                digits.ToList().ForEach(i=>
                {
                    arrayInteger += i.ToString();
                });
                //long integerDigits;   // For Int64
                BigInteger.TryParse(arrayInteger, out BigInteger integerDigits);
                int[] result = Array.ConvertAll((integerDigits + 1).ToString().ToArray(), c => (int)Char.GetNumericValue(c));
                return result;
            }
            return null;
        }
    }
}

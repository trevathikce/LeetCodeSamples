using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class SignOfProductOfAnArray
    {
        public int ArraySign(int[] nums)
        {
            BigInteger productOfArray = 1;
            nums.ToList().ForEach(x =>
            {
                productOfArray *= x;
            });
            return productOfArray.Sign;
        }
    }
}

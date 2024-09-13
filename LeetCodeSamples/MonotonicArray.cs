using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class MonotonicArray
    {
        public bool IsMonotonic(int[] nums)
        {
            if (nums.ToList().Zip(nums.Skip(1), (curr, next) => curr <= next).All(x => x))  // Is Ascending Array
            {
                for (int index = 1; index < nums.Length; index++)
                {
                    if (!(nums[index - 1] <= nums[index]))
                    {
                        return false;
                    }
                    
                }
            }
            else if(nums.ToList().Zip(nums.Skip(1), (curr, next) => curr >= next).All(x => x))   //  Is Descending Array
            {
                for (int index = 1; index < nums.Length; index++)
                {
                    if (!(nums[index - 1] >= nums[index]))
                    {
                        return false;
                    }
                }
            }
            else    // No Ascending and No Descending
            {
                return false;
            } 
                
            return true;
        }
    }
}

/*
 * Output
 * -------
 * Is '1,2,2,3' Monotonic Array: True
 * Is '6,5,4,4' Monotonic Array: True
 * Is '1,3,2' Monotonic Array: False
 */
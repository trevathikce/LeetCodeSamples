using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class MoveZeros
    {
        public int[] MoveZeroesToEnd(int[] nums)
        {
            List<int> numsList = new List<int>();
            numsList.AddRange(nums);          

            int numberOfZeros = numsList.Where(i => i == 0).Count();
            numsList.RemoveAll(i => i == 0);

            #region Method 1
            //for (int index = 0; index < numberOfZeros; index++)
            //{
            //    numsList.Add(0);
            //}

            //nums = numsList.ToArray();

            #endregion

            #region Method 2

            //nums = numsList.ToArray();

            //for (int index = 0; index < numberOfZeros; index++)
            //{
            //    nums = nums.Concat(new int[] { 0 }).ToArray();
            //    //nums = nums.Append(0).ToArray();
            //}

            #endregion

            #region Method 3

            // Resize the original array
            nums = new int[numsList.Count + numberOfZeros];

            // Copy non-zero elements back to the array
            numsList.CopyTo(nums);

            // Fill the remaining positions with zeros
            for (int i = numsList.Count; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            #endregion

            #region Method 4 - using Onli I/P Variable and no list is used

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            #endregion

            return nums;            
        }
    }
}

/* Output:
 * -------
 * '0, 1, 0, 3, 12' On Moving Zeroes to the End: 1, 3, 12, 0, 0
 * '0' On Moving Zeroes to the End: 0
 */
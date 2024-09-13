using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class ArithmeticProgression
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            bool isAscendingArrayAP = true;
            bool isDescendingArrayAP = true;

            int[] ascendingOrderedArray = arr.OrderBy(x => x).ToArray();
            int[] descendingOrderedArray = arr.OrderByDescending(x => x).ToArray();

            int ascendingCommonDifference = ascendingOrderedArray[1] - ascendingOrderedArray[0];
            int descendingCommonDifference = descendingOrderedArray[1] - descendingOrderedArray[0];

            for (int index = 2; index < ascendingOrderedArray.Length; index++)
            {
                if (ascendingOrderedArray[index] - ascendingOrderedArray[index - 1] != ascendingCommonDifference)
                {
                    isAscendingArrayAP = false;
                }
            }

            for (int index = 2; index < descendingOrderedArray.Length; index++)
            {
                if (descendingOrderedArray[index] - descendingOrderedArray[index - 1] != descendingCommonDifference)
                {
                    isDescendingArrayAP = false;
                }
            }

            return (isAscendingArrayAP && isDescendingArrayAP);
        }
    }
}

/*
 * Output:
 * -------
 * Arithmetic Progression of '3,5,1' is: True
 * Arithmetic Progression of '1,2,4' is: False
 */

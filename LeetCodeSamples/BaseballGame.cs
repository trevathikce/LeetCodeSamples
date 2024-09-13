using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class BaseballGame
    {
        public int CalculatePoints(string[] operations)
        {
            int sum = 0; 
            int[] record = new int[operations.Length];
            int score = 0;
            foreach (var operation in operations)
            {
                if (int.TryParse(operation, out score))
                {
                    record = record.Append(score).ToArray();
                }
                else if (operation == "+" && record.Length > 0)
                {
                    score = record[record.Length - 1] + record[record.Length - 2];
                    record = record.Append(score).ToArray();
                }
                else if (operation == "D" && record.Length > 0)
                {
                    score = 2* record[record.Length - 1];
                    record = record.Append(score).ToArray();
                }
                else if(operation == "C" && record.Length > 0  )
                {
                    //record = record.Take(record.Length-1).ToArray();
                    Array.Resize(ref record, record.Length -1);     // 'Array.Resize' is faster than 'Take()'
                }
            }

            if(record.Length > 0)
            {
                sum = record.Sum(x => x);
            }
            
            return sum;
        }
    }
}

/*
 * Output
 * 
 * Baseball Game
 * -------------
 * Sum of the scores '"5","2","C","D","+"': 30
 * Sum of the scores '"5","-2","4","C","D","9","+","+"': 27
 * Sum of the scores '"1","C"': 0
 * 
 */
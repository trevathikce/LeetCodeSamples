using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            bool isReturnedToOrigin = true;
            List<char> movesList = new List<char>(moves);
            Dictionary<string, int> totalMoves = new Dictionary<string, int>();

            int countD = movesList.Select(x => x == 'D').Count();
            int countU = movesList.Select(x => x == 'U').Count();
            int countR = movesList.Select(x => x == 'R').Count();
            int countL = movesList.Select(x => x == 'L').Count();

            foreach (char move in movesList)
            {
                if (move == 'U')
                {
                    if (totalMoves.ContainsKey("D"))
                    {
                        totalMoves.Remove("D");
                    }
                    else if (totalMoves.ContainsKey("U"))
                    {
                        totalMoves["U"]++;
                    }
                    else
                    {
                        totalMoves.Add("U", 1);
                    }
                }
                else if (move == 'D')
                {
                    if (totalMoves.ContainsKey("U"))
                    {
                        totalMoves.Remove("U");
                    }
                    else if (totalMoves.ContainsKey("D"))
                    {
                        totalMoves["D"]++;
                    }
                    else
                    {
                        totalMoves.Add("D", 1);
                    }
                }
                else if (move == 'L')
                {
                    if (totalMoves.ContainsKey("R"))
                    {
                        totalMoves.Remove("R");
                    }
                    else if (totalMoves.ContainsKey("L"))
                    {
                        totalMoves["L"]++;
                    }
                    else
                    {
                        totalMoves.Add("L", 1);
                    }
                }
                else if (move == 'R')
                {
                    if (totalMoves.ContainsKey("L"))
                    {
                        totalMoves.Remove("L");
                    }
                    else if (totalMoves.ContainsKey("R"))
                    {
                        totalMoves["R"]++;
                    }
                    else
                    {
                        totalMoves.Add("R", 1);
                    }
                }
            }
            if (totalMoves.Count > 0)
            {
                isReturnedToOrigin = false;
            }
            return isReturnedToOrigin;
        }
    }
}

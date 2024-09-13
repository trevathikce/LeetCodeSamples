using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MergeStrings
            /*
            MergeStrings _mergeStrings = new MergeStrings();
            Console.WriteLine("abc & def = " + _mergeStrings.MergeStringsAlternatively("abc", "def"));
            Console.WriteLine("abcd & efg = " + _mergeStrings.MergeStringsAlternatively("abcd", "efg"));
            Console.WriteLine("abc & defgh = " + _mergeStrings.MergeStringsAlternatively("abc", "defgh"));
            */

            #endregion

            #region Find the Difference

            //FindTheDifference findTheDifference = new FindTheDifference();
            //Console.WriteLine("Difference in abcd & abcde is " + findTheDifference.FindTheLetterDifference("abcd", "abcde"));
            //Console.WriteLine("Difference in '' & y is " + findTheDifference.FindTheLetterDifference("", "y"));
            //Console.WriteLine("Difference in abcd & abcde is " + findTheDifference.FindTheLetterDifference("a", "aa"));

            #endregion

            #region Index of First Occurance

            //IndexOfFirstOccurance indexOfFirstOccurance = new IndexOfFirstOccurance();
            //Console.WriteLine("Index of the First Occurance of 'sadbutsad' in 'sad' is " + indexOfFirstOccurance.IndexOfFirstOccuranceString("sadbutsad", "sad"));
            //Console.WriteLine("Index of the First Occurance of 'leetcode' in 'leeto' is " + indexOfFirstOccurance.IndexOfFirstOccuranceString("leetcode", "leeto"));

            #endregion

            #region Is Anagram

            //Anagram anagram = new Anagram();
            //Console.WriteLine("'anagram & nagaram' are Anagram: " + anagram.IsAnagram("anagram", "nagaram"));
            //Console.WriteLine("'rat & car' are Anagram: " + anagram.IsAnagram("rat", "car"));
            //Console.WriteLine("'ab & a' are Anagram: " + anagram.IsAnagram("ab", "a"));
            //Console.WriteLine("'aacc & ccac' are Anagram: " + anagram.IsAnagram("aacc", "ccac"));

            #endregion

            #region Repeated Substring Pattern

            //RepeatedSubstring repeatedSubstring = new RepeatedSubstring();
            //Console.WriteLine("Is 'abcaabcaabcaabca' Repeated Substring Pattern? " + repeatedSubstring.RepeatedSubstringPattern("abcaabcaabcaabca"));
            //Console.WriteLine("Is 'abcabcabcabc' Repeated Substring Pattern? " + repeatedSubstring.RepeatedSubstringPattern("abcabcabcabc"));
            //Console.WriteLine("Is 'abab' Repeated Substring Pattern? " + repeatedSubstring.RepeatedSubstringPattern("abab"));
            //Console.WriteLine("Is 'aba' Repeated Substring Pattern? " + repeatedSubstring.RepeatedSubstringPattern("aba"));

            #endregion

            #region Move Zeroes to the End

            //MoveZeros moveZeros = new MoveZeros();
            //Console.WriteLine("'0, 1, 0, 3, 12' On Moving Zeroes to the End: " + string.Join(", ", moveZeros.MoveZeroesToEnd(new int[] { 0, 1, 0, 3, 12 } )));
            //Console.WriteLine("'0' On Moving Zeroes to the End: " + string.Join(", ", moveZeros.MoveZeroesToEnd(new int[] { 0})));

            #endregion

            #region Largest Integer Plus One

            //PlusOne plusOne = new PlusOne();
            //Console.WriteLine("Plus One of '1,2,3' is: ");
            //Console.WriteLine(string.Join(Environment.NewLine, plusOne.GetDigitsPlusOne(new int[] { 1, 2, 3 }).Select(i => i)));

            //Console.WriteLine("Plus One of '4,3,2,1' is: ");
            //Console.WriteLine(string.Join(Environment.NewLine, plusOne.GetDigitsPlusOne(new int[] { 4, 3, 2, 1 }).Select(i => i.ToString())));

            //Console.WriteLine("Plus One of '9' is: ");
            //Console.WriteLine(string.Join(Environment.NewLine, plusOne.GetDigitsPlusOne(new int[] { 9 }).Select(i => i)));

            //Console.WriteLine("Plus One of '9,8,7,6,5,4,3,2,1,0' is: ");
            //Console.WriteLine(string.Join("", plusOne.GetDigitsPlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }).Select(i => i)));

            //Console.WriteLine("Plus One of '7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6' is: ");
            //Console.WriteLine(string.Join("", plusOne.GetDigitsPlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 }).Select(i => i)));


            #endregion

            #region Sign of the Product of an Array

            //SignOfProductOfAnArray signOfProductOfAnArray  = new SignOfProductOfAnArray();
            //Console.WriteLine(" Sign of the Product of an Array '-1,-2,-3,-4,3,2,1' is: " + signOfProductOfAnArray.ArraySign(new int[] { -1, -2, -3, -4, 3, 2, 1 }));
            //Console.WriteLine(" Sign of the Product of an Array '1,5,0,2,-3' is: " + signOfProductOfAnArray.ArraySign(new int[] { 1, 5, 0, 2, -3 }));
            //Console.WriteLine(" Sign of the Product of an Array '-1,1,-1,1,-1' is: " + signOfProductOfAnArray.ArraySign(new int[] { -1, 1, -1, 1, -1 }));

            //Console.WriteLine("Plus One of '41,65,14,80,20,10,55,58,24,56,28,86,96,10,3,84,4,41,13,32,42,43,83,78,82,70,15,-41' is: ");
            //Console.WriteLine(string.Join("", signOfProductOfAnArray.ArraySign(new int[] { 41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41 })));

            #endregion

            #region Can Make Arithmetic Progression from Sequence

            //ArithmeticProgression arithmeticProgression = new ArithmeticProgression();
            //Console.WriteLine("Arithmetic Progression of '3,5,1' is: " + arithmeticProgression.CanMakeArithmeticProgression(new int[] { 3, 5, 1 }));
            //Console.WriteLine("Arithmetic Progression of '1,2,4' is: " + arithmeticProgression.CanMakeArithmeticProgression(new int[] { 1, 2, 4 }));           

            #endregion

            #region Is Monotonic Array

            //MonotonicArray monotonicArray = new MonotonicArray();
            //Console.WriteLine("Is '1,2,2,3' Monotonic Array: " + monotonicArray.IsMonotonic(new int[] { 1, 2, 2, 3 }));
            //Console.WriteLine("Is '6,5,4,4' Monotonic Array: " + monotonicArray.IsMonotonic(new int[] { 6, 5, 4, 4 }));
            //Console.WriteLine("Is '1,3,2' Monotonic Array: " + monotonicArray.IsMonotonic(new int[] { 1, 3, 2 }));

            #endregion

            #region Roman To Integer

            //RomanToInteger romanToInteger = new RomanToInteger();
            //Console.WriteLine("Roman To Integer");
            //Console.WriteLine("----------------");
            //Console.WriteLine();
            //Console.WriteLine("III: " + romanToInteger.RomanToInt("III"));
            //Console.WriteLine("LVIII: " + romanToInteger.RomanToInt("LVIII"));
            //Console.WriteLine("MCMXCIV: " + romanToInteger.RomanToInt("MCMXCIV"));

            #endregion

            #region Length of Last Word

            //LengthOfLastWord lengthOfLastWord = new LengthOfLastWord();
            //Console.WriteLine("Length of Last Word");
            //Console.WriteLine("-------------------");
            //Console.WriteLine();
            //Console.WriteLine("'Hello World': " + lengthOfLastWord.GetLengthOfLastWord("Hello World"));
            //Console.WriteLine("'   fly me   to   the moon  ': " + lengthOfLastWord.GetLengthOfLastWord("   fly me   to   the moon  "));
            //Console.WriteLine("'luffy is still joyboy': " + lengthOfLastWord.GetLengthOfLastWord("luffy is still joyboy"));

            #endregion

            #region Convert to Lower Case

            //ToLowerCase toLowerCase = new ToLowerCase();
            //Console.WriteLine("To Lower Case");
            //Console.WriteLine("-------------");
            //Console.WriteLine();
            //Console.WriteLine("Hello: " + toLowerCase.ConvertToLowerCase("Hello"));
            //Console.WriteLine("here: " + toLowerCase.ConvertToLowerCase("here"));
            //Console.WriteLine("LOVELY: " + toLowerCase.ConvertToLowerCase("LOVELY"));

            #endregion

            #region Baseball Game

            //BaseballGame baseballGame = new BaseballGame();
            //Console.WriteLine("Baseball Game");
            //Console.WriteLine("-------------");

            //Console.WriteLine("Sum of the scores '\"5\",\"2\",\"C\",\"D\",\"+\"': " + baseballGame.CalculatePoints(new string[] { "5", "2", "C", "D", "+" }));
            //Console.WriteLine("Sum of the scores '\"5\",\"-2\",\"4\",\"C\",\"D\",\"9\",\"+\",\"+\"': " + baseballGame.CalculatePoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }));
            //Console.WriteLine("Sum of the scores '\"1\",\"C\"': " + baseballGame.CalculatePoints(new string[] { "1", "C" }));

            #endregion

            #region Robot Return to Origin

            RobotReturnToOrigin robotReturnToOrigin = new RobotReturnToOrigin();
            Console.WriteLine("Robot Return to Origin");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("'UD' Is Robot Return to Origin: " + robotReturnToOrigin.JudgeCircle("UD"));
            Console.WriteLine("'LL' Is Robot Return to Origin: " + robotReturnToOrigin.JudgeCircle("LL"));
            Console.WriteLine("'DRLLDLLRURLURULLLRULLRLULLLDDUDLUUUDLLDLDRLDRURDURRLRDLDRDLDDURDUURLLUUURLDRLUULUUDRDRUDURLLRDRRDLDU' Is Robot Return to Origin: \n"
                + robotReturnToOrigin.JudgeCircle("DRLLDLLRURLURULLLRULLRLULLLDDUDLUUUDLLDLDRLDRURDURRLRDLDRDLDDURDUURLLUUURLDRLUULUUDRDRUDURLLRDRRDLDU"));
            

            #endregion


            Console.ReadLine();
        }
    }
}

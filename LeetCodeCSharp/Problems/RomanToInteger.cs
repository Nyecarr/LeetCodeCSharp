using System.Collections.Generic;

namespace LeetCodeCSharp.Problems
{
  public class RomanToInteger
  {
    // Problem 13 - Roman to Integer
    // https://leetcode.com/problems/roman-to-integer/submissions/1
    private static Dictionary<char, int> numeralsToInteger = new Dictionary<char, int> {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
      };

    public int RomanToInt(string s)
    {
      var result = 0;

      for (int i = 0; i < s.Length - 1; i++)
      {
        // Check to see if our current value is less than the next, if so, subtract that from our result
        // this is to catch cases like IV, IX, XL, etc
        if (numeralsToInteger[s[i]] < numeralsToInteger[s[i + 1]])
        {
          result -= numeralsToInteger[s[i]];
        }
        else
        {
          result += numeralsToInteger[s[i]];
        }
      }

      // We need to also get the final character as the for will stop at the second to last character
      return result + numeralsToInteger[s[s.Length - 1]];
    }
  }
}

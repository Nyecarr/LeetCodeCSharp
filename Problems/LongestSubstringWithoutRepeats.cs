using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems
{
  // Problem 3 - Longest Substring Without Repeating Characters
  // https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
  public class LongestSubstringWithoutRepeats
  {
    public int LengthOfLongestSubstring(string s)
    {
      // Sliding window implementation, O(n) time
      var seenCharacters = new Dictionary<char, int>();
      var maxLengthSoFar = 0;
      var start = 0;

      for (var end = 0; end < s.Length; end++)
      {
        if (seenCharacters.ContainsKey(s[end]))
        {
          start = Math.Max(start, seenCharacters[s[end]] + 1);
          seenCharacters[s[end]] = end;
        }
        else
        {
          seenCharacters.Add(s[end], end);
        }

        maxLengthSoFar = Math.Max(maxLengthSoFar, end - start + 1);
      }

      return maxLengthSoFar;
    }
  }
}

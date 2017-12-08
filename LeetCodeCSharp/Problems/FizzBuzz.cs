using System.Collections.Generic;

namespace LeetCodeCSharp.Problems
{
  public class FizzBuzz
  {
    // Problem 412 - Fizz Buzz
    // https://leetcode.com/problems/fizz-buzz/description/
    // 
    // Could use a rules pattern if you worried about maintainability
    public IList<string> Do(int n)
    {
      var results = new List<string>();

      for (int i = 1; i <= n; i++)
      {
        var result = string.Empty;

        if (i % 3 == 0)
          result += "Fizz";

        if (i % 5 == 0)
          result += "Buzz";

        if (string.IsNullOrEmpty(result))
          result = i.ToString();

        results.Add(result);
      }

      return results;
    }
  }
}

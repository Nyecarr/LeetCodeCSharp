using System.Text;

namespace LeetCodeCSharp.Problems
{
  // Problem 344 - Reverse String
  // https://leetcode.com/problems/reverse-string/description/
  public class ReverseString
  {
    public string Reverse(string s)
    {
      var stringBuilder = new StringBuilder();

      for(int i = s.Length - 1; i >= 0; i--)
      {
        stringBuilder.Append(s[i]);
      }

      return stringBuilder.ToString();
    }
  }
}

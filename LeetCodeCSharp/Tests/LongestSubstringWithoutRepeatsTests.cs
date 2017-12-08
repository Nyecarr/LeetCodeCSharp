using LeetCodeCSharp.Problems;
using NUnit.Framework;

namespace LeetCodeCSharp.Tests
{
  [TestFixture]
  public class LongestSubstringWithoutRepeatsTests
  {
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    public void LengthOfLongestSubstring(string testString, int expectedLength)
    {
      var longestSubstring = new LongestSubstringWithoutRepeats();

      Assert.That(longestSubstring.LengthOfLongestSubstring(testString), Is.EqualTo(expectedLength));
    }
  }
}

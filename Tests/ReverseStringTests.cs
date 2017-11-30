using LeetCodeCSharp.Problems;
using NUnit.Framework;

namespace LeetCodeCSharp.Tests
{
  [TestFixture]
  public class ReverseStringTests
  {
    [TestCase("", "")]
    [TestCase("hello", "olleh")]
    [TestCase("helloWorld", "dlroWolleh")]
    public void ReverseString_Reverse_SimpleTestsCases(string input, string expected)
    {
      var reverseString = new ReverseString();
      Assert.That(reverseString.Reverse(input), Is.EqualTo(expected));
    }
  }
}

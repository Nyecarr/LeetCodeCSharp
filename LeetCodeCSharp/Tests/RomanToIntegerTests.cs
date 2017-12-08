using LeetCodeCSharp.Problems;
using NUnit.Framework;

namespace LeetCodeCSharp.Tests
{
  [TestFixture]
  public class RomanToIntegerTests
  {
    [TestCase("I", 1)]
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("V", 5)]
    [TestCase("VI", 6)]
    [TestCase("X", 10)]
    [TestCase("XI", 11)]
    [TestCase("XV", 15)]
    public void RomanToInt_MultipleRomanNumerals_ReturnsExpectedInteger(string romanNumeral, int expected)
    {
      var romanToInteger = new RomanToInteger();

      Assert.That(romanToInteger.RomanToInt(romanNumeral), Is.EqualTo(expected));
    }
  }
}

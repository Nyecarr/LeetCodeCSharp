using LeetCodeCSharp.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeCSharp.Tests
{
  [TestFixture]
  public class FizzBuzzTests
  {
    [Test]
    public void FizzBuzz_15_ReturnsExpectedList()
    {
      var fizzBuzz = new FizzBuzz();

      var results = fizzBuzz.Do(15);

      for (int i = 0; i < 15; i++)
      {
        Assert.That(results[i] == expectedList[i], $"Expected {expectedList[i]} but was {results[i]}.");
      }
    }

    private List<string> expectedList = new List<string>
      {
        "1",
        "2",
        "Fizz",
        "4",
        "Buzz",
        "Fizz",
        "7",
        "8",
        "Fizz",
        "Buzz",
        "11",
        "Fizz",
        "13",
        "14",
        "FizzBuzz"
      };
  }
}

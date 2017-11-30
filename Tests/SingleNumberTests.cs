using LeetCodeCSharp.Problems;
using NUnit.Framework;
using System;

namespace LeetCodeCSharp.Tests
{
  [TestFixture]
  public class SingleNumberTests
  {
    [Test]
    public void SingleNumber_GetNumber_ReturnsExpectedNumber()
    {
      var nums = new[] { 1, 1, 2, 2, 3, 4, 4 };

      var singleNumber = new SingleNumber();

      Assert.That(singleNumber.GetNumber(nums), Is.EqualTo(3));
    }

    [Test]
    public void SingleNumber_GetNumberEdge_ReturnsExpectedNumber()
    {
      var nums = new[] { 2, 2, 1 };

      var singleNumber = new SingleNumber();

      Assert.That(singleNumber.GetNumber(nums), Is.EqualTo(1));
    }

    [Test]
    public void SingleNumber_OneNumberInList_ReturnsThatNumber()
    {
      var nums = new[] { 1 };

      var singleNumber = new SingleNumber();

      Assert.That(singleNumber.GetNumber(nums), Is.EqualTo(1));
    }

    [Test]
    public void SingleNumber_AllNumbersHaveAPair_InvalidOperationExceptionIsThrown()
    {
      var nums = new[] { 1, 1, 2, 2 };

      var singleNumber = new SingleNumber();

      Assert.That(() => singleNumber.GetNumber(nums), Throws.TypeOf<InvalidOperationException>());
    }
  }
}

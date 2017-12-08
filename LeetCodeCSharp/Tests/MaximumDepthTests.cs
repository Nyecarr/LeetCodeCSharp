using LeetCodeCSharp.DataStructures;
using LeetCodeCSharp.Problems;
using NUnit.Framework;

namespace LeetCodeCSharp.Tests
{
  [TestFixture]
  public class MaximumDepthTests
  {
    [Test]
    public void MaxDepth_NullRoot_ReturnsZero()
    {
      TreeNode root = null;

      var maximumDepth = new MaximumDepth();

      Assert.That(maximumDepth.MaxDepth(root), Is.EqualTo(0));
    }

    [Test]
    public void MaxDepth_OnlyRoot_ReturnsOne()
    {
      TreeNode root = new TreeNode(1);

      var maximumDepth = new MaximumDepth();

      Assert.That(maximumDepth.MaxDepth(root), Is.EqualTo(1));
    }

    [Test]
    public void MaxDepth_TreeWithDepthOfThree_ReturnsThree()
    {
      var root = new TreeNode(1, new TreeNode(2, new TreeNode(3, null, null), null), null);

      var maximumDepth = new MaximumDepth();

      Assert.That(maximumDepth.MaxDepth(root), Is.EqualTo(3));
    }
  }
}

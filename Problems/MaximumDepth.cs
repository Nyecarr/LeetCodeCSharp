using LeetCodeCSharp.DataStructures;
using System;

namespace LeetCodeCSharp.Problems
{
  // Problem 104 - Maximum Depth of Binary Tree
  // https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
  public class MaximumDepth
  {
    public int MaxDepth(TreeNode root)
    {
      if (root == null)
        return 0;

      return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
  }
}

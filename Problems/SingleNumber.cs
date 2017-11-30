using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp.Problems
{
  // Problem 136 - Single Number
  // https://leetcode.com/problems/single-number/description/
  public class SingleNumber
  {
    // Linear time, linear space - this could probably be improved with some math wizardry
    public int GetNumber(int[] nums)
    {
      if (nums.Length == 1)
        return nums.First();

      var dict = new Dictionary<int, int>();

      for (int i = 0; i < nums.Length; i++)
      {
        if (!dict.ContainsKey(nums[i]))
        {
          dict.Add(nums[i], 1);
        }
        else
        {
          dict[nums[i]]++;
        }
      }

      return dict.First(v => v.Value == 1).Key;
    }

    public int GetNumber_NLogNTime_ConstantSpace(int[] nums)
    {
      if (nums.Length == 1)
        return nums.First();

      nums = nums.OrderBy(n => n).ToArray();

      for (int i = 0; i < nums.Length - 1; i += 2)
      {
        if (nums[i] != nums[i + 1])
          return nums[i];
      }

      throw new InvalidOperationException("Each integer appears twice in the input array.");
    }
  }
}

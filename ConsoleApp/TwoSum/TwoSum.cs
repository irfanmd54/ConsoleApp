// <copyright file="TwoSum.cs" company="Microsoft">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
// <author>FAREAST\irmohamm</author>
// <date>9/24/2021 12:08:24 PM</date>
// <summary>TwoSum.cs</summary>

namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="TwoSum" />.
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// The TwoSumArray.
        /// </summary>
        /// <param name="nums">The nums<see cref="int[]"/>.</param>
        /// <param name="target">The target<see cref="int"/>.</param>
        /// <returns>The <see cref="int[]"/>.</returns>
        public int[] TwoSumArray(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Contains(target - nums[i]) && Array.FindIndex(nums, val => val.Equals(target - nums[i])) != i)
                {
                    output[0] = i;
                    output[1] = Array.FindIndex(nums, val => val.Equals(target - nums[i]));

                    return output;
                }
            }

            return output;
        }

        /// <summary>
        /// The TwoSumHashMap.
        /// </summary>
        /// <param name="nums">The nums<see cref="int[]"/>.</param>
        /// <param name="target">The target<see cref="int"/>.</param>
        /// <returns>The <see cref="int[]"/>.</returns>
        public int[] TwoSumHashMap(int[] nums, int target)
        {
            int[] output = new int[2];
            Dictionary<int, int> input = new Dictionary<int, int>();
            int i = 0;
            foreach (var number in nums)
            {
                input.Add(i++, number);
            }

            nums = new int[nums.Length];

            foreach (var number in input)
            {
                if (input.ContainsValue(target - number.Value))
                {
                    output[0] = number.Key;
                    output[1] = input.First(x => x.Value == target - number.Value).Key;
                }
            }

            return output;
        }
    }
}

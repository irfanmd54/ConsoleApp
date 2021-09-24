using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class TwoSum
    {
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

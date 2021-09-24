using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region
            // Two Sum
            int[] nums1 = { 2, 7, 11, 15 };
            int target = 9;
            int[] output1 = new TwoSum().TwoSumHashMap(nums1, target);
            #endregion


            #region
            int[] nums2 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> output2 = new ThreeSum().ThreeSumHashMap(nums2);
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Arrays
{
    class Sum
    {
        static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            Dictionary<int, int> kp = new Dictionary<int, int>();
            for(int i=0; i< nums.Length; i++)
            {
                if (kp.ContainsKey(target - nums[i]))
                {
                    result = new int[] { kp[target - nums[i]], i };
                    break;
                }else if (!kp.ContainsKey(nums[i]))
                {
                    kp.Add(nums[i], i);
                }
            }
            return result;
        }

        // Two Pointer for a sorted array
        static int[] TwoSumSorted(int[] nums, int target)
        {
            var result = new int[2];
            var high = nums.Length - 1;
            var low = 0;
            while(low < high)
            {
                if (nums[high] + nums[low] == target)
                    return new int[2] { low, high };
                else if (nums[high] + nums[low] < target)
                    low++;
                else high--;
            }
            return result;
        }
    }
}

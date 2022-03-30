using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Arrays
{
    public class SubArraySum
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            var dict = new Dictionary<int, int> { { 0, -1 } };
            int prefix = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prefix += nums[i];
                int mod = prefix % k;
                if (!dict.ContainsKey(mod))
                    dict[mod] = i;
                else if (i - dict[mod] != 1)
                    return true;
            }
            return false;
        }

        public bool CheckSubarraySumHash(int[] nums, int k)
        {
            var set = new HashSet<int>();
            int prefix = 0, prevRem = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prefix += nums[i];
                int mod = prefix % k;
                if (set.Contains(mod)) return true;
                set.Add(prevRem);
                prevRem = mod;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Arrays
{
    class FirstMissing
    {
        public static int Positive(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    int next = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = next;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != (i + 1))
                    return i + 1;
            }
            return n + 1;
        }
    }
}

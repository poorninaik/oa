using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Arrays
{
    static class FirstMissing
    {
        private static int Positive(int[] nums)
        {
            var n = nums.Length;
            for (var i = 0; i < n; i++)
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                    (nums[nums[i] - 1], nums[i]) = (nums[i], nums[nums[i] - 1]);
                
            for (var i = 0; i < n; i++)
            {
                if (nums[i] != (i + 1))
                    return i + 1;
            }
            return n + 1;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(Positive(new int[]{}));

            Console.WriteLine(Positive(new int[]{
                1,2,8,3,5,7,9, 10
            }));

            Console.WriteLine(Positive(new int[]{
                8, 10
            }));
        }
    }
}

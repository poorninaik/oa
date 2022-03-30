using System;
using oa.Arrays;
using oa.Strings;

namespace oa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 23, 2, 4, 6, 7 };
            int target = 6;
            Console.WriteLine(SubArraySum.CheckSubarraySum(nums, target));
        }
    }
}

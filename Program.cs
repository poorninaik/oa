using System;
using oa.Arrays;
using oa.Strings;

namespace oa
{
    class Program
    {
        void Main(string[] args)
        {
            int[] nums = { 23, 2, 4, 6, 7 };
            int target = 6;
            var arr = new int[][] { new int[]{20, 15, 1}, new int[] { 20, 17, 0}, 
                new int[] { 50, 20, 1}, new int[] { 50, 80, 0}, new int[] { 80, 19, 1} };
            //Console.WriteLine(SubArraySum.CheckSubarraySum(nums, target));
            Console.WriteLine(Trees.same.CreateBT(arr));
        }
    }
}

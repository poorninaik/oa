using System;

namespace oa.BinarySearch;

public class Search
{
    private void Main()
    {
        int[] arr1 = { 1,2,3,14,16,40};
        Console.Write(BinarySearchR(arr1, 14, 0, arr1.Length));
    }
    private int BinarySearch(int[] nums, int t)
    {
        var result = -1;
        var lo = 0;
        var hi = nums.Length;
        while (lo < hi)
        {
            var mid = lo + (hi + lo) / 2;
            if (nums[mid] == t)
                return mid;
            else if (nums[mid] < t)
                hi = mid - 1;
            else lo = mid + 1;
        }
        return result;
    }

    private int BinarySearchR(int[] nums, int t, int lo, int hi)
    {
        var mid = lo + (hi - lo) / 2;
        if (nums[mid] == t)
            return mid;
        else if (nums[mid] < t)
            return BinarySearchR(nums, t, lo, mid - 1);
        else return BinarySearchR(nums, t, mid + 1, hi);
        
    }
}
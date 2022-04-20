using System;

/*1523. Count Odd Numbers in an Interval Range
Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).

Example 1:
Input: low = 3, high = 7
Output: 3
Explanation: The odd numbers between 3 and 7 are [3,5,7].

Example 2:
Input: low = 8, high = 10
Output: 1
Explanation: The odd numbers between 8 and 10 are [9].

Constraints: 0 <= low <= high <= 10^9*/
namespace oa.Arrays
{
    public static class OddNumbersInRange
    {
        //brute force T:O(n)
        private static int CountOddsBf(int low, int high) {
            int i = low, count=0;
        
            while(i<=high){
                if(i%2==1)
                    count++;
                i++;
            }
            return count;
        }
        
        //T:O(1)
        private static int CountOdds(int low, int high)
        {
            return (high - low) / 2 + (high % 2 | low % 2);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(CountOdds(3, 7));

            Console.WriteLine(CountOdds(7, 1000));

            Console.WriteLine(CountOddsBf(8, 10));
        }
    }
}
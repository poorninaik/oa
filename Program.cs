using System;
using oa.Arrays;
using oa.Matrix;
using oa.Stack;
using oa.Strings;

namespace oa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BasicCalculator.Solve("add(1,add(2,5))"));
            Console.WriteLine(BasicCalculator.Solve("add(subtract(9,1),add(2,5))"));
            Console.WriteLine(BasicCalculator.Solve("add(add(5,6),subtract(add(2,3),add(subtract(5,1),4)))"));
            Console.WriteLine(BasicCalculator.Solve("45"));
            int[] nums = { 23, 2, 4, 6, 7 };
            int target = 6;
            var arr = new int[][] { new int[]{20, 15, 1}, new int[] { 20, 17, 0}, 
                new int[] { 50, 20, 1}, new int[] { 50, 80, 0}, new int[] { 80, 19, 1} };
            /*var t1 = new int[][]
               {
                    new int[]{0,1}, new int[] {1,0}
               };
            var t2 = new int[][]
            {
                    new int[]{0,0,0}, new int[] {1,1,0}, new int[] {1,1,0}
            };
            var t3 = new int[][]
              {
                        new int[]{1,0,0}, new int[] {1,1,0}, new int[] {1,1,0}
              };
            Console.WriteLine(ShortestPath.BinaryMatrix(t1));
            Console.WriteLine(ShortestPath.BinaryMatrix(t2));
            Console.WriteLine(ShortestPath.BinaryMatrix(t3));*/
        }
    }
}

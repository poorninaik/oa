using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Matrix
{
    class ShortestPath
    {
      /*  class Program
        {
            public void Main(string[] args)
            {
                var t1 = new int[][]
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
                var s = new ShortestPath();
                Console.WriteLine(s.BinaryMatrix(t1));
                Console.WriteLine(s.BinaryMatrix(t2));
                Console.WriteLine(s.BinaryMatrix(t3));
            }
        }*/
        public static int BinaryMatrix(int[][] grid)
        {
            if (grid[0][0] == 1)
                return -1;

            int n = grid.Length;

            var queue = new Queue<(int X, int Y, int Path)>();

            queue.Enqueue((0, 0, 1));//first cell
            grid[0][0] = -1;//visited

            while (queue.Count > 0) 
            {
                var cur = queue.Dequeue();

                if (cur.X == n - 1 && cur.Y == n - 1)
                    return cur.Path;

                for (int i = -1; i <= 1; ++i)
                {
                    for (int j = -1; j <= 1; ++j)
                    {
                        int row = cur.X + i;
                        int col = cur.Y + j;
                        if (row < 0 || col < 0 || row >= n || col >= n || grid[row][col] != 0)
                            continue;

                        queue.Enqueue((row, col, cur.Path + 1));
                        grid[row][col] = -1;
                    }
                }
            }

            return -1;
        }
    }
}

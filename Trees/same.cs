using System.Collections.Generic;

namespace oa.Trees
{
    class same
    {
        public bool SameTree(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            if (node1 == null || node2 == null || node1.val != node2.val)
                return false;
            return SameTree(node1.left, node2.left) && SameTree(node1.right, node2.right);
        }
        public static TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var map = new Dictionary<int, TreeNode>();
            var children = new HashSet<int>();
            foreach (int[] arr in descriptions)
            {
                var pa = arr[0];
                var ch = arr[1];
                var l = arr[2];
                children.Add(ch);

                var node = new TreeNode(pa);
                if (map.ContainsKey(pa))
                    node = map[pa];
                if (l == 1)
                {
                    node.left = new TreeNode(ch);
                    if (!map.ContainsKey(ch))
                        map.Add(ch, node.left);
                    else
                        map[ch] = node.left;

                }
                else
                {
                    node.right = new TreeNode(ch);
                    if (!map.ContainsKey(ch))
                        map.Add(ch, node.right);
                    else
                        map[ch] = node.right;
                }
               
                if (!map.ContainsKey(pa))
                    map.Add(pa, node);
                else
                    map[pa] = node;

            }
            var root = -1;
            foreach (int[] arr in descriptions)
            {
                if (!children.Contains(arr[0]))
                {
                    root = arr[0];
                    break;
                }
            }
            return map[root];
        }

        public static TreeNode CreateBT(int[][] descriptions)
        {
            Dictionary<int, TreeNode> map = new Dictionary<int, TreeNode>();
            int n = descriptions.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += descriptions[i][1];
                int c = descriptions[i][1];
                int p = descriptions[i][0];
                if (!map.ContainsKey(c)) map.Add(c, new TreeNode(c));
                if (!map.ContainsKey(p)) map.Add(p, new TreeNode(p));
                if (descriptions[i][2] == 1) map[p].left = map[c];
                else map[p].right = map[c];
            }
            int msum = 0;
            foreach (int key in map.Keys)
            {
                msum += key;
            }
            return map[msum - sum];
        }
    }
}

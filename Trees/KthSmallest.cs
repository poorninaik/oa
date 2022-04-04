using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Trees
{
    class KthSmallest
    {
        public int InBST(TreeNode root, int k)
        {
            var stack = new LinkedList<TreeNode>();

            while (true)
            {
                while (root != null)
                {
                    stack.AddLast(root);
                    root = root.left;
                }
                root = stack.Last();
                stack.RemoveLast();
                if (--k == 0) return root.val;
                root = root.right;
            }
        }
    }
}

namespace oa.Trees
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }
    }
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
    }
}

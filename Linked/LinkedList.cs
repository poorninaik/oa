using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Linked
{
    public class Node
    {
        int val;
        Node next;
        public Node(int _val, Node _next=null)
        {
            val = _val;
            next = _next;
        }

    }
    class LinkedList
    {
        static Node CreateList(int[] nums)
        {
            Node head = null;
            for(int i =0; i<nums.Length; i++)
            {
                head = new Node(nums[i], head);
            }
            return head;
        }
    }
}

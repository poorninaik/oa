using System;
/*
namespace oa.Linked
{
    public class ReverseParts
    {
        
    }
    
    public class Node {
        public int data;
        public Node next;
        public Node(int _data, Node _next=null){
            data = _data;
            next = _next;
        }
        public static Node Reverse(Node head){
            Node current = head, prev=null, next =null;
            while(current !=null){
                next = current.next;
                current.next = prev;
                prev = next;
                current = next;
            }
            return head;
        }
    }

    public class Program{
        public static void Main(string[] args){
            var list = new Node(5);
            list.next = new Node(6);
            list.next.next = new Node(7);
            var rev = Node.Reverse(list);
            while(rev !=null){
                Console.WriteLine(rev.data);
                rev = rev.next;
            }
        }
    }
}*/
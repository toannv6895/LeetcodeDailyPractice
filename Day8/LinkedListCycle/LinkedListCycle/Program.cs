using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(3);
            ListNode listNode1 = new ListNode(2);
            ListNode listNode2 = new ListNode(0);
            ListNode listNode3 = new ListNode(-4);
            listNode.next = listNode1;
            listNode1.next = listNode2;
            listNode2.next = listNode3;
            listNode3.next = listNode1;

            Console.WriteLine(HasCycle(listNode));
            Console.ReadKey();
        }

        public static bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            if (head.next == null)
            {
                return false;
            }

            ListNode l = head;
            ListNode r = head?.next;

            while (l != null && r != null) 
            {
                if (l == r)
                {
                    return true;
                }

                l = l?.next;
                r = r?.next?.next;
            }

            return false;
        }

    }

     public class ListNode
     {
          public int val;
          public ListNode next;
          public ListNode(int x)
          {
            val = x;
            next = null;
          }
     }
}

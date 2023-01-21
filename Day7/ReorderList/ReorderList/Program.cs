using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReorderList
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void ReorderList(ListNode head)
        {
            ListNode node1 = head.next;
            ListNode node2 = node1.next;
            ListNode last = null;
            ListNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            last = temp.next;
            temp.next = null;
            node1.next = last;
            last.next = node2;
        }
    }

    public class ListNode
    {
          public int val;
          public ListNode next;
          public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
         }
     }

}

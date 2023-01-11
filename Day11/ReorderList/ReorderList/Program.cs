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
            ListNode listNode = new ListNode(1);
            ListNode listNode1 = new ListNode(2);
            ListNode listNode2 = new ListNode(3);
            ListNode listNode3 = new ListNode(4);
            ListNode listNode4 = new ListNode(5);
            listNode.next = listNode1;
            listNode1.next = listNode2;
            listNode2.next = listNode3;
            listNode3.next = listNode4;

            //ListNode listNode = new ListNode(1);
            //ListNode listNode1 = new ListNode(2);
            //listNode.next = listNode1;

            ReorderList(listNode);
            Console.WriteLine(listNode);
            Console.ReadKey();
        }

        public static void ReorderList(ListNode head)
        {
            // Tách node ra thành 2 node
            ListNode slow = head;
            ListNode fast = slow.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode head1 = head;
            ListNode head2 = slow.next;
            slow.next = null;

            //Revert node list
            head2 = RevertList(head2);

            //Reorder
            head = new ListNode(0);

            // Bài toán quay trở lại thành merge 2 node theo thứ tự head1 -> head2
            ListNode curr = head;
            while (head1 != null || head2 != null)
            {
                if (head1 != null)
                {
                    curr.next = head1;
                    curr = curr.next;
                    head1 = head1.next;
                }

                if (head2 != null)
                {
                    curr.next = head2;
                    curr = curr.next;
                    head2 = head2.next;
                }
            }

            head = head.next;
        }

        public static ListNode RevertList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode nex = null;

            while (curr != null)
            {
                nex = curr.next;
                curr.next = prev;
                prev = curr;
                curr= nex;
            }
            head = prev;
            return head;
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

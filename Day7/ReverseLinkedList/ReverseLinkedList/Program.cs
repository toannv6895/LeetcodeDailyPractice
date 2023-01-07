using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            ListNode listNode = new ListNode();
            ListNode listNode1 = new ListNode();
            ListNode listNode2 = new ListNode();
            ListNode listNode3 = new ListNode();
            ListNode listNode4 = new ListNode();
            listNode.val = 1;
            listNode1.val = 2;
            listNode2.val = 3;
            listNode3.val = 4;
            listNode4.val = 5;
            listNode.next= listNode1;
            listNode1.next= listNode2;
            listNode2.next= listNode3;
            listNode3.next= listNode4;

            ReverseList(listNode);
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode nextNode = null;
            ListNode prevNode = null;

            while (head.next != null)
            {
                // Bắt buộc phải store lại giá trị next đầu tiên, để sau có thể đọc được giá trị tiếp theo
                nextNode = head.next;
                head.next = prevNode;
                prevNode = head;
                head = nextNode;
            }
            head.next = prevNode;
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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthNodeFromEndofList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListNode listNode = new ListNode(1);
            //ListNode listNode1 = new ListNode(2);
            //ListNode listNode2 = new ListNode(3);
            //ListNode listNode3 = new ListNode(4);
            //ListNode listNode4 = new ListNode(5);
            //listNode.next = listNode1;
            //listNode1.next = listNode2;
            //listNode2.next = listNode3;
            //listNode3.next = listNode4;

            ListNode listNode = new ListNode(1);
            //ListNode listNode1 = new ListNode(2);
            //listNode.next = listNode1;

            Console.WriteLine(RemoveNthFromEnd(listNode, 1));
            Console.ReadKey();
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // Kiểm tra đầu vào
            if (head == null)
            {
                return null;
            }

            // Dùng vòng while để lấy chiều dài của node
            int len = 0;
            ListNode temp = head;
            while (temp != null)
            {
                temp = temp.next;
                len++;
            }

            // do là cần thay đổi giá trị next trước đó, nên ta cần lấy index của giá trị trước giá trị muốn remove
            int find = len - n;
            find = Math.Max(find, 0);
            ListNode result = new ListNode(0);
            ListNode temp2 = result;

            temp2.next = head;
            ListNode tempnext;
            for (int i = 0; i < len; i++)
            {
                if (i == find)
                {
                    tempnext = temp2?.next;
                    temp2.next = tempnext?.next;
                }
                else
                {
                    temp2 = temp2?.next;
                }    
            }

            return result?.next;
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

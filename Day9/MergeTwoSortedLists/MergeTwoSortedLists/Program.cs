using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListNode listNode = new ListNode(3);
            //ListNode listNode1 = new ListNode(2);
            //ListNode listNode2 = new ListNode(0);
            //ListNode listNode3 = new ListNode(9);
            //listNode.next = listNode1;
            //listNode1.next = listNode2;
            //listNode2.next = listNode3;

            //ListNode listNode5 = new ListNode(1);
            //ListNode listNode6 = new ListNode(6);
            //ListNode listNode7 = new ListNode(7);
            //ListNode listNode8 = new ListNode(8);
            //listNode5.next = listNode6;
            //listNode6.next = listNode7;
            //listNode7.next = listNode8;

            ListNode listNode = new ListNode(1);
            ListNode listNode1 = new ListNode(2);
            ListNode listNode2 = new ListNode(4);
            listNode.next = listNode1;
            listNode1.next = listNode2;

            ListNode listNode5 = new ListNode(1);
            ListNode listNode6 = new ListNode(3);
            ListNode listNode7 = new ListNode(4);
            listNode5.next = listNode6;
            listNode6.next = listNode7;

            Console.WriteLine(MergeTwoLists(listNode, listNode5));
            Console.ReadKey();
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Kiểm tra đầu vào
            if (list1 == null && list2 == null)
            {
                return null;
            }

            if (list1 != null && list2 == null)
            {
                return list1;
            }

            if (list1 == null && list2 != null)
            {
                return list2;
            }

            //Tạo 1 node dummy, vì vậy khi return kết quả trả về ta phải gọi result.next để bỏ qua giá trị dummy đầu tiên
            ListNode result = new ListNode(0);
            // Tại sao phải tạo thêm curr node?
            // Để thao tác trức tiếp và gán next node, khi hoàn thành thì node sẽ ở vị trí cuối cùng nên return giá trị trả về sẽ
            // không chính xác. Vì vậy, ta cần tạo 1 giá trị để lưu trữ kết quả và 1 giá trị để thao tác trên node
            ListNode curr = result;

            while (true)
            {
                if (list1 == null)
                {
                    curr.next = list2;
                    break;
                }

                if (list2 == null)
                {
                    curr.next = list1;
                    break;
                }

                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        curr.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        curr.next = list2;
                        list2 = list2.next;
                    }
                }

                // Mỗi thao tác xong ta cần di chuyển đến node kế tiếp để nhận giá trị mới cho curr node
                curr = curr.next;
            }

            return result.next;
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


static void Main(string[] args)
{
    ListNode listNode = new ListNode(1);
    ListNode listNode1 = new ListNode(3);
    ListNode listNode2 = new ListNode(4);
    ListNode listNode3 = new ListNode(4);
    ListNode listNode4 = new ListNode(5);
    ListNode listNode5 = new ListNode(8);
    ListNode listNode6 = new ListNode(9);
    listNode.next = listNode1;
    listNode1.next = listNode2;

    listNode3.next = listNode4;
    listNode4.next = listNode5;
    listNode5.next = listNode6;

    var result = MergeKLists(new ListNode[] { listNode, listNode3 });
    while (result != null)
    {
        Console.WriteLine(result.val);
        result = result.next;
    }

    Console.ReadKey();
}

static ListNode MergeKLists(ListNode[] lists)
{
    PriorityQueue<int, int> priorityQueue = new System.Collections.Generic.PriorityQueue<int, int>();

    for (int i = 0; i < lists.Length; i++)
    {
        var curr = lists[i];

        while (curr != null)
        {
            priorityQueue.Enqueue(curr.val, curr.val);
            curr = curr.next;
        }
    }

    ListNode dummy = new ListNode(-1);
    ListNode head = dummy;

    while (priorityQueue.Count > 0)
    {
        head.next = new ListNode(priorityQueue.Dequeue());
        head = head.next;
    }

    return dummy.next;
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


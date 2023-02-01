using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_102.Binary_Tree_Level_Order_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            TreeNode root1 = new TreeNode(9);
            TreeNode root2 = new TreeNode(20);
            TreeNode root3 = new TreeNode(15);
            TreeNode root4 = new TreeNode(7);

            root.left = root1;
            root.right = root2;
            root2.left = root3;
            root2.right = root4;

            var result = LevelOrder(root);
            Console.ReadLine();
        }

        // Khi nói đến duyệt thứ tự theo cấp độ của tìm kiếm theo chiều rộng bfs, thường thì chúng ta sẽ chuyển dang
        // 1 hàng đợi queue
        // Mỗi vòng lặp ta sẽ dequeue ra 1 giá trị, và enqueue 2 giá trị left, right của nó vào queue hiện tại để tiếp
        // tục vòng lặp
        // Lưu ý, ở mỗi lần lặp qua queue, ta cần kiểm tra size của queue, để tránh việc queue count thay đổi
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                var tempList = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    tempList.Add(curr.val);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }

                result.Add(tempList);
            }

            return result;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

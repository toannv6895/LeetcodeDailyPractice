using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230.Kth_Smallest_Element_in_a_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(3);
            //TreeNode root1 = new TreeNode(1);
            //TreeNode root2 = new TreeNode(4);
            //TreeNode root3 = new TreeNode(2);

            //root.left = root1;
            //root.right = root2;
            //root2.right = root3;

            //int k = 1;

            //TreeNode root = new TreeNode(5);
            //TreeNode root1 = new TreeNode(3);
            //TreeNode root2 = new TreeNode(6);
            //TreeNode root3 = new TreeNode(2);
            //TreeNode root4 = new TreeNode(4);
            //TreeNode root5 = new TreeNode(1);

            //root.left = root1;
            //root.right = root2;
            //root2.left = root3;
            //root2.right = root4;
            //root3.left = root5;

            //int k = 3;

            //TreeNode root = new TreeNode(1);
            //TreeNode root1 = new TreeNode(2);

            //root.right = root1;

            //int k = 1;

            TreeNode root = new TreeNode(3);
            TreeNode root1 = new TreeNode(1);
            TreeNode root2 = new TreeNode(4);
            TreeNode root3 = new TreeNode(2);

            root.left = root1;
            root.right = root2;
            root1.right = root3;

            int k = 1;

            var result = KthSmallest(root, k);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static int KthSmallest(TreeNode root, int k)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            PriorityQueue<int, int> priorityQueue= new PriorityQueue<int, int>();
            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();
                priorityQueue.Enqueue(node.val, node.val);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            for (int i = 1; i < k; i++)
            {
                if (priorityQueue.Count > 0)
                {
                    priorityQueue.Dequeue();
                }
            }

            return priorityQueue.Peek();

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

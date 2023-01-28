using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104.Maximum_Depth_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root= new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            Console.WriteLine(MaxDepth(root));
            Console.ReadLine();
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
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

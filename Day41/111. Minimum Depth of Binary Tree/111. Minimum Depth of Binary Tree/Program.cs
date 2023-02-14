using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111.Minimum_Depth_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode root1 = new TreeNode(2);
            TreeNode root2 = new TreeNode(2);
            TreeNode root3 = new TreeNode(3);
            TreeNode root4 = new TreeNode(4);
            TreeNode root5 = new TreeNode(4);
            TreeNode root6 = new TreeNode(3);

            //TreeNode root = new TreeNode(1);
            //TreeNode root1 = new TreeNode(2);
            //TreeNode root2 = new TreeNode(2);
            //TreeNode root3 = new TreeNode(3);
            //TreeNode root6 = new TreeNode(3);

            root.left = root1;
            root.right = root2;
            root2.left = root3;
            root2.right = root4;
            root3.left = root5;
            root3.right = root6;

            Console.WriteLine(MinDepth(root));
            Console.ReadLine();
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = 0;
            int right = 0;

            if (root?.left != null)
            {
                left = MinDepth(root?.left);
            }

            if (root?.right != null)
            {
                right = MinDepth(root?.right);
            }

            if (left == 0 || right == 0)
            {
                return left + right + 1;
            }

            return Math.Min(left, right) + 1;
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

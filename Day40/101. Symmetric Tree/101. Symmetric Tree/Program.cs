using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101.Symmetric_Tree
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

            Console.WriteLine(IsSymmetric(root));
            Console.ReadLine();
        }

        public static bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric2(root?.left, root?.right);
        }

        public static bool IsSymmetric2(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            return left.val == right.val && IsSymmetric2(left?.left, right?.right) && IsSymmetric2(left?.right, right?.left);
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

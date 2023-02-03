using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124.Binary_Tree_Maximum_Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(-10);
            TreeNode root1 = new TreeNode(9);
            TreeNode root2 = new TreeNode(20);
            TreeNode root3 = new TreeNode(15);
            TreeNode root4 = new TreeNode(7);

            root.left = root1;
            root.right = root2;
            root2.left = root3;
            root2.right = root4;

            var result = MaxPathSum(root);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static int max = int.MinValue;
        public static int MaxPathSum(TreeNode root)
        {
            MaxRecursive(root);

            return max;
        }

        public static int MaxRecursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var left = Math.Max(MaxRecursive(root.left),0);
            var right = Math.Max(MaxRecursive(root.right),0);

            max = Math.Max(max, left + right + root.val);

            return Math.Max(left, right) + root.val;
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

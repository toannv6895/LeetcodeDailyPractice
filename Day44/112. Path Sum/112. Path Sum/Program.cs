using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112.Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            TreeNode root1 = new TreeNode(2);
            TreeNode root2 = new TreeNode(5);
            TreeNode root3 = new TreeNode(5);
            TreeNode root4 = new TreeNode(7);

            root.left = root1;
            root.right = root2;
            root2.left = root3;
            root2.right = root4;

            TreeNode rootB = new TreeNode(1);
            TreeNode rootB1 = new TreeNode(2);
            //TreeNode rootB = new TreeNode(-2);
            //TreeNode rootB1 = new TreeNode(-3);
            //TreeNode rootB2 = new TreeNode(2);
            //TreeNode rootB3 = new TreeNode(3);
            //TreeNode rootB6 = new TreeNode(3);

            rootB.right = rootB1;
            //rootB.right = rootB2;
            //rootB2.left = rootB3;
            //rootB3.right = rootB6;

            Console.WriteLine(HasPathSum(root, 14));
            Console.ReadLine();
        }

        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            return (targetSum - root.val == 0 && root?.left == null && root?.right == null) || 
                HasPathSum(root?.left, targetSum - root.val) || 
                HasPathSum(root?.right, targetSum - root.val);
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

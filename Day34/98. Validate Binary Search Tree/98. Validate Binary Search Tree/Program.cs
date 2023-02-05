using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98.Validate_Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            TreeNode root1 = new TreeNode(1);
            TreeNode root2 = new TreeNode(3);

            //TreeNode root = new TreeNode(5);
            //TreeNode root1 = new TreeNode(1);
            //TreeNode root2 = new TreeNode(4);
            //TreeNode root3 = new TreeNode(3);
            //TreeNode root4 = new TreeNode(6);

            //TreeNode root = new TreeNode(5);
            //TreeNode root1 = new TreeNode(4);
            //TreeNode root2 = new TreeNode(6);
            //TreeNode root3 = new TreeNode(3);
            //TreeNode root4 = new TreeNode(7);

            root.left = root1;
            root.right = root2;
            //root2.left = root3;
            //root2.right = root4;

            Console.WriteLine(IsValidBST(root));
            Console.ReadLine();
        }

        public static bool IsValidBST(TreeNode root)
        { 
            return IsValidBST2(root,null,null);
        }

        public static bool IsValidBST2(TreeNode root, TreeNode min, TreeNode max)
        {
            if (root == null)
            {
                return true;
            }

            if ((min != null && root.val <= min.val) || (max != null && root.val >= max.val))
            {
                return false;
            }

            return IsValidBST2(root.left, min, root) && IsValidBST2(root.right, root, max);
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

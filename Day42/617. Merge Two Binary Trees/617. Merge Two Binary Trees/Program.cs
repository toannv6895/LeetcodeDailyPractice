using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _617.Merge_Two_Binary_Trees
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

            root.left = root1;
            root.right = root2;
            root2.left = root3;
            root2.right = root4;
            root3.left = root5;
            root3.right = root6;

            TreeNode rootB = new TreeNode(1);
            TreeNode rootB1 = new TreeNode(2);
            TreeNode rootB2 = new TreeNode(2);
            TreeNode rootB3 = new TreeNode(3);
            TreeNode rootB6 = new TreeNode(3);

            rootB.left = rootB1;
            rootB.right = rootB2;
            rootB2.left = rootB3;
            rootB3.right = rootB6;

            MergeTrees(root, rootB);
            Console.ReadLine();
        }

        private static TreeNode result;
        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            // Các điều kiện để dừng recursive
            if (root1 == null & root2 == null) return null;

            if (root1 == null) return root2;

            if (root2 == null) return root1;

            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);
            root1.val += root2.val;
            return root1;
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

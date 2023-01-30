using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226.Invert_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            TreeNode root1 = new TreeNode(2);
            TreeNode root2 = new TreeNode(7);
            TreeNode root3 = new TreeNode(1);
            TreeNode root4 = new TreeNode(3);
            TreeNode root5 = new TreeNode(6);
            TreeNode root6 = new TreeNode(9);

            root.left= root1;
            root.right= root2;
            root1.left= root3;
            root1.right= root4;
            root2.left= root5;
            root2.right= root6;

            InvertTree(root);
            Console.ReadLine();
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var temp = InvertTree(root.left);
            root.left = InvertTree(root.right);
            root.right = temp;

            return root;
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

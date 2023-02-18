using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _671.Second_Minimum_Node_In_a_Binary_Tree
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

            TreeNode rootB = new TreeNode(2);
            TreeNode rootB1 = new TreeNode(2);
            TreeNode rootB2 = new TreeNode(2);
            //TreeNode rootB3 = new TreeNode(3);
            //TreeNode rootB6 = new TreeNode(3);

            rootB.left = rootB1;
            rootB.right = rootB2;
            //rootB2.left = rootB3;
            //rootB3.right = rootB6;

            Console.WriteLine(FindSecondMinimumValue(rootB));
            Console.ReadLine();
        }

        private static int rootValue;

        public static int FindSecondMinimumValue(TreeNode root)
        {
            rootValue = root.val;

            int value =  FindSecondMinimumValue2(root);

            if (rootValue < value)
            {
                return value;
            }

            return -1;
        }

        public static int FindSecondMinimumValue2(TreeNode root)
        {
            if (root == null) return int.MinValue;

            int left = FindSecondMinimumValue2(root?.left);
            int right = FindSecondMinimumValue2(root?.right);

            if (rootValue < Math.Min(left, right))
            {
                return Math.Min(left, right);
            }
            else if (rootValue < Math.Max(left, right))
            {
                return Math.Max(left, right);
            }

            return root.val;
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

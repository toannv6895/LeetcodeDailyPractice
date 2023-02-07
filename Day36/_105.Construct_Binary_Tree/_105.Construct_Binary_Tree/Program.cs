using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105.Construct_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] preorder = { 3, 9, 20, 15, 7 }, inorder = { 9, 3, 15, 20, 7 };

            var result = BuildTree(preorder, inorder);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        // Explain: https://www.youtube.com/watch?v=PoBGyrIWisE
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree2(preorder, inorder, 0, preorder.Length - 1, 0);
        }

        public static TreeNode BuildTree2(int[] preorder, int[] inorder, int start, int end, int index)
        {
            if (start > end)
            {
                return null;
            }

            TreeNode node = new TreeNode(preorder[index]);

            int inIndex = start;

            while (preorder[index] != inorder[inIndex])
            {
                inIndex++;
            }

            node.left = BuildTree2(preorder, inorder, start, inIndex - 1, index + 1);
            node.right = BuildTree2(preorder, inorder, inIndex + 1, end, index + inIndex - start + 1);

            return node;
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

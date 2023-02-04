using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _297.Serialize_and_Deserialize_Binary_Tree
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

            var result = serialize(root);
            Console.WriteLine(result);

            var result2 = deserialize(result);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
        private static string rs = string.Empty;

        // Encodes a tree to a single string.
        public static string serialize(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }

            string left = serialize(root.left);
            string right = serialize(root.right);

            return root.val.ToString() + "#" + left + "#" + right;
        }

        // Decodes your encoded data to tree.
        public static TreeNode deserialize(string data)
        {
            if (data.IndexOf("#") == -1)
            {
                return null;
            }

            string[] str = data.Split('#');

            var queue = new Queue<string>(str);

            TreeNode root = new TreeNode(int.Parse(queue.Dequeue()));

            while (queue.Any())
            {
                root.left = deserialize(queue);
                root.right = deserialize(queue);
            }

            return root;
        }

        public static TreeNode deserialize(Queue<string> data)
        {
            TreeNode curr = null;
            var value = data.Dequeue();

            if (String.IsNullOrEmpty(value))
            {
                return null;
            }

            if (value != "#")
            {
                curr = new TreeNode(int.Parse(value));
            }

            if (data.Any())
            {
                curr.left = deserialize(data);
            }

            if (data.Any())
            {
                curr.right = deserialize(data);
            }

            return curr;
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

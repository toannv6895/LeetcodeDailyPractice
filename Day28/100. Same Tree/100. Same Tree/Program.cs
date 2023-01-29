using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100.Same_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode(1, new TreeNode(2));
            TreeNode q = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(IsSameTree(p, q));
            Console.ReadLine();
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p is null || q is null)
            {
                return p == q;
            }

            return IsSameTree(p.left, q.left) && 
                IsSameTree(p.right, q.right) && 
                p.val == q.val;
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

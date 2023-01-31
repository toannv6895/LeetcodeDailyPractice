using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _572.Subtree_of_Another_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            TreeNode root1 = new TreeNode(4);
            TreeNode root2 = new TreeNode(5);
            TreeNode root3 = new TreeNode(1);
            TreeNode root4 = new TreeNode(2);

            TreeNode subroot = new TreeNode(4);
            TreeNode root5 = new TreeNode(1);
            TreeNode root6 = new TreeNode(2);

            root.left = root1;
            root.right = root2;
            root1.left = root3;
            root1.right = root4;

            subroot.left = root5;
            subroot.right = root6;

            //TreeNode root = new TreeNode(1);
            //TreeNode root1 = new TreeNode(1);

            //TreeNode subroot = new TreeNode(1);

            root.left = root1;

            bool restult = IsSubtree(root, subroot);
            Console.WriteLine(restult);
            Console.ReadLine();
        }

        // Revursive không chỉ dùng để return giá trị mà còn có thể dùng để kiểm tra điều kiện.
        // Để tránh việc phải return giá trị từ recursive, ta có thể dùng nó làm điều kiện kiểm tra
        // và sau đó return giá trị trên điều kiện đó.
        // Lưu ý, khi dùng recursive thì 
        // 1. Kiểm tra giá trị đầu vào hoặc logic/điều kiện để dừng recursive
        // 2. Dùng recursive
        // Như đoạn code dưới, vì dùng recursive kiểm tra ta không thể đảm bảo dừng recursive vì thiếu điều kiện else để trả
        // về false (vì sau khi comapre 2 node, nếu không bằng nhau ta cần phải thiếp tục kiểm tra các giá trị node left và right),
        // Do vậy, nếu dùng else return false thì kết quả trả về sẽ bị sai.
        // Vì vậy ta phải return false ở cuối cùng để đảm bảo khi recursive không thể trả về true
        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (CompareTreeNode(root, subRoot))
            {
                return true;
            }
            //else
            //{
            //    return false;
            //}

            if (root?.left != null && IsSubtree(root.left, subRoot))
            {
                return true;
            }

            if (root?.right != null && IsSubtree(root.right, subRoot))
            {
                return true;
            }

            return false;
        }

        public static bool CompareTreeNode(TreeNode node1, TreeNode node2)
        {
            if (node1 == null || node2 == null)
            {
                return node1?.val == node2?.val;
            }

            if (node1.val != node2.val)
            {
                return false;
            }

            return CompareTreeNode(node1.left, node2.left) && CompareTreeNode(node1.right, node2.right);
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

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(6);
            TreeNode root1 = new TreeNode(2);
            TreeNode root2 = new TreeNode(8);
            TreeNode root3 = new TreeNode(0);
            TreeNode root4 = new TreeNode(4);
            TreeNode root5 = new TreeNode(7);
            TreeNode root6 = new TreeNode(9);
            TreeNode root7 = new TreeNode(3);
            TreeNode root8 = new TreeNode(5);

            root.left = root1;
            root.right = root2;
            root1.left = root3;
            root1.right = root4;
            root2.left = root5;
            root2.right = root6;
            root4.left = root7;
            root4.right = root8;

            TreeNode p = new TreeNode(2);
            TreeNode q = new TreeNode(8);

            Console.WriteLine(LowestCommonAncestor(root, p, q).val);
            Console.ReadKey();
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            while(root != null){
                if(root.val < p.val && root.val < q.val){
                    root = root.right;
                } else if(root.val > p.val && root.val > q.val){
                    root = root.left;
                }
                else{
                    return root;
                }
            }

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
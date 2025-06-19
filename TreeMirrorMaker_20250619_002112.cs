using System;

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

public class Solution {
    public TreeNode MirrorTree(TreeNode root) {
        if(root == null) {
            return null;
        }

        TreeNode temp = root.left;
        root.left = MirrorTree(root.right);
        root.right = MirrorTree(temp);
        
        return root;
    }
    
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        Solution sol = new Solution();
        TreeNode mirroredTree = sol.MirrorTree(root);

        PrintInOrder(mirroredTree);
    }

    static void PrintInOrder(TreeNode node) {
        if (node == null) {
            return;
        }

        PrintInOrder(node.left);

        Console.Write(node.val + " ");

        PrintInOrder(node.right);
    }
}
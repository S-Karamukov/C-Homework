using System;

namespace Page61Ex20
{
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;

        TreeNode(int element)
        {
            data = element;
            left = null;
            right = null;
            parent = null;
        }

        abstract class Cls
        {
            public TreeNode Insert(TreeNode tree, int Tar)
            {
                if (tree == null)
                {
                    TreeNode item = new TreeNode(Tar);
                    tree = item;
                }
                else
                {
                    if (Tar < tree.data)
                    {
                        tree.left = Insert(tree.right, Tar);
                        tree.right.parent = tree;
                    }
                }
                return tree;
            }
            public TreeNode Find_Min(TreeNode tree)
            {
                if (tree == null)
                {
                    return null;
                }
                else if (tree.left == null)
                {
                    return tree;
                }
                else
                {
                    return Find_Min(tree.left);
                }
            }
            public TreeNode Find_Max(TreeNode tree)
            {
                if (tree == null)
                {
                    return null;
                }
                else if (tree.left == null)
                {
                    return tree;
                }
                else
                {
                    return Find_Max(tree.right);
                }
            }
            public void Printall(TreeNode tree)
            {
                if (tree != null)
                {
                    Console.WriteLine("{0}\t", tree.data);
                    Printall(tree.left);
                    Printall(tree.right);
                }
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

        }
    }
}

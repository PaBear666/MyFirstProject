using System;

namespace TreeNode
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public class TreeNode
    {
        public int Info { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode() { }
        public TreeNode(char info)
        {
            Info = info;
        }
        public TreeNode(char info, TreeNode left, TreeNode right)
        {
            Info = info; 
            Left = left; 
            Right = right;
        }
    }
    public class BinaryTree
    {
        public TreeNode Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }
        public int Recurse(TreeNode Root)//Количество рекурс
        {
            int i;
            if (Root != null)
            {
                i = Recurse(Root.Left) + 1 + Recurse(Root.Right);
            }
            else
            {
                i = 0;
            }
            return i;

        }
        public TreeNode CreateBalanced(int n) // n – количество узлов в дереве
        {
            char x; TreeNode root; 
            if (n == 0) root = null;
            else
            { 
                Console.WriteLine("Введите значение инф.поля узла ");
                x = Char.Parse(Console.ReadLine());
                root = new TreeNode(x); // создать корень дерева
                root.Left = CreateBalanced(n / 2); // построить левое поддерево
                root.Right = CreateBalanced(n - n / 2 - 1); // построить правое поддерево
            }
            return root;
        }


    }

}

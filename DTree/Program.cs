using System;

namespace DTree
{
    class Program
    {
        static void Main(string[] args)
        {
            DichotomyTree D = new DichotomyTree(65,'k');
            SingleLinkedList Q = new SingleLinkedList();
            D.Add(100, D.Root);
            D.Add(101, D.Root);
            D.Add(33, D.Root);
            Console.WriteLine(D.FindNeedNode(101, D.Root).Info);
            D.Task(Q, 101);
            D.Task(Q, 100);
            Q.Print();

        }
    }
    public class ArNode  // Класс «Узел дерева арифметических выражений»
    {
        public double Info;
        public char act;
        public ArNode Left;
        public ArNode Right;
        // свойства, конструкторы
    }

    public class ArTree  // Класс «Дерево арифметических выражений»
    {
        private ArNode root;

        public ArNode Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
        public ArTree() // Конструктор
        {
            root = null;
        }
        // Функции
    }

    public class DTreeNode          // Класс «Узел дихотомического дерева» 
    {
        public char Info { get; set; }  // информационное поле 
        public int Key { get; set; }    // поле ключа 
        public DTreeNode Left { get; set; } // ссылка на левое поддерево 
        public DTreeNode Right { get; set; } // ссылка на левое поддерево 
        public DTreeNode() { }  // конструкторы 
        public DTreeNode(char info, int key)
        {
            Info = info; 
            Key = key;
        }
        public DTreeNode(char info, int key, DTreeNode left, DTreeNode right) : this(info,key)
        {
            Left = left; 
            Right = right;
        }
    }
    public class DichotomyTree
    {
        public DTreeNode Root { get; set; }
        public DichotomyTree()  // создание пустого дерева 
        {
            Root = null;
        }
        public DichotomyTree(int key,char info)  // создание пустого дерева 
        {
            Root = new DTreeNode(info, key, null, null);
        }
        public DTreeNode FindNeedNode(int key,DTreeNode root)
        {
            DTreeNode p = null;
            if(root != null)
            {
                if (root.Key < key)
                { 
                    p = FindNeedNode(key, root.Right); 
                }
                else if (root.Key > key) 
                { 
                    p = FindNeedNode(key, root.Left); 
                }
                else 
                { 
                    p = root; 
                }
            }
            return p;
            
        }
        public DTreeNode Add(int key, DTreeNode root)
        {
            if (root == null)
            {
                Console.WriteLine("Введите информационное поле");
                char info = char.Parse(Console.ReadLine());
                root = new DTreeNode(info,key);
            }
            else
            {
                if (root.Key > key)
                {
                    root.Left = Add(key, root.Left);
                }
                else if(root.Key < key)
                { 
                    root.Right = Add(key, root.Right); 
                }
            }
            return root;
        }
        public void Task(SingleLinkedList Q,int key)
        {
            Q.Create(FindNeedNode(key, Root).Info);
        }
        public double Calculation(ref bool value ,ArNode root)
        {
            double right;
            double result = 0;
            double left;
            if (value && (root != null))
            {
                right = Calculation(ref value,root.Right);
                left = Calculation(ref value, root.Left);
                if (value)
                {
                    switch (root.act)
                    {
                        case '+':
                             result = right + left;
                            break;
                        case '*':
                            result = left * right;
                            break;
                        case '-':
                            result = left - right; 
                            break;
                        case '/':
                            if (right != 0)
                            {
                                result = left / right;
                            }
                            else 
                            { 
                                value = false; 
                            }
                                break;
                    }
                }
            }
            return result;
        }
    }
}

using System;

namespace Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class DictonaryNode
    {
        public DictonaryNode Link { get; set; }
        public int Key { get; set; }
        public int Info { get; set; }

        public DictonaryNode(int key,int info, DictonaryNode link)
        {
            Key = key;
            Info = info;
            Link = Link;
        }
        
    }
    class Dictonary
    {
        public DictonaryNode[] Array { get; set; }
        public int Size { get; set; }
        
        public Dictonary(int size)
        {
            Size = size;
            Array = new DictonaryNode[Size];
        }


    }
}

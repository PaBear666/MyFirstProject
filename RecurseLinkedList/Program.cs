using System;

namespace RecurseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var L = new RecurseLinkedList(new int[]{ 33,22,11 });
        }
    }
    class Node
    {
        public Node Link { get; set; }
        public int Info { get; set; }
        public Node() { }
        public Node(int info)
        {
            Info = info;
        }
        public Node(int info, Node link) : this(info)
        {
            Link = link;
        }
    }
    class RecurseLinkedList
    {
        public Node Head { get; set; }
        public RecurseLinkedList()
        {
            Head = new Node();
            Head.Link = Head;
        }
        public RecurseLinkedList(int[] info)
        {
            Head = new Node(info[0], Head.Link);
            for (int i = 1; i < info.Length; i++)
            {
                var p = new Node(info[i]);
                p.Link = Head.Link;
                Head.Link = p;
            }
        }

        public void Create(int[] dates)
        {
            Node q = Head;
            for (int i = 0; i < dates.Length; i++)
            {
                Node p = new Node(dates[i]);
                p.Link = Head;
                q.Link = p;
                q = p;
            }
        }
        public void Delete()
        {
            if(( Head != null) && (Head.Link != Head))
            {
                Head.Link = Head.Link.Link;
            }
        }
    }
}

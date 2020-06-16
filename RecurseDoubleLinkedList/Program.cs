using System;
using System.Net.Http.Headers;

namespace RecurseDoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CycleDoubleLinkedList L = new CycleDoubleLinkedList();
            CycleDoubleLinkedList Q = new CycleDoubleLinkedList();
            L.Create(new int[] { 1, 2, 3,9,10});
            Q.Create(new int[] { 5, 6, 7,8,6});
            L.Print(Q);

        }
    }

    public class DoubleNode // Класс «Узел двусвязного циклического списка
    {

        public int Info { set; get; }
        public DoubleNode Next { get; set; } // поле связи со следующим узлом }
        public DoubleNode Prev { get; set; } // поле связи с предыдущим узлом }
        public DoubleNode() { } // конструкторы }
        public DoubleNode(int info)
        {
            Info = info;
        }
        public DoubleNode(int info, DoubleNode next, DoubleNode prev) : this(info)
        {
            Next = next; 
            Prev = prev;
        }
    }
    public class CycleDoubleLinkedList // Класс “Двусвязные циклические списки”
    {
        public DoubleNode Head { get; set; } // ссылка на головной узел списка
        public CycleDoubleLinkedList() // создание элементарного двусвязного кольца
        {
            Head = new DoubleNode();
            Head.Next = Head;
            Head.Prev = Head;
        }
        public CycleDoubleLinkedList(int[] datas)
        {
            if(Head == null)
            {
                Head.Next = Head;
                Head.Prev = Head;
            }
            var q = Head;
            for (int i = 1; i < datas.Length; i++)
            {
                DoubleNode p = new DoubleNode(datas[i]);
                q.Next = p;
                Head.Prev = q.Next;
                p.Next = Head;
                p.Prev = q;
                q = q.Next;
            }
        }
        public void Print(CycleDoubleLinkedList Q)
        {
            DoubleNode p = Head.Next;
            while(p != Head)
            {
                Console.Write(p.Info + " ");
                p = p.Next;
            }
        }
        public DoubleNode FindNeedInfo(int data)
        {
            var p = Head.Next;
            while(p != Head && p.Info != data)
            {
                p=p.Next;
            }
            return p;
        }
        public void AddNewNodeBefore(DoubleNode p,int data)
        {
            DoubleNode q = new DoubleNode(data,p,p.Prev);
            p.Prev.Next = q;
            p.Prev = q;
        }
        public void AddNewNodeAfter(DoubleNode p,int data)
        {
            DoubleNode q = new DoubleNode(data,p.Next,p);
            p.Next.Prev = q;
            p.Next = q;


        }
        public void DeleteNode(DoubleNode p)
        {
            if (Head != null && Head.Next != Head && Head.Prev != Head && p != null) // установлена?
            {
                p.Prev.Next = p.Next; // изменить поле связи предыдущего узла
                p.Next.Prev = p.Prev; // изменить поле связи следующего узла
            }
        }
        public void DeleteNodeNeedInfo(int data)
        {
            DoubleNode p = Head.Next;
            while (p != Head)
            {
                if(p.Info == data)
                {
                    p.Prev.Next = p.Next;
                    p.Next.Prev = p.Prev;
                }
                p = p.Next;
            }
        }
        public void Create(int[] dates) // cоздание циклического списка
        {
           
            for (int i = 0; i < dates.Length; i++)
            {
               DoubleNode p = new DoubleNode(dates[i]);
               p.Next = Head;
                p.Prev = Head.Prev;
                Head.Prev.Next = p;
                Head.Prev = p;

            }
        }
        public void InsertAfter(DoubleNode p, int data)
        {
            {
                if (p != null) 
                {
                    DoubleNode q = new DoubleNode(data);
                    q.Next = p.Next;
                    p.Next.Prev = q;
                    p.Next = q;
                    q.Prev = p;
                }
            }
        }
        public void CreateSort(int[] dates)
        {
            
            for (int i = 0; i < dates.Length; i++)
            {
                DoubleNode p = Head.Next; 
                DoubleNode q = new DoubleNode(dates[i]);
                while (p != Head && q.Info >= q.Info)
                {
                    p = p.Next;
                }
                q.Next = p;
                q.Prev = p.Prev;
                p.Prev.Next = q;
                p.Prev = q;
            }
        }
        public void Test(CycleDoubleLinkedList Q)
        {
            DoubleNode p = Head.Next;
            DoubleNode q = Q.Head.Next;
            DoubleNode q1 = Q.Head.Next.Next;
            while (p != Head && q.Next != Q.Head)
            {
                if (q1 != Head)
                {
                    q.Next = p.Next;
                    p.Next.Prev = q;
                    q.Prev = p;
                    p.Next = q;
                    p = p.Next.Next;
                    q = q1;
                    q1 = q1.Next;
                }
                
            }
            q.Next = p.Next;
            p.Next.Prev = q;
            q.Prev = p;
            p.Next = q;
        }
    }

}

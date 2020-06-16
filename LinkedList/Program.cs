using System;

namespace LinkedList
{ 
    class Program 
    { 
        static void Main()
        {
            SingleLinkedList L = new SingleLinkedList(); // конструктор
            SingleLinkedList Q = new SingleLinkedList(new int[]{9,4}); // конструктор
            L.Create(4);
            L.Print();
        }

    }
    public class Node // Класс «Узел односвязного списка»
    {
        public int Info { get; set; }
        public Node Link { get; set; }

        public Node(int info)
        {
            Info = info;
        }
        public Node(int info, Node link) : this(info)
        {
            Link = link;
        }
    }
    public class SingleLinkedList // Класс «Односвязные списки»
    {
        public Node First { get; set; } // ссылка на первый узел списка
        public Node Last { get; set; }
        public SingleLinkedList() // конструктор: создание пустого списка
        {
            First = null;
        }

        public SingleLinkedList(int[] dates) // first – ссылка на первый узел списка
        { // dates – массив значений информационных полей
          // last – ссылка на последний узел списка
            if (dates.Length == 0) First = null; // создание пустого списка
            else
            {
                First = new Node(dates[0], null); // создание первого узла списка
                Last = First;
                // цикл включения в список остальных элементов
                for (int i = 1; i < dates.Length; i++)
                {
                    Node p = new Node(dates[i], null); // создание узла списка
                    Last.Link = p; // вставка нового узла за текущим последним узлом
                    Last = p; // новое значение ссылки на последний узел
                }
            }
        }
        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data, First);
            First = p; // новое значение ссылки на первый узел
            // first – ссылка на первый узел списка
            // data – значение информационного поля
            // узла списка
            // создание узла списка со значением data
        }

        public void Create(int[] dates) // first – ссылка на первый узел списка
                                        // dates – массив значений информационных полей
        {
            First = null; // создание пустого списка
            for (int i = 0; i < dates.Length; i++)
            {
                Node p = new Node(dates[i], First); // вставка узла в начало списка
                First = p;
            }

        }

        public void DeleteBeginning() //Удаление из начала списка определенное кол-во узлов
        {
            
            First = First.Link;

        }
        public int FindNeedInfo(int value) //Поиск узла в односвязном списке по заданному условию

        {
            Node p = First;
            int i = 0;
            while (p != null && p.Info != value)
            {
                p = p.Link;
                i++;
            }

            return i;
        }
        public void InsertAfter(int data, Node p) //Включение в односвязный список нового узла за тем узлом, на который предварительно установлена ссылка
        {
            Node q = new Node(data, p.Link);
            p.Link = q;
        }
        public void DeleteBeforeNode(Node p)
        {
            Node q = First;
            while (q.Link != p)
            {
                q = q.Link;
            }
            q.Link = p.Link;
        }//Исключение из односвязного списка узла, на который предварительно установлена ссылка
        public void Print()
        {
            Node p = First;
            while (p != null)
            {
                Console.Write(p.Info + " ");
                p = p.Link;
            }
            Console.WriteLine();
        }
        public int Sum()
        {
            int sum = default;
            Node p = First;
            while (p != null)
            {
                sum = p.Info + sum;
                p = p.Link;
            }
            return sum;
        }
        public void Destroy()
        {
            First = null;
        }
        public Node FindNeedPlace(int value_place)
        {
            Node p = First;
            for(int i = 1; i < value_place; i++)
                p = p.Link;
            return p;
            

        }
        public void AddNewSingleLinkedList(SingleLinkedList q)
        {
            if (q != null)
            {
                if (First == null)
                {
                    First = q.First;
                }
                else
                {
                    Node p = First;
                    while(p.Link != null)
                    {
                        p = p.Link;
                    }
                    p.Link = q.First;
                }
            }
        }
        public void Result(byte value_place,byte number)
        {
            Node q = FindNeedPlace(value_place);
            for(int i = 0; i <= number; i++)
            {
                q = q.Link;
            }
            FindNeedPlace(value_place).Link = q;
        }
        public void Create(int a)
        {
            if (First != null)
            {
                Node p = First;
                p.Link = new Node(a);
            }
            else
            {
                First = new Node(a);
            }
        }
        public void Test (SingleLinkedList Q)
        {
            Node p = First;
            Node q = Q.First;
            Node q1 = Q.First.Link;
            while (p != null && q1 != null)
            {
                if (q1 != null)
                {
                    q.Link = p.Link;
                    p.Link = q;
                    p = p.Link.Link;
                    q = q1;
                    q1 = q1.Link;
                }
            }
            p.Link = q;
        }
    }
}

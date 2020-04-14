using System;
using LinkedList;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList L = new SingleLinkedList(new int[] { 1, 2, 3, 4 });
            //Console.WriteLine(L.First.Link.Info);
            //Console.WriteLine(L.FindNeedInfo(8));// 2.4.6 Поиск узла в односвязном списке по заданному условию
            //L.InsertAfter(5, L.First.Link.Link);//2.4.7 Включение в односвязный список нового узла за тем узлом, на который предварительно установлена ссылка
            //Console.WriteLine(L.First.Link.Link.Link.Info); 
            //L.DeleteBeforeNode(L.First.Link); //2.4.9. Исключение из односвязного списка узла, на который предварительно установлена ссылка
            //Console.WriteLine(L.First.Link.Info);
            L.Print();
            Console.WriteLine();
            Console.WriteLine(L.Sum());
            L.Destroy();
            // 39 cтраница



        }
    }
    //public class Node // Класс «Узел односвязного списка»
    //{
    //    public int Info { get; set; }
    //    public Node Link { get; set; }

    //    public Node(int info)
    //    {
    //        Info = info;
    //    }
    //    public Node(int info, Node link) : this(info)
    //    {
    //        Link = link;
    //    }
    //}
    //public class SingleLinkedList // Класс «Односвязные списки»
    //{
    //    public Node First { get; set; } // ссылка на первый узел списка
    //    public Node Last { get; set; }
    //    public SingleLinkedList() // конструктор: создание пустого списка
    //    {
    //        First = null;
    //    }

    //    public SingleLinkedList(int[] dates) // first – ссылка на первый узел списка
    //    { // dates – массив значений информационных полей
    //      // last – ссылка на последний узел списка
    //        if (dates.Length == 0) First = null; // создание пустого списка
    //        else
    //        {
    //            First = new Node(dates[0], null); // создание первого узла списка
    //            Last = First;
    //            // цикл включения в список остальных элементов
    //            for (int i = 1; i < dates.Length; i++)
    //            {
    //                Node p = new Node(dates[i], null); // создание узла списка
    //                Last.Link = p; // вставка нового узла за текущим последним узлом
    //                Last = p; // новое значение ссылки на последний узел
    //            }
    //        }
    //    }
    //    public void InsertBeforeFirst(int data)
    //    {
    //        Node p = new Node(data, First);
    //        First = p; // новое значение ссылки на первый узел
    //        // first – ссылка на первый узел списка
    //        // data – значение информационного поля
    //        // узла списка
    //        // создание узла списка со значением data
    //    }
    //    public void Create(int[] dates) // first – ссылка на первый узел списка
    //                                    // dates – массив значений информационных полей
    //    {
    //        First = null; // создание пустого списка
    //        for (int i = 0; i < dates.Length; i++)
    //        {
    //            Node p = new Node(dates[i], First); // вставка узла в начало списка
    //            First = p;
    //        }

    //    }
    //    public void DeleteBeginning(int number) //Удаление из начала списка определенное кол-во узлов
    //    {
    //        Node p;
    //        p = First;
    //        First = First.Link;

    //    }
    //    public int FindNeedInfo(int value) //Поиск узла в односвязном списке по заданному условию

    //    {
    //        Node p = First;
    //        int i = 0;
    //        while (p != null && p.Info != value)
    //        {
    //            p = p.Link;
    //            i++;
    //        }

    //        return i;
    //    }
    //    public void InsertAfter(int data, Node p) //Включение в односвязный список нового узла за тем узлом, на который предварительно установлена ссылка
    //    {
    //        Node q = new Node(data, p.Link);
    //        p.Link = q;
    //    }
    //    public void DeleteBeforeNode(Node p)
    //    {
    //        Node q = First;
    //        while (q.Link != p)
    //        {
    //            q = q.Link;
    //        }
    //        q.Link = p.Link;
    //    }//Исключение из односвязного списка узла, на который предварительно установлена ссылка
    //    public void Print()
    //    {
    //        Node p = First;
    //        while (p != null)
    //        {
    //            Console.Write(p.Info);
    //            p = p.Link;
    //        }
    //    }
    //    public int Sum()
    //    {
    //        int sum = default;
    //        Node p = First;
    //        while (p != null)
    //        {
    //            sum = p.Info + sum;
    //            p = p.Link;
    //        }
    //        return sum;
    //    }
    //    public void Destroy()
    //    {
    //        First = null;
    //    }





    //    //public class Node<T>
    //    //{
    //    //    Node<T> head; // головной/первый элемент
    //    //    Node<T> last; // последний/хвостовой элемент
    //    //    int count;  // количество элементов в списке

    //    //    public Node(T data)
    //    //    {
    //    //        Data = data;
    //    //    }
    //    //    public T Data { get; set; }
    //    //    public Node<T> Next { get; set; }

    //    //    public void Add(T data)
    //    //    {
    //    //        Node<T> node = new Node<T>(data);

    //    //        if (head == null)
    //    //            head = node;
    //    //        else
    //    //            last.Next = node;

    //    //        last = node;
    //    //        count++;
    //    //    }
    //    //    /// <summary>
    //    //    /// Метод добавления элемент в начало списка
    //    //    /// </summary>
    //    //    /// <param name="data">Входные параметры</param>
    //    //    public void AppendFirst(T data)
    //    //    {
    //    //        Node<T> node = new Node<T>(data);
    //    //        node.Next = head;
    //    //        head = node;
    //    //        if (count == 0)
    //    //            last = head;
    //    //        count++;

    //    //    }

    //    //}
    //}
}
using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        #region Вариант 1
        //static void Main(string[] args)
        //{
        //    byte[][] months = new byte[12][];
        //    months[0] = new byte[31];
        //    months[0][0] = 1;


        //}
        #endregion
        static void Main(string[] args)
        {


            var IntList = new List<int>();
            IntList.Add(55);
            Console.WriteLine(IntList[0]);
            var array = new int[10];
            Console.WriteLine(IntList[0]);
            Console.WriteLine("Добавил новое задание");
            
        }
        
    }
    public class Node
    {
        public int Info { get; set; }
        public Node Link { get; set; }

        public Node(int info,Node link)
        {
            Info = info;
            Link = link;
        }
    }
    public class SingleLinkedList // Класс «Односвязные списки»
    {
        public Node First { get; set; } // ссылка на первый узел списка
        public SingleLinkedList() // конструктор: создание пустого списка
        {
            First = null;
        }
}

    public class Node<T>
    {
        Node<T> head; // головной/первый элемент
        Node<T> last; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                last.Next = node;

            last = node;
            count++;
        }
        /// <summary>
        /// Метод добавления элемент в начало списка
        /// </summary>
        /// <param name="data">Входные параметры</param>
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                last = head;
            count++;
            
        }
        
    }
}

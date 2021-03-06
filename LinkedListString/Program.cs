﻿using System;

namespace LinkedListString
{
    class Program
    {
        static void Main()
        {
            var L = new SingleLinkedList(new string[] {"@"});

            Console.WriteLine(L.Recurse(L.First));


        }
    }
    public class Node // Класс «Узел односвязного списка»
    {
        public string Info { get; set; }
        public Node Link { get; set; }

        public Node(string info)
        {
            Info = info;
        }
        public Node(string info, Node link) : this(info)
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

        public SingleLinkedList(string[] dates) // first – ссылка на первый узел списка
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
        public void Create(string dates) // first – ссылка на первый узел списка
                                         // dates – массив значений информационных полей
        {
            Node p = new Node(dates, null); // вставка узла в начало списка
            if (First == null)
            {
                First = p;
                Last = First;
            }
            else
            {
                Last.Link = p;
                Last = p;
            }
        }
        /// <summary>
        /// Метод выводящий список на экран
        /// </summary>
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
        /// <summary>
        /// Определяет длину списка
        /// </summary>
        /// <returns>Возвращает длину списка</returns>
        public int LengthList()
        {
            Node p = First;
            int i = default;
            while (p != null)
            {
                p = p.Link;
                i++;
            }
            return i;
        }
        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="q">Список,в котором слова будут начинаться на заданную комбинацию</param>
        /// <param name="k">Список,в котором слова будут заканчиваться в заданную комбинацию</param>
        /// <param name="line">Заданная комбинация</param>
        public void AddNewElement(string s)
        {
            if (First == null)
            {
                First = new Node(s, null);
            }
            else
            {
                Node p = First;
                while (p != null)
                {
                    p = p.Link;
                }
                p = new Node(s, null);
            }
        }
        public void Result(SingleLinkedList q, SingleLinkedList k, string line)
        {
            Node o = First;//Создает ссылку ,которая будет ходить по основному списку
            for (int i = 0; i < LengthList(); i++)
            {
                if (o.Info.StartsWith(line))//Если слово начинается на данную комбинацию
                {
                    q.Create(o.Info); //Добавляет в список данное слово
                }
                if (o.Info.EndsWith(line))//Если слово заканчивается на данную комбинацию
                {
                    k.Create(o.Info);//Добавляет в список данное слово
                }
                o = o.Link;//Продвигает указать в основном списке
            }
        }
        public int Recurse(Node p)
        {
            int i;
            if (p == null)
            { 
                i = 0; 
            }
            else
            {
                i =  Recurse(p.Link) + 1;
            }
            return i;
        }

    }
}

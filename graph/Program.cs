using System;

namespace graph
{
    public class Graph
    {
        private int size; // количество вершин в графе
        private Boolean[,] adjacency; // матрица смежности (ссылка)
        private Boolean[,] achievement; // матрица достижимости (ссылка)
        private Boolean[] vector; // вектор посещенных вершин для обхода (ссылка)

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public Boolean[,] Adjacency
        {
            get { return adjacency; }
            set { adjacency = value; }
        }
        public Boolean[,] Achievement
        {
            get { return achievement; }
            set { achievement = value; }
        }
        public Boolean[] Vector
        {
            get { return vector; }
            set { vector = value; }
        }

        public Graph(int size, Boolean[,] G) // конструктор
                                             // G – матрица для инициализации матрицы смежности графа
        {
            adjacency = G; // инициализации матрицы смежности
                           // массивы одного и того же типа можно присваивать друг другу, при этом происходит
                           // присваивание ссылок, т.к. массив относится к ссылочному типу; матрица смежности ни
                           // при каких операциях изменяться не будет, поэтому такое присваивание
                           // не повлияет на матрицу G
            achievement = new Boolean[size, size]; // выделение памяти для матрицы достижимости
            vector = new Boolean[size]; // выделение памяти для вектора посещенных вершин
            for (int i = 0; i < size; i++) // инициализация вектора посещенных вершин
                vector[i] = false;
            Size = size;
        }
        public bool[,] Multiplication(bool[,] A, bool[,] B)
        {
            bool[,] multiplication = new bool[Size,Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    multiplication[i, j] = false;

                    for (int q = 0; q < Size; q++)
                    {
                        multiplication[i, j] = (A[i, q] && B[q, j]) || multiplication[i, j];
                    }
                }
            }
            return multiplication;
        }
        public void Print(int value)
        {
            Console.Write($"{value} ");
            Vector[value] = true;
            for (int i = 0; i < Size; i++)
            {
                if (Adjacency[value, i] == true && Vector[i] != true)
                { 
                    Print(i); 
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                    Print(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
}

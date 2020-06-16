using System;
using LinkedList;
namespace Hash
{
    class HashTable
    {
        private SingleLinkedList[] items;
        public HashTable(int size)
        {
            items = new SingleLinkedList[size];
        }
        public void Add(int key, int value)
        {
            if (items[GetHash(key)] == null)
            {
                items[GetHash(key)] = new SingleLinkedList();
            }

                items[GetHash(key)].Create(value);
        }
        public bool Search(int key,int value)
        {
            return !items[GetHash(key)].FindNeedInfo(value).Equals(value);
        }
        private int GetHash(int key)
        {
            return key.ToString().Length % items.Length;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hash = new HashTable(10);
            hash.Add(5,1);
            hash.Add(12,2);
            Console.WriteLine(hash.Search(12,2));
            Console.WriteLine(hash.Search(12,1));
            Console.WriteLine(hash.Search(5, 1));
            Console.WriteLine(hash.Search(11,1));
        }
    }
}

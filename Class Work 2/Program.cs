using System;

namespace Class_Work_06_03
{
    class Program
    {
        static void Recurse(int value,char start,char temp,char dest)
        {
            if (value == 1)
            {
                Console.WriteLine(start + "->" + dest);
            }
            else
            {
                Recurse(value - 1, start, dest, temp);
                Console.WriteLine(start + "->" + dest);
                Recurse(value - 1, temp, start, dest);
            }

        }
        static void Main(string[] args)
        {
            Recurse(8,'A','B','C');
        }
    }
    
}

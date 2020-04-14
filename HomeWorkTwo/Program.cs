using System;

namespace RecurseHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            long value = long.Parse(Console.ReadLine());
            Console.WriteLine("Число в двоичной СС:" + Recurse(value));


        }
        static string Recurse(long a)
        {
            string value;
            if (a == 1  || a == 0)
            {
                if (a == 1)
                {
                    value = "1";
                }
                else
                {
                    value = "0";
                }
            }
            else
            {
                value = Recurse(a / 2);
                value = value + (a % 2).ToString() ;
            }
            return value;
        }
    }
}

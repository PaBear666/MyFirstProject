using MyLib;
using System;

namespace Test
{
    enum Days : byte
    {
        Monday = 20,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInput.CheckStr("ыы"));
        }
        void NewMethod()
        {
            Console.WriteLine("Теперь изменил в самом master ");
        }
    }
}

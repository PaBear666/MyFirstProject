using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 5;
                int j = i/0;
                Console.WriteLine("пОКА");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                Console.WriteLine("ГГ");
            }
        }
    }
}

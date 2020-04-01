using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    static public class CheckInput
    {
       static public void Input(out int a, string b)
        {
            do
            {
                Console.WriteLine(b);

            } while (!int.TryParse(Console.ReadLine(), out a));
            
        }
    }
}

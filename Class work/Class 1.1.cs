using System;
using System.Collections.Generic;
using System.Text;

namespace Class_work
{
    class Class
    {
        static public int ClassWork(int a)
        {
            byte k = 0;
            while( a != 0)
            {
                if ((a&1) == 1)
                {
                    k++;
                    a = a >> 1;
                }
            }
            return k; 
        }
    }
}

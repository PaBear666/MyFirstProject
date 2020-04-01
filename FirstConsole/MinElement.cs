using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    class MinElement
    {
        public int Action(int n,int[] a)
        {
            int bucket = a[0];
            int i;
            int k = 0;
            for (i = 0; i < n; i++)
                if (bucket > a[i]) 
                {
                    bucket = a[i];
                    k = i;
                }
            return k;
        }
    }
}

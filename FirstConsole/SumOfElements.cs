using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    class SumOfElements
    {
        int _numbernegative; //Номер отрицательного числа;
         public int Sum(int[] a, int n)
        {
            int sum = 0;
            for(int i= (NegativeNumber(a, 1 ,n) + 1) ; i < NegativeNumber(a, 2 ,n) ; i++ )
            {
                sum = a[i] + sum;
            }
            return sum;
        }

        public  int NegativeNumber(int[] a, int b, int n)
        {
            int i = 0;
            int p;
            for (p = 0; p < b; p++,i++)
            {
               
               while ((i < n)  && (a[i] >=  0))
                {
                    if (!(i == n - 1))
                    {
                        i++;
                    }
                }
             
            }
            return --i;
        }
    }
}

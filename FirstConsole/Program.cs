using System;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите значение Радиуса");
            //Check_Input check = new Check_Input();
            //int a = int.Parse(Console.ReadLine());
            //check.Length_Circle = a;
            //Console.WriteLine("Значение радиуса :{0}", check.Length_Circle);
            //Console.ReadKey();
            int n; CheckInput.Input(out n, "Введите кол-во элементов массива");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Элемент {0} = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            MinElement min = new MinElement();
            Console.WriteLine("Номер минимального элемента:{0}",min.Action(n, a));
            SumOfElements sum = new SumOfElements();
            Console.WriteLine("Cумма между отрицательными элементами:{0}", sum.Sum(a,n)); 
            Console.ReadKey();
        }
    }
}

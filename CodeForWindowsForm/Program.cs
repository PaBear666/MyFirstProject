using System;

namespace CodeForWindowsForm
{
    class Program
    {
        static double It(double x)
        {
            return ((2 * x - 2) * x * x - 36) / ((3 * x - 4) * x - 15); //Ее производная
        }

        static double F(double x)
        {
            return ((x - 2) * x - 15) * x + 36; //Изначальная ф-ция
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Задание:Реализуйте рекурсивный алгоритм решения уравнения вида f(x) = x методом простых итераций");
            Console.WriteLine("f(x)=x^3 - 2*x^2 - 15*x + 36");
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите e(Точность вычислений):");
            double e = double.Parse(Console.ReadLine());
            Recurse(ref x, e, 0);
            Console.WriteLine(x);
        }
        static void Recurse(ref double x,double e,double y)
        {
            if((x - y) > e)
            {
                y = x;
                x = It(x);
                Recurse(ref x, e, y);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Car<T>
    {
        public string Name { get; }

        public T Speed { get; }

        public Car(T speed, string name)
        {
            Speed = speed;
            Name = name;
        }

        public T MaxSpeed()
        {

            return Speed;
        }
        //Как не нужно использовать перегрузку операторов
        //public static Car<T> operator + (Car<T> carfirst,Car<T> carsecond)
        //{
        //    Car<T> car = new Car<T>( carfirst.Speed + carsecond.Speed, "Автомобиль");
        //    return null;
        //}
    }
}

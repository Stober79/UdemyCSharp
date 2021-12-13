using System;

namespace GenericClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            var myClass = new MyClass<int>();// tu T ustawiamy jako int
        }
    }
    public class MyClass<T> //T daje nam możliwość wstawienia dowolnego typu np. int, double 
    {
        public T MyNumber { get; set; }
    }
}

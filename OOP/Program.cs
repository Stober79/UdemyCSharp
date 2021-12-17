using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var mazda = new Mazda(100)
            {
                Lenght = 10
            };
            Console.WriteLine(mazda.TopSpeed);
        }
        public abstract class Car //obiekt klasy abstrakcyjnej nie możę być nigdzie tworzony
        {
            protected int WheelSize { get; set; }// proteced powoduje że funkcja,zmienna, property jest dostępna w classie dziedziczącej ale nie w innych klasach gdzie jest juz tworzony obiekt klasy dziedziczącej
            public int TopSpeed { get; set; }//klasa internal jest tylko widoczna w obrębie projektu
            public int Lenght { get; set; }
            public abstract string Name { get; } //jak niżej
            public abstract void Drive();// taka funkcja nie ma ciała ale dzięki słowu abstract wymuszą jej stworzenia w klassa dziedziczących
            public Car(int topSpeed)//konstruktor obiektu Carustawiający wartość Topspeed
            {
                TopSpeed = topSpeed;
            }
        }
        public class Porshe : Car 
        {
            public Porshe(int topSpeed): base(topSpeed) // konstruktor Proshe dziedziczy wywołany w konstruktorze Car Topspeed
            {
                    
            }
            public override string Name => "Porshe";
            public override void Drive()//override nadppisuje funkcje z klasy rodzica
            {

            }
            

        }
        public sealed class Mazda : Porshe//dziedziczenie po dówch klsach. Muszą być w hierarchii. Nie możena dziedziczyć po dwoch klsach nie będących w hierarchii  Sealed powoduje że nie możemy tej klasy dziedziczyć
        {
            public override string Name => "Mazda";
            public Mazda(int topSpeed): base(topSpeed)
            {
                WheelSize = 10;

            }
            public override void Drive()
            {

            }
        }

    }
}

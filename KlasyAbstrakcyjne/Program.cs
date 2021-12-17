using System;
using System.Collections.Generic;
using System.Linq;

namespace KlasyAnonimowe
{
    class Program
    {
        private static void Main(string[] args)
        {
            var a = new  ///klasa anonimowa
            {
                ValueOfSomething = 5,
                ValueOfSoemethingElse = "test"
            };
            var listOfInts = new List<int>
            {
                2,3,8,1,10,15
            };
            var listOfStrings = new List<string>()
            {
                "cos", "tam", "jest", "fajnego"
            };
            var listOfUsers = new List<User>
            {
                new User
                {
                    Name = "Patryk",
                    Age =21,
                    Email = "test@email.com"
                },
                new User
                {
                    Name = "Robert",
                    Age = 42,
                    Email= "moj@email.com"
                },
                new User
                {
                    Name= "Przemas",
                    Age = 42,
                    Email = "moj2@email.com"
                }

            };

            var someIntsFromList = listOfInts.Where(x => x > 5).ToList();
            someIntsFromList.ForEach(x => Console.WriteLine(x));// to robi to samo co poniższy foreach

            Console.WriteLine(listOfUsers.Average(x => x.Age));//średnia w liście obiektów Users, trzeba podać w wyrażeniu który propertis ma być użyty 
            var intConvertedToStrings = listOfInts.Select(x => x.ToString()).ToList();//Select pozwala zmienić typ np z int na stringi lub coś dodać jak poniżej
            var strings = intConvertedToStrings.Select(x => x + " coś tam").ToList();
            strings.ForEach(x => Console.WriteLine(x));

            var viewModels = listOfUsers.Select(x => new UserViewModels // dzięki selectowi może zmienić listę Użytkowników na listę obiektów klasy userViewModel
            {
                Age = x.Age,
                Name = x.Name,
                Email = x.Email,
                Title = GetUserTitle(x.Age)
            }).ToList();

            foreach (var valueInt in listOfInts.Where(x => x > 5))
            {
                Console.WriteLine(valueInt);
            }
            var rand = new Random();
            
            List<List<int>> tablicaInt = new List<List<int>>();

            for (var j = 0; j < 10; j++)
            {
                List<int> listaI = new List<int>();
                for (var i = 0; i < 10; i++)
                {
                    listaI.Add(rand.Next(0, 5));
                };
                tablicaInt.Add(listaI);
            };
            tablicaInt.ForEach(x =>
            {
                x.ForEach(y => Console.Write(y));
                Console.WriteLine();
            });
            Console.WriteLine();
            tablicaInt.ForEach(x =>
            {
                x.ForEach(y =>
                {
                    if (y == 1)
                        y = 6;///nie zmienia wartośći na stałe tylko w tym miejscu przy wyświteleniu
                    Console.Write(y);
                });
                Console.WriteLine();
            });

            listOfUsers.ForEach(x =>  Console.WriteLine(x.Name + " " + x.Age.ToString() + " " + x.Email));
            var listfP = listOfUsers.Where(x => x.Name.Contains("P")).ToList();
            listfP.ForEach(x=>Console.WriteLine(x.Name));
            viewModels.ForEach(x => Console.WriteLine(x.Name + " " + x.Age + " " + x.Email + " " + x.Title));
        }

        private static string GetUserTitle(int userAge)
            => userAge > 22 ? "Title1" : "No title";
        

    }
}
using System;
using System.Collections.Generic;

namespace LambdyDelegatyFunkcjeAnonimowe
{
    class Program
    {
        public delegate int  DelegataName(int a);
        private static void Main(string[] args)
        {
            //Delegaty
            var someVariable = new DelegataName(SomeFunction1);
            SomeFunction2(someVariable); //delegata wywołuje jedną funkcję w drugiej
            DelegataName someVariable22 = delegate (int a) { return 2; };// funkcja anonimowa
            DelegataName someVariable23 =  (a) => 2;//wyrażenie lambda nawiasy wokół a nie są potrzebne jeśli tylko jedna zmienna jest wywoływana
            //Func<int,int> someVariable = (a) => 2; inny sposób nie wymaga deklarowania public delegate int DelegataName (int a)

            var listOfString = new List<string>
            {
                "a","b","c,","d","e","f"
            };

            var stringMatching = GetFirstOrDefault(listOfString,(someString)=> someString.StartsWith('b'));
            Console.WriteLine(stringMatching);
        }
        private static int SomeFunction1(int a)
        {
            return 2;
        }
    
        private static void SomeFunction2(DelegataName someFunction1)
        {
            someFunction1(6);
        }
         private static string GetFirstOrDefault(List<string> strings, Func<string, bool> functionToCheck)
         {
            foreach(var item in strings)
            {
                if(functionToCheck(item))
                {
                    return item;
                }

            }
            return null;
         }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCSharp
{
    //public class NewFeature
    //{
    //    public int Variable { get; set; }  //właściwości get i set można bardziej rozbudować
    //    private static void Main(string[] args)
    //    {
    //        var myClass = new MyClass();
    //        var someOutput = default(double);
    //        var firstNumber = 5;
    //        var secondNumber = 2;
    //        var operation = 1;
    //        //if(myClass.Variable==null)
    //        //{
    //        //    myClass.Variable = "costam2";
    //        //} tego ifa można zastąpić :
    //        myClass.Variable ??= "cośtam 2"; //sprawdza czy jest nullem a jak jest to zmiena na podaną wartość
    //        Console.WriteLine(myClass?.Variable);// znak zapytania obsługuje null czyli jeśli jest null to nie wywala błędu
    //        //switch (operation)
    //        //{
    //        //    case 1:
    //        //        someOutput = firstNumber + secondNumber;
    //        //        break;
    //        //    case 2:
    //        //        someOutput = firstNumber - secondNumber;
    //        //        break;
    //        //    case 3:
    //        //        someOutput = firstNumber / secondNumber;
    //        //        break;
    //        //    case 4:
    //        //        someOutput = firstNumber * secondNumber;
    //        //        break;
    //        //    default:
    //        //        someOutput = 0;
    //        //        break;
    //        //} tego sitcha można zamienić na te kilka linijek
    //        someOutput = operation switch
    //        {
    //            1 => firstNumber + secondNumber,
    //            2 => firstNumber - secondNumber,
    //            3 => firstNumber / secondNumber,
    //            4 => firstNumber * secondNumber,
    //            _ => 0,
    //        };
    //        var a = myClass.FunctionWichReturnsTwoValues();
    //        var b = a.Item1; // wten spsoób dostajemy się do kolejno zwracanych wartości z funkcji która zwraca kilka wartości
    //        var c = a.Item2;
    //        var z = myClass.FunctionTest();
    //        var x = z.Item2;
    //    }
    //}
     public class MyClass
    {
        public string Variable { get; set; }

        public (int,bool) FunctionWichReturnsTwoValues()
        {
            return (5 + 2, true);
        }
        public (int, double) FunctionTest()
        {
            var intValue = 2;
            var doubleValue = 5.0;
            return (intValue,doubleValue );
        }
    }
}

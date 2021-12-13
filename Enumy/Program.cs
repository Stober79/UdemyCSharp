using System;

namespace Enumy
{
    class Program
    {
        public static void Main(string[] args)
        {
            HumanSize hight = HumanSize.Small;
            var humanSize = HumanSize.Big;
            var size = (HumanSize)0;//kastowanie inta (0) na HumanSize dale wartość enuma na 0 pozycji
            int value = (int)humanSize; //rzutowanie enuma na inta
            var userPermissions = UserPermissions.Create | UserPermissions.Read; //sumowanie enumów za pomocą pipa czyli znaku "|"
            if ((userPermissions & UserPermissions.Read) == UserPermissions.Read)// sprawdzanie czy w sumie enumów mieści się któryś
            {
                Console.WriteLine("User has permmission: " + UserPermissions.Read.ToString());
            }
            foreach (var enumValue in Enum.GetValues(typeof(UserPermissions)))// Enum.GetVale pobiera wszystkie wartości enuma dodanie typof powdouje że wskazujemy konkretnego enuma
            {
                Console.WriteLine(enumValue);
            }
        }

    }
    public enum HumanSize//normalnie tworzy się Enumy w osobnych plikach jak klasy
    {
        Small,
        Mediuim,
        Big
    }
    public enum UserPermissions
    {
        Create =1, //przypisujemy wartosći kolejnych bitów 
        Dleate =2,
        Edit = 4,
        Read = 8
    }
}

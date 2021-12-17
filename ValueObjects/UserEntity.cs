using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    public class UserEntity //Entity zawierają tylko propertiys bez funkcji
    {
        public string Name { get; set; }
        public string Email{get;set;}
        public int Age { get; set; }
    }
}

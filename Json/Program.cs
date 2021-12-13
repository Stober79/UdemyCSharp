using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Json
{
    class Program
    {
        private static void Main(string[] args)
        {
            var someObject = new JsonExample()
            {
                UserName = "Some UserNAme",
                SomeStrings = new List<string>
                {
                    "a","d"
                },
                Value = 8
            };
            var json = JsonConvert.SerializeObject(someObject);
            var someOtherObject = JsonConvert.DeserializeObject<JsonExample>(json);
        }
    }
}


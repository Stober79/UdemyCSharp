using System;
using System.Collections;
using System.Collections.Generic;

namespace III
{
    class Program
    {
        private static void Main(string[] args)
        {
            
        }
    }
    public class MyEnumerablte<T>: IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    //
    public class Printer<T> where T: class
    { 
        public void Print(T t)
        {
            Console.WriteLine(t);
        }
    }
}

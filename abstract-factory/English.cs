using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // ConcreteProductA1
    public class English : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
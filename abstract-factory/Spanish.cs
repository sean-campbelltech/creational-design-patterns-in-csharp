using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // ConcreteProductA2
    public class Spanish : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hola!");
        }
    }
}
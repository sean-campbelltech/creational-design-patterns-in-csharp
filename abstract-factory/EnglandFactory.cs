using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // ConcreteFactory1
    public class EnglandFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}
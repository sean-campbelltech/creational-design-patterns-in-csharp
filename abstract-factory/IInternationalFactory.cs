using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // AbstractFactory
    public interface IInternationalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity CreateCapital();
    }
}
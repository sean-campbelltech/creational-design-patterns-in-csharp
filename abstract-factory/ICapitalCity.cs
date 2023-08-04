using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // AbstractProductB
    public interface ICapitalCity
    {
        int GetPopulation();
        List<string> ListTopAttractions();
    }
}
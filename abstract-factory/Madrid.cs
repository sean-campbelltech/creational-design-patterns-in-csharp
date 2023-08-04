using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // ConcreteProdctB2
    public class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            return 3200000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Royal Palace", "Prado Museum", "Retiro Park" };
        }
    }
}
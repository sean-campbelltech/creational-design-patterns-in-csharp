using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryCSharp
{
    // ConcreteProductB1
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 8900000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Tower Bridge", "Buckingham Palace", "Big Ben" };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryCSharp;

namespace abstractfactory
{
    public class InternationalProvider
    {
        public static IInternationalFactory Create(Country country)
        {
            switch (country)
            {
                case Country.England:
                    return new EnglandFactory();

                case Country.Spain:
                    return new SpainFactory();

                default:
                    throw new NotSupportedException($"{country} not yet supported.");
            }
        }
    }
}